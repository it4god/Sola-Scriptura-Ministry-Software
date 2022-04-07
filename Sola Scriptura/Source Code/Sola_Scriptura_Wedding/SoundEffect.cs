//Cacophony version 1.0 by Jason Merlo.

using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

namespace nsSoundz
{
	/// <summary>
	/// A SoundEffect represents one .wav file and can be played asynchronously as needed.
	/// </summary>
	public class SoundEffect
  {
    AudioStream mAudioStream;             //The Stream class used to read and hold our .wav data.
    AudioPlayer[] mAudioPlayers = null;   //An array of our AudioPlayer instances.
    int mCurrentPlayer = 0;               //Which player is next in line?
    int mMaxInstances = 0;                //How many of this sound at once do we want to support?

		public SoundEffect(string FileName, int MaxInstances)
		{
      //Constructor for creating a SoundEffect instance from a wave file on the hard drive.
      //Create a new AudioStream to hold this wave file's data.
      mAudioStream = new AudioStream(FileName);
      //Finish up initialization.
      CreatePlayers(MaxInstances);
		}

    public SoundEffect(Stream WaveStream, int MaxInstances)
    {
      //Constructor for creating a SoundEffect instance from a wave file that already exists as a Stream.
      //Create a new AudioStream to hold this wave file's data.
      mAudioStream = new AudioStream(WaveStream);
      //Finish up initialization.
      CreatePlayers(MaxInstances);
    }

    private void CreatePlayers(int MaxInstances)
    {
      //Just create however many players we'll need.
      //Keep the maximum number of instances.
      mMaxInstances = MaxInstances;

      //Create the array of players.
      mAudioPlayers = new AudioPlayer[mMaxInstances];
      for (int i = 0; i < mMaxInstances; i++) {mAudioPlayers[i] = new AudioPlayer(mAudioStream, -1);}
    }

    ~SoundEffect()
    {
      //Destructor.
      //We need to properly dispose of each of our AudioPlayers.
      for (int i = 0; i < mMaxInstances; i++) {mAudioPlayers[i].Dispose();}
    }

    public void Play()
    {
      //Play a new instance of this sound in its own thread!
      Thread tThread = new Thread(new ThreadStart(this.SoundEffectInstanceEntryPoint));
      tThread.IsBackground = true;
      tThread.Start();
    }

    private void SoundEffectInstanceEntryPoint()
    {
      //We need to play our sound effect on the next AudioPlayer in line.
      if (++mCurrentPlayer >= mMaxInstances) mCurrentPlayer = 0;
      //Play the sound.
      mAudioPlayers[mCurrentPlayer].Play();
    }
	}
}
