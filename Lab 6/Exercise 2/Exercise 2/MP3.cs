using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    class MP3 : IRecordable
    {
        public void Record()
        {
            Console.WriteLine("Start recording .mp3");
        }
        public void Pause()
        {
            Console.WriteLine("Pause .mp3");
        }
        public void Stop()
        {
            Console.WriteLine("Stop .mp3");
        }
    }
}
