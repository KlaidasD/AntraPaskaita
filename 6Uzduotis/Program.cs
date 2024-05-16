using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace AntraPaskaita

/*  6. Užduotis: Užduotis: Temperatūrų vidurkio skaičiavimas
Parašykite programą, kuri leidžia vartotojui įvesti temperatūras kelias dienas.
Masyvas turi būti naudojamas temperatūroms saugoti. 
Po to, kai visos temperatūros įvestos, programa turi naudoti for ciklą, kad apskaičiuotų ir išvestų temperatūrų vidurkį..   */

{
    public class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite temperatūrą 3 dienas iš eilės, suskaičiuosime temperatūros vidurkį.");
            double[] temp = new double[3];
            double suma = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1} Diena:");
                temp[i] = int.Parse( Console.ReadLine());
                suma += temp[i];

            }

            double vidurkis = suma / 3;
         

            Console.WriteLine($"Temperatūros vidurkis:{vidurkis}");

        }
    }







}

