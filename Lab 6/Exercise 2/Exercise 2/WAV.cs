using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    class WAV : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Start playing .wav");
        }
        public void Record()
        {
            Console.WriteLine("Start recording .wav");
        }
        public void Pause()
        {
            Console.WriteLine("Pause .wav");
        }
        public void Stop()
        {
            Console.WriteLine("Stop .wav");
        }
    }
}
