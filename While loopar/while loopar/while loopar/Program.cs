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
            /*
            Console.WriteLine("Gissa talet: ");
            var x = int.Parse(Console.ReadLine());
            var tal = 42;
            var z = 0;
            while (x != tal)
            {
                Console.WriteLine("Gissa igen");
                if (x < tal)
                {
                    Console.WriteLine("För lågt");
                }
                else if (x > tal)
                {
                    Console.WriteLine("för högt");
                }
                x = int.Parse(Console.ReadLine()); 
                z++;
            }
            Console.WriteLine("Rätt!");
            Console.WriteLine(z);
            */

            //Övning 5
            /*
            var fib = 0;
            var fib2= 1;

            while (fib <= 1346269)
            {
                fib += fib2;
                fib2 = fib - fib2;
                Console.WriteLine(fib2);
            }
            */

            //Övning 6
            Console.WriteLine("Ange saldo på ditt konto: ");
            var saldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ränta: ");
            var ränta = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange mål: ");
            var mål = int.Parse(Console.ReadLine());

            while ()
            {

            }

            Console.ReadKey();
        }
        
    }
}
