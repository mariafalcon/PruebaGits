using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestEj
{


    public class PlayList<T>
    {
        T[] medialist = new T[] { };

        List<T> m = new List<T>();

        public void Add(T media) { 
        }    

        public void PlayAll()
        {
            foreach(T media in medialist)
            {
                Console.WriteLine($"{media}");
            }
        }

        public void Preview()
        {
            if (m.Count > 0) {
                Console.WriteLine(m[0]);
            }
        }
    
    
    
    }
}
