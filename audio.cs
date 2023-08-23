using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;


namespace Test_Snake
{
    class Music
    {
        public void playMusic()
        {
            IWavePlayer waveOutDevice = new WaveOutEvent();
            AudioFileReader audioFileReader = new AudioFileReader("../../../Sound.mp3");
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }
        public void ifEat()
        {
            Console.Beep(600, 50);
            Console.Beep(700, 50);
            Console.Beep(800, 50);
        }
        public void ifDeath()
        {
            Console.Beep(800, 300);
            Console.Beep(700, 300);
            Console.Beep(600, 300);
            Console.Beep(500, 500);
        }
    }
}
