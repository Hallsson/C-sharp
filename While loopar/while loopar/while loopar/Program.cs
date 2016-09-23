using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1 
            /*
            var x = 1;
            while (x <=100)
            {
                Console.WriteLine(x);
                x++;
            }
            */
            //Övning 2
            /*
            Console.WriteLine("Skriv in det lösenord");
            var kod = Console.ReadLine();

            while (kod != "password")
            {
                Console.WriteLine("Skriv in rätt lösenord");
                kod = Console.ReadLine();

            }
            Console.WriteLine("RÄtt");
            */

            //Extra uppgifter
            //Övning 1 
            /*
            var i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();
            */

            //Övning 2 
            /*
            var i = 10;
            while ( i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.ReadLine();
            */
            //Övning 3
            /*
            var x = 0;
            while (x == x)
            {
                Console.WriteLine(x);
                x++;
            }
            */

            //Övning 4

            Console.WriteLine("Gissa talet: ");
            var x = int.Parse(Console.ReadLine());
            var tal = 42;
            while (x != 42)
            {
                Console.WriteLine("Gissa igen");
                x = int.Parse(Console.ReadLine());  
            }
            Console.WriteLine("Rätt!");
            Console.ReadKey();
        }
        
    }
}
