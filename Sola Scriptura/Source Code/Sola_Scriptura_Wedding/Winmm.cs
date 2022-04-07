//Cacophony version 1.0 by Jason Merlo.

using System;
using System.Runtime.InteropServices;

namespace nsSoundz
{
	/// <summary>
	/// This class houses all external Win32 calls we'll be making.
	/// </summary>
	public class Winmm
	{
    //Win32 functions.  Note that we don't use all of these, but they're fun to play with.
    [DllImport("winmm.dll")]
    public static extern int waveOutPrepareHeader(IntPtr hWaveOut, ref WaveHeader lpWaveOutHdr, int uSize);
    [DllImport("winmm.dll")]
    public static extern int waveOutUnprepareHeader(IntPtr hWaveOut, ref WaveHeader lpWaveOutHdr, int uSize);
    [DllImport("winmm.dll")]
    public static extern int waveOutWrite(IntPtr hWaveOut, ref WaveHeader lpWaveOutHdr, int uSize);
    [DllImport("winmm.dll")]
    public static extern int waveOutOpen(out IntPtr hWaveOut, int uDeviceID, WaveFormat lpFormat, AudioDelegate dwCallback, int dwInstance, int dwFlags);
    [DllImport("winmm.dll")]
    public static extern int waveOutReset(IntPtr hWaveOut);
    [DllImport("winmm.dll")]
    public static extern int waveOutClose(IntPtr hWaveOut);
    [DllImport("winmm.dll")]
    public static extern int waveOutSetVolume(IntPtr hWaveOut, int dwVolume);
    [DllImport("winmm.dll")]
    public static extern int waveOutGetNumDevs();    
    [DllImport("Kernel32")]
    public static extern Boolean CloseHandle(IntPtr handle);
  }

  //This struct dictates the format of the wave we are playing.  Taken from MSDN library.
  //We force it to be located sequentially in memory since we'll be accessing it with unmanaged calls!
  [StructLayout(LayoutKind.Sequential)] public class WaveFormat
  {
    public short wFormatTag;     //Identifier.
    public short nChannels;      //The number of audio channels in this wave.
    public int nSamplesPerSec;   //The sample frequency of this wave.  CD quality = 44100Hz.
    public int nAvgBytesPerSec;  //Average number of bytes for one second of audio.  Calculated.
    public short nBlockAlign;    //The size of each chunk of data in the wave.
    public short wBitsPerSample; //Data bits per audio sample.  CD quality = 16.
    public short cbSize = 0;

    //Plain constructor.  Member variables will be populated by the .wav file header.
    public WaveFormat() {}
  }

  //This struct contains wave header information.  Taken from MSDN library.
  //We force it to be located sequentially in memory since we'll be accessing it with unmanaged calls!
  [StructLayout(LayoutKind.Sequential)] public struct WaveHeader
  {
    public IntPtr lpData;       //Pointer to the wave data itself.
    public int dwBufferLength;  //The length of the wave data.
    public int dwBytesRecorded; //Not used.
    public IntPtr dwUser;       //Who's doing this function call?
    public int dwFlags;         //Whatever flags are currently configured (See AudioConst class).
    public int dwLoops;         //Does this sound repeat?
    public IntPtr lpNext;       //Reserved for driver.
    public int reserved;        //Reserved for driver.
  }

  //Callback delegate.  Some Winmm functions need this, but we won't actually use it.
  public delegate void AudioDelegate(IntPtr hdrvr, int uMsg, int dwUser, ref WaveHeader wavhdr, int dwParam2);

  public class AudioConst
  {
    //Application constants.
    public const string FORMAT_ERROR = "Invalid file format.";
    public const string FUNCTION_ERROR = "Invalid function.";
    public const string RIFF = "RIFF";
    public const string WAVE = "WAVE";
    public const string FMT = "fmt ";
    public const string DATA = "data";
  }
}
