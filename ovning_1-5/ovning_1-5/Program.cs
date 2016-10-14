using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Övning 1
namespace ovning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Mata in ett heltal 1");
            String tal1;
            int nummer1;
            tal1 = Console.ReadLine();
            nummer1 = int.Parse(tal1);

            Console.WriteLine("Mata in ett heltal 2");
            String tal2;
            int nummer2;
            tal2 = Console.ReadLine();
            nummer2 = int.Parse(tal2);

            Console.WriteLine("summa = " + (nummer1 + nummer2));
            Console.WriteLine("Produkt = " + (nummer1 * nummer2));
            Console.WriteLine("Divisionen = " + (nummer1 / nummer2));
            */
            /*
            //Övning 2

            Console.WriteLine("Mata in ditt förnamn");
            string förnamn = Console.ReadLine();

            Console.WriteLine("Mata in ditt Efternamn");
            string efternamn = Console.ReadLine();

            Console.WriteLine("Hej " + ( förnamn + efternamn));
            */

            //Övning 3
            /*
            Console.WriteLine("Mata in antal grader");
            string cels = Console.ReadLine();
            double far = double.Parse(cels);
            Console.WriteLine("Det blir " + ( far * 1.8 + 32) + "grader farenheit.");
            */

            //Övning 5

            Console.WriteLine("cirkelns Radie: ");
            string radie = Console.ReadLine();
            double radiesiffra = double.Parse(radie);
            double pi = Math.PI;
            Console.WriteLine("Area: " + radiesiffra * radiesiffra * pi);
            Console.WriteLine("Omkrets: " + radiesiffra * 2 * pi);













            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}
