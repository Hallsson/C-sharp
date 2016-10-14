using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            Console.WriteLine("\u0056" + "\u00e4" + "\u0072" + "\u006d" + "\u0064" + "\u00f6" + "\x20" + "\u0067" + "\u0079" + "\u006d");
            */
            /* Övning 2
            Console.WriteLine("\"\u0048\u0065\u006a\" ");
            */
            /* Övning 3 a
            string hej = "HELLO WORLD";
            Console.WriteLine(hej); 
            */
            /* Övning 3 b
            string hek = "HELLO WORLD";
            string liten = hek.ToLower();
            Console.WriteLine(liten);
            */
            /* Övning 4
            var hej = "hello world";
            var antal = hej.Length;
            Console.WriteLine(antal);
            */
            /*  Övning 5 
            Console.WriteLine("SKRIV");
            string bak = Console.ReadLine();
            char[] baklänges = bak.ToCharArray();
            Array.Reverse(baklänges);
            Console.WriteLine(baklänges);
            */

            String texten = "{0} elefant{1} balanserade på en liten liten "
                            + "spindeltråååd.\n" 
                            + "Det tyckte {2} var så intressant,\n"
                            + "så {2} gick och hämtade en annan elefant.\n";
            string ändrad = string.Format(texten, "en", "", "han");
            Console.WriteLine(ändrad);

            for (int i = 1; i < 10; i++)
            {
                ändrad = string.Format(texten, i, "er", "de");
                Console.WriteLine(ändrad);
            }
            Console.ReadKey();
        }
    }
}
