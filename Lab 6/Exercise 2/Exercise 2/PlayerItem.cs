using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercise_2
{
    class PlayerItem : IMedia
    {
        string DIRFiles = @"E:\PROJECTS\Lab 6\Exercise 2\Media";

        public void GETPath()
        {
            List<string> files = new List<string>();
            String dir = @"E:\PROJECTS\Lab 6\Exercise 2\Media";

            foreach (string j in Directory.GetFiles(dir, "*.*"))
            {
                files.Add(j);
            } 
            
            foreach (string d in files)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
