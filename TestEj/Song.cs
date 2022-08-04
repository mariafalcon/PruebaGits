using System;
using System.Collections.Generic;
using System.Text;

namespace TestEj
{
    public class Song : IMedia
    {

        public long Seconds { get; set; }

        public string Title { get; set; }

        public ShelvePosition Pòsition { get; set; }

        public void Play()
        {
            // throw new NotImplementedException();
            Console.WriteLine($"Playing: {Title}");
        }
    }
}
