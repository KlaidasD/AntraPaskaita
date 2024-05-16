using System;
using System.Runtime.Serialization;

namespace AntraPaskaita

/*  5. Užduotis: Sukurkite programą, kuri naudoja while ciklą, norint suskaičiuoti ir išvesti įvesto skaičiaus skaitmenų sumą. 
Programa turi paprašyti vartotojo įvesti skaičių ir tada apskaičiuoti bei išvesti skaitmenų sumą. 
Pvz., jei vartotojas įveda 123, programa turėtų išvesti 6 (1+2+3).   */

{
    public class Program

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Įveskite skaičių, suskaičiuosime skaitmenų sumą:");
        int skaicius = int.Parse(Console.ReadLine());
        Console.WriteLine($"Jūsų skaičius: {skaicius}");

        int suma = 0;
        int paskutinis;

        while (skaicius > 0)
        {
            paskutinis = skaicius % 10;
            suma += paskutinis;
            skaicius /= 10;
        }

        Console.WriteLine($"Skaitmenų suma:{suma}");

    }
}







        }
    
