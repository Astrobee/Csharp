using WMPLib;
using System.Media;

namespace Wordy
{
    class Sounds
    {
         WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        
        internal void BackMusic()
        {
            wmp.settings.setMode("loop", true);
            wmp.URL = "wordyMusic.wav";
                wmp.controls.play();  
        }

        internal void BackMusicStop()
        {
            wmp.URL = "wordyMusic.wav";
            wmp.controls.stop();
        }


        internal void correctSound()
        {
            SoundPlayer sCorrect = new SoundPlayer(Properties.Resources.correctSound);
            sCorrect.Play();
        }

        internal void typedSound()
        {
            SoundPlayer styped = new SoundPlayer(Properties.Resources.try_again);
            styped.Play();
        }

        internal void alarmPlay()
        {
            SoundPlayer alarmplay = new SoundPlayer(Properties.Resources.alarm_clock);
            alarmplay.Play();
        }

        internal void alarmStop()
        {
            SoundPlayer alarmplay = new SoundPlayer(Properties.Resources.alarm_clock);
            alarmplay.Stop();
        }


        internal void wrongSound()
        {
            SoundPlayer wrongsound = new SoundPlayer(Properties.Resources.wrong);
            wrongsound.Play();
            
        }

        
    }
}
