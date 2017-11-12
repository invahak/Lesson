using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace labirint2d
{
    static class Sound
    {
        static SoundPlayer fail = new SoundPlayer(Properties.Resources.fail);
        static SoundPlayer finish = new SoundPlayer(Properties.Resources.finish);
        static SoundPlayer start = new SoundPlayer(Properties.Resources.start);
        static SoundPlayer key = new SoundPlayer(Properties.Resources.key);
        static bool sound_enabled = true;

        public static void sound_on()
        {
            sound_enabled = true;
        }

        public static void sound_off()
        {
            sound_enabled = false;
        }


        public static void Play_fail()
        {
            if (sound_enabled)
            fail.Play();
        }
        public static void Play_finish()
        {
            if (sound_enabled)
                finish.Play();
        }
        public static void Play_start()
        {
            if (sound_enabled)
                start.Play();
        }
        public static void Play_key()
        {
            if (sound_enabled)
                key.Play();
        }
    }
    
}
