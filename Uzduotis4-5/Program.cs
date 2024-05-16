using System;
using System.Runtime.Serialization;

namespace AntraPaskaita

/*  4. Užduotis:
Parašykite programą kuri prašo įvesti intervalą NUO/IKI ir jame atspausdina pirminius skaičius, skaičius kurie dalinasi iš 11 be liekanos

5. Užduotis: Sukurkite programą, kuri naudoja while ciklą, norint suskaičiuoti ir išvesti įvesto skaičiaus skaitmenų sumą. 
Programa turi paprašyti vartotojo įvesti skaičių ir tada apskaičiuoti bei išvesti skaitmenų sumą. 
Pvz., jei vartotojas įveda 123, programa turėtų išvesti 6 (1+2+3).   */
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių intervalą, atspausdinsim pirminius skaičius kurie dalinasi iš 11 be liekanos - NUO/IKI:\nNuo:");
            int nuo = int.Parse(Console.ReadLine());
            Console.WriteLine("Iki:");
            int iki = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pirminiai skaičiai tarp {nuo} ir {iki}, kurie dalijasi iš 11 be liekanos:");

            for (int skaicius = nuo; skaicius <= iki; skaicius++)
            {
                if (skaicius < 2)
                    continue;

                bool pirminis = true;
                for (int daliklis = 2; daliklis <= Math.Sqrt(skaicius); daliklis++)
                {
                    if (skaicius % daliklis == 0)
                    {
                        pirminis = false;
                        break;
                    }
                }
                if (pirminis && skaicius % 11 == 0)
                {
                    Console.WriteLine(skaicius);
                }
                else if(pirminis && skaicius != 0)
                {
                    Console.WriteLine("Jūsų intervale nėra pirminių skaičių kurie dalinasi iš 11 be liekanos.");
                }
            }








        }
    }
}