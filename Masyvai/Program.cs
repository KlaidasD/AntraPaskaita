using System;
using System.Runtime.Serialization;

namespace AntraPaskaita

/*     */
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] skaiciai = { 16, 23, 13, 44, 95, 16, 27, };
            Console.WriteLine(skaiciai[3] + skaiciai[1]);
            skaiciai[1] = -77;
            Console.WriteLine(skaiciai[3] + skaiciai[1]);

            int[] skaiciai2 = new int[10];
            skaiciai[0] = 55;
            skaiciai[1] = 12;
            skaiciai[2] = 76;
            skaiciai[3] = 53;
            skaiciai[4] = 5;

            int suma = 0;

            for (int i = 0; i < skaiciai.Length; i++)
            {
                suma += skaiciai[i];
            }
            Console.WriteLine(suma);

        }
    }
}