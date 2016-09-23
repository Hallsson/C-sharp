using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_satser
{
    class Program
    {
        static void Main(string[] args)
        {

            //Övning 1
            /*

            Console.WriteLine("Mata in ditt mönsterdjup i mm :");
            string inmatat = Console.ReadLine();
            double tal = double.Parse(inmatat);

            if (tal < 1.6)
            {
                Console.WriteLine("Olagligt däck... Du har " + (1.6 - tal) + " kvar till ett lagligt däck");
            }
            else 
            {
                Console.WriteLine("Lagligt däck");
            }

            */

            //Övning 2
            /*
            Console.WriteLine("Mata in din ålder: ");
            string inmatat = Console.ReadLine();
            int age = int.Parse(inmatat);

            if (age <= 12)
            {
                Console.WriteLine("Färg: Vit");
            }
            else if (age >= 13 && age <= 18)
            {
                Console.WriteLine("Färg Grön");
            }
            else if (age >= 19 && age <= 25)
            {
                Console.WriteLine("Färg: Röd");
            }
            else if (age >= 26 && age <= 99)
            {
                Console.WriteLine("Färg: Blå");
            }
            else
            {
                Console.WriteLine("ORIMLIGT ");
            }
             
            */

            //Övning 3

            /*

            Console.WriteLine("Mata in tal 1: ");
            String inmatat1 = Console.ReadLine();
            int tal1 = int.Parse(inmatat1);
            Console.WriteLine("Mata in tal 2:  ");
            String inmatat2 = Console.ReadLine();
            int tal2 = int.Parse(inmatat2);


            if (tal1 > tal2 )
            {
                Console.WriteLine("Tal 1 var större");
            }
            else if (tal2 > tal1 )
            {
                Console.WriteLine("Tal 2 var större");
            }
            else if (tal1 == tal2)
            {
                Console.WriteLine("De är lika");
            }
            */

            //Övning 4

            Console.WriteLine("Mata in ett tal: ");
            string inmatat = Console.ReadLine();
            int tal1 = int.Parse(inmatat);
             
            if (tal1 % 7 == 0)
            {
                Console.WriteLine("Talet är delbart med 7");
            }
            else
            {
                Console.WriteLine("Talet är inte delbart med 7.");
            }









            Console.WriteLine("Valfri knapp nedtryckt:");
            Console.ReadKey();

        }
    }
}
