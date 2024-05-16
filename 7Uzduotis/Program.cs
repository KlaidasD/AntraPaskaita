using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace AntraPaskaita

/*  7. Maksimalios ir minimalios reikšmės radimas
Sukurkite programą, kuri paprašo vartotojo įvesti skaičių seriją į masyvą.
Naudokite for ciklą, kad rastumėte didžiausią ir mažiausią skaičius masyve. 
Panaudokite if sąlyginius teiginius, kad nustatytumėte, kuris skaičius yra didžiausias, o kuris - mažiausias, ir išveskite juos į ekraną.   */

{
    public class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičius, atspausdinsime didžiausią ir mažiausią .");
            double[] temp = new double[3];
            double suma = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1} Diena:");
                temp[i] = int.Parse(Console.ReadLine());
                suma += temp[i];

            }

            double vidurkis = suma / 3;


            Console.WriteLine($"Temperatūros vidurkis:{vidurkis}");

        }
    }







}

