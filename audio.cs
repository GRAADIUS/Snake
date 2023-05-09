using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Snake
{
    public class audio
    {
        public async Task tagaplaanis_mangida(string Path)
        {
            await Task.Run(() =>
            {
                using (AudioFileReader audioFileReader = new AudioFileReader(Path))
                using (IWavePlayer waveOutDevice = new WaveOutEvent { DesiredLatency = 200, Volume = 50 })
                {
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    while (waveOutDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1000);
                    }
                }
            });
        }
        public async Task natuke_mangida(string Path)
        {
            await Task.Run(() =>
            {
                using (AudioFileReader audioFileReader = new AudioFileReader(Path))
                using (IWavePlayer waveOutDevice = new WaveOutEvent())
                {
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    while (waveOutDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(50);
                    }
                }
            });
        }
    }
}
