using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    public class MKV : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Start playing .mkv");
        }
        public void Pause()
        {
            Console.WriteLine("Pause .mkv");
        }
        public void Stop()
        {
            Console.WriteLine("Stop .mkv");
        }
    }
}
