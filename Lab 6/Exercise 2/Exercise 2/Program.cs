using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MP3 mp3music = new MP3();
            WAV wavmusic = new WAV();
            MKV mkvmusic = new MKV();
            PlayerItem music = new PlayerItem();

            Console.WriteLine("All music in folder");
            music.GETPath();

            /*Вопрос:
              Как вытащить значения массива из метода music.GETPath();? Чтобы потом ими манипулировать
            */
        }
    }
}
