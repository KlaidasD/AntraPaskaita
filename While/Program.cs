using System;
using System.Runtime.Serialization;

namespace AntraPaskaita

/*1. Užduotis: Skaičių sekos suma
Parašykite programą, kuri naudoja while ciklą, kad suskaičiuotų visų teigiamų skaičių, mažesnių nei nurodytas skaičius 𝑛
, suma. Programa turi paprašyti vartotojo įvesti skaičių 𝑛
 ir tada išvesti suskaičiuotą sumą.

2. Užduotis: Atvirkštinis skaičių išvedimas
Parašykite programą naudojant for ciklą, kuri paprašo vartotojo įvesti skaičių 𝑛
 ir tada išveda visus skaičius nuo 𝑛
iki 1 atvirkštine tvarka. Kiekvienas skaičius turi būti atskirtas nauja eilute.

3. Užduotis: Skaičių, kurie dalijasi iš 3, paieška
Sukurkite programą, kuri naudoja while ciklą norint rasti ir išvesti pirmus 10 skaičių nuo 1 iki 100, kurie dalijasi iš 3 be liekanos. Programa turi išvesti šiuos skaičius vieną po kito, kiekvieną naujoje eilutėje.*/
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sveiki! Įveskite skaičių: N");
             int n = int.Parse(Console.ReadLine());
             int suma = 0;
             int teig = 1;

            Console.WriteLine($"Jūs įvedėte skaičių: {n}");

            while(n > teig)
            {
                suma += teig;
                teig++;

            }

            Console.WriteLine($"Mažesnių skaičių, nei jūsų įvesto skaičiaus suma: {suma}");

            Console.WriteLine("Įveskite antrą skaičių:");
            int f = int.Parse(Console.ReadLine());
            int atvir = f--;
            Console.WriteLine($"Jūsų įvestas skaičius: {f}");
            for (f = f; f >= 1; f--)
            {
                Console.WriteLine($"\n{f}");
            }

            int x = 1;
            int eil = 0;
            while (x <= 100 && eil < 10)
            {
                if(x % 3 == 0) 
                {
                    eil++;
                    Console.WriteLine(x);
                }
                x++;
            }
            
        }
    }
}