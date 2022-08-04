using System;
using System.Collections.Generic;
using System.Text;

namespace TestEj
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s = new Song();
            s.Title = "Story of my Life";
            s.Seconds = 350;
            s.Pòsition = new ShelvePosition(2, 1);
            s.Play();

            Song s1 = new Song();
            s1.Title = "My darkness";
            s1.Seconds = 400;
            s1.Pòsition = new ShelvePosition(1, 1);
            s1.Play();

            PlayList<Song> playListsongs = new PlayList<Song>();

            playListsongs.Add(s);
            playListsongs.Add(s1);

            WriteLineSpecial(s, "Story", "My Life");

            Console.WriteLine(s1.ToString());

            Tuple<int, string, Song> tuple = new Tuple<int, string, Song>(1, "hola", s);
;

            Console.Write("Introduzca su edad: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);

            Console.WriteLine("Introduzca la edad de su padre: ");
            string edadP = Console.ReadLine();
            int edadP1 = int.Parse(edadP);

            int restaEdad = edadP1 - edad1;
             
            Console.WriteLine("la  diferencia de edad es de: " + restaEdad +" años");

            //String Builder crea string mutables

            StringBuilder hola = new StringBuilder("HOLA");

            //Array multidimensional

            string[,] ArrayCiudades = new string[2, 5];

            ArrayCiudades[0, 1] = "Valencia";
            ArrayCiudades[0, 2] = "Madrid";
            ArrayCiudades[0, 3] = "Barcelona";
            ArrayCiudades[0, 4] = "etc";

            //Array multidemnsional Jagged, columnas diferentes. Array dentro de ottro.

            string[][] n = new string[2][];

            n[0] = new string[2];

            Console.ReadKey();
        }

        static void WriteLineSpecial<T>(T data, string prefix, string suffix) {
            Console.WriteLine($"{prefix} {data} {suffix} ");
        }

       private static void ListExplanation()
        {

            List<int> numbers = new List<int>();

            numbers.Add(0);
        }

        private static void StackExplanation()
        {
            Stack<Song> salesSongs = new Stack<Song>();

            salesSongs.Push(new Song());
            salesSongs.Push(new Song());
            Song song = salesSongs.Pop();
        }

        private static void QueueExplanation()
        {
            Queue<int> queueNumbers = new Queue<int>();
            queueNumbers.Enqueue(1);
            queueNumbers.Enqueue(2);

            int number = queueNumbers.Dequeue();

        }
    }
}
