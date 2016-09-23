using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1

            /*
            for (int i = 1; i <=100; i++)
            {
                Console.WriteLine(i);
            }

    */
            //Övning 2

            /*
            for (int i = 20; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            */

            //Övning 3

            /*
            for (int i = 0; i <= 50; i=i+2)
            {
                Console.WriteLine(i);
            }
            */

            //Övning 1
            /*
            Console.WriteLine("Mata in start: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in stop: ");
            int stop = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in metod: ");
            int metod = int.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i = i + metod )
            {
                Console.WriteLine(i);
            }
            */
            //Övning 2

            /*
            Console.WriteLine("Mata in ditt heltal: ");
            int heltal = int.Parse(Console.ReadLine());
            int sum = 0; 


            for (int i = heltal; i > 0 ;  i--)
                
            {
                sum = sum + i;

            }
            Console.WriteLine("Summan av alla tal från 1 till " + heltal + " är: " + sum);
            */

            //Övning 4
            /*
            Console.WriteLine("Mata in ditt heltal: ");
            var heltal = int.Parse(Console.ReadLine());

            for (int i = 0; i <= heltal; i++)
            {

                if (i % 7 == 0 && i % 3 == 0)
                    Console.WriteLine(i + " Är delbart med 7 och 3");
            }
            */
            // Övning 5
            /* 
            Console.WriteLine("Mata in ett heltal: ");
                var heltal = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            
            for (int i = 0; i < heltal; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(b);
            }
            */
            //Övning 6
            /*
            Console.WriteLine("Ange ett tal");
            var heltal = double.Parse(Console.ReadLine());

            Console.WriteLine("Kubikroter ut är: " + Math.Pow((heltal*1.0), 0.33333333334) );
            */

            //Övning 7

            Console.WriteLine("Mata in ditt heltal: ");
            var heltal = int.Parse(Console.ReadLine());

            for (int i = 1; i < heltal; i++)
            {
                if (i % i == 0 && i % 1 == 0) {
                    break;
                }
                else {
                    Console.WriteLine("inte primtal");
                }

            }
                     Console.WriteLine("primtal");

















            Console.ReadKey();
        }
    }
}
