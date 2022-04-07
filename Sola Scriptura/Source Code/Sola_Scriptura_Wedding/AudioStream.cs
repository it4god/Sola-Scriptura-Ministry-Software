//Cacophony version 1.0 by Jason Merlo.

using System;
using System.IO;
using System.Threading;

namespace nsSoundz
{
	/// <summary>
	/// An AudioStream holds an I/O stream which contains sound data.
	/// It also ensures that only one caller can access this data at a time.
	/// </summary>
	public class AudioStream 
  {
    private Stream mStream;      //The root Stream object that we use to get wave data.
    private long mDataPos;       //The position at which data starts after the header.
    private int mBufferSize;     //The length of this stream.
    private int mTimeOn;         //The amount of time the sound plays before we cut it off!
    private WaveFormat mFormat;  //Used to hold header data that defines the format of this wave.

    //This mutex is used to prevent two simultaneous sounds from touching this stream data at the same time.
    private Mutex StreamMutex = new Mutex();

    //Accessors.
    public int BufferSize {get {return mBufferSize;}}
    public int TimeOn {get {return mTimeOn;}}

    #region Audio Stream Initialization

    public AudioStream(string FileName)
    {
      //Constructor for loading wave data from a file.
      StreamMutex.WaitOne();
      //We use a FileStream to get the audio data.
      mStream = new FileStream(FileName, FileMode.Open);
      //Get the wave header information out of the way.
      ReadHeader();
      //Calculate the time in milliseconds it takes to play this wave.
      mTimeOn = (mBufferSize * 1000 / mFormat.nAvgBytesPerSec);
      //Be tidy.
      StreamMutex.ReleaseMutex();
    }

    public AudioStream(Stream WaveStream)
    {
      //Constructor for loading wave data from a Stream.
      StreamMutex.WaitOne();
      //We are already given a stream!  Just use it.
      mStream = WaveStream;
      //Get the wave header information out of the way.
      ReadHeader();
      //Calculate the time in milliseconds it takes to play this wave.
      mTimeOn = (mBufferSize * 1000 / mFormat.nAvgBytesPerSec);
      //Be tidy.
      StreamMutex.ReleaseMutex();
    }

    private void ReadHeader()
    {
      //We need to read the .wav file byte-wise so we use a BinaryReader.
      BinaryReader tReader = new BinaryReader(mStream);

      //The first 16 bytes of the header must be "RIFFxxxxWAVEfmt "
      if (Read4Bytes(tReader) != AudioConst.RIFF) throw new Exception(AudioConst.FORMAT_ERROR);
      tReader.ReadInt32();
      if (Read4Bytes(tReader) != AudioConst.WAVE) throw new Exception(AudioConst.FORMAT_ERROR);
      if (Read4Bytes(tReader) != AudioConst.FMT) throw new Exception(AudioConst.FORMAT_ERROR);

      //The next 4 bytes describe the length of the wave format section.  Must be at least 16 bytes.
      int WaveLength = tReader.ReadInt32();
      if (WaveLength < 16) throw new Exception(AudioConst.FORMAT_ERROR);

      //Now we create a WaveFormat object to hold the header information.
      //There are 16 bytes here!  This is why the wave format length must be at least 16.
      mFormat = new WaveFormat();
      mFormat.wFormatTag = tReader.ReadInt16();      //The type of audio file this is.
      mFormat.nChannels = tReader.ReadInt16();       //The number of audio channels.
      mFormat.nSamplesPerSec = tReader.ReadInt32();  //The sample rate.  44100Hz is CD-quality.
      mFormat.nAvgBytesPerSec = tReader.ReadInt32(); //How many bytes per second are encoded here.
      mFormat.nBlockAlign = tReader.ReadInt16();     //The size of each data block.
      mFormat.wBitsPerSample = tReader.ReadInt16();  //The number of bits used for each sample.  16 is CD-quality.

      //There may be dead space in the wave format section, so skip to the point
      //indicated by the wave format length, which we read earlier.
      WaveLength -= 16;      //We already read these 16 bytes above!
      while (WaveLength > 0) {tReader.ReadByte(); WaveLength--;}

      //Find the data section.  It's marked by the text "data".    :)
      bool Done = false;
      while (!Done)
      {
        if (mStream.Position < mStream.Length)
        {
          string tD = Read4Bytes(tReader);
          if (tD == AudioConst.DATA) Done = true;
        }
        else Done = true;
      }

      //Get out if we didn't find any "data".
      if (mStream.Position >= mStream.Length) throw new Exception(AudioConst.FORMAT_ERROR);

      //The next four bytes are the length of the wave data.  Record the length and where it starts.
      mBufferSize = tReader.ReadInt32();
      mDataPos = mStream.Position;
    }

