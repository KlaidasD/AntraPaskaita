using System;

namespace AntraPaskaita

    /*Sukurkite ciklą kuris atspausdintų 10 kartų žodį "labas".
    Sukurkite ciklą kuris atspausdintų skaičius nuo 0 iki 9.
    Atspausdinkite kas antrą skaičių nuo 10 iki 50 (porinius);*/
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Labas");
            }

            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 10; i < 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}