    private string Read4Bytes(BinaryReader Reader)
    {
      //This function reads 4 bytes at a time from the passed reader and returns them as ASCII.
      byte[] tB = new byte[4];
      Reader.Read(tB, 0, tB.Length);
      return System.Text.Encoding.ASCII.GetString(tB);
    }

    #endregion

    #region Utilities

    //These functions just assist the important stuff up above.

    public long Position
    {
      //Accessor.
      get
      {
        //Return the data position.  Remember, we have to ignore the header!
        return (mStream.Position - mDataPos);
      } 
      set
      {
        //Setting the data position.  Remember to skip past the header!
        StreamMutex.WaitOne();
        mStream.Position = value + mDataPos;
        StreamMutex.ReleaseMutex();
      }
    }

    public void Read(IntPtr Data)
    {
      //Read data from the specified position, and copy it directly to the passed pointer.
      StreamMutex.WaitOne();
      //First, set our data pointer to the beginning.
      Position = 0;
      //Prepare a byte array to read in all the sound data.
      byte[] Buffer = new byte[BufferSize];
      //Read everything we can into this buffer.
      int RealEnd = (int)(Math.Min(mStream.Length, mBufferSize - Position));
      int NumRead = mStream.Read(Buffer, 0, RealEnd);
      //Copy this byte array directly over to the buffer (if we found any data, that is).
      if (NumRead > 0) System.Runtime.InteropServices.Marshal.Copy(Buffer, 0, Data, BufferSize);
      StreamMutex.ReleaseMutex();
    }

    #endregion

    #region Win32 Function Calls

    //We put all Win32 function calls here so that we can share the Stream Mutex,
    //which prevents the Win32 functions from firing simultaneously when there's more than one instance of a sound effect.

    public void waveOutPrepareHeader(IntPtr hWaveOut, ref WaveHeader lpWaveOutHdr, int uSize)
    {
      StreamMutex.WaitOne();
      try {Winmm.waveOutPrepareHeader(hWaveOut, ref lpWaveOutHdr, uSize);} catch {}
      StreamMutex.ReleaseMutex();
    }

    public void waveOutUnprepareHeader(IntPtr hWaveOut, ref WaveHeader lpWaveOutHdr, int uSize)
    {
      StreamMutex.WaitOne();
      try {Winmm.waveOutUnprepareHeader(hWaveOut, ref lpWaveOutHdr, uSize);} catch {}
      StreamMutex.ReleaseMutex();
    }

    public void waveOutOpen(out IntPtr hWaveOut, int uDeviceID, AudioDelegate dwCallback, int dwInstance, int dwFlags)
    {
      StreamMutex.WaitOne();
      try {Winmm.waveOutOpen(out hWaveOut, uDeviceID, mFormat, dwCallback, dwInstance, dwFlags);} catch {hWaveOut = IntPtr.Zero;}
      StreamMutex.ReleaseMutex();
    }
    
    public void waveOutWrite(IntPtr hWaveOut, ref WaveHeader lpWaveOutHdr, int uSize)
    {
      StreamMutex.WaitOne();
      try {Winmm.waveOutWrite(hWaveOut, ref lpWaveOutHdr, uSize);} catch {}
      StreamMutex.ReleaseMutex();
    }
    
    public void waveOutSetVolume(IntPtr hWaveOut, int dwVolume)
    {
      StreamMutex.WaitOne();
      try {Winmm.waveOutSetVolume(hWaveOut, dwVolume);} catch {}
      StreamMutex.ReleaseMutex();
    }

    public void waveOutReset(IntPtr hWaveOut)
    {
      StreamMutex.WaitOne();
      try {Winmm.waveOutReset(hWaveOut);} catch {}
      StreamMutex.ReleaseMutex();
    }

    public void waveOutClose(IntPtr hWaveOut)
    {
      StreamMutex.WaitOne();
      try {Winmm.waveOutClose(hWaveOut);} catch {}
      StreamMutex.ReleaseMutex();
    }

    public void CloseHandle(IntPtr handle)
    {
      StreamMutex.WaitOne();
      try {Winmm.CloseHandle(handle);} catch {}
      StreamMutex.ReleaseMutex();
    }

    #endregion
	}
}
