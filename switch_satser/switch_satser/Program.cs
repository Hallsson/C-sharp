using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            int tal = int.Parse(Console.ReadLine());

            switch(tal)
            {
                case 1:
                    Console.WriteLine("ett");
                    break;
                case 2:
                    Console.WriteLine("två");
                    break;
                case 3:
                    Console.WriteLine("tre");
                    break;
                case 4:
                    Console.WriteLine("fyra");
                    break;
                default:
                    Console.WriteLine("FEL");
                    break;
            }
            */

            //Övning 2

            /*
            char tal = char.Parse(Console.ReadLine());

            switch (tal)
            {
                case 'N':
                    Console.WriteLine("You walk north");
                    break;
                case 'S':
                    Console.WriteLine("You walk south");
                    break;
                case 'W':
                    Console.WriteLine("You walk west");
                    break;
                case 'E':
                    Console.WriteLine("You walk east");
                    break;

                case 'n':
                    Console.WriteLine("You walk north");
                    break;
                case 's':
                    Console.WriteLine("You walk south");
                    break;
                case 'w':
                    Console.WriteLine("You walk west");
                    break;
                case 'e':
                    Console.WriteLine("You walk east");
                    break;
                default:
                    Console.WriteLine("You walk inwards");
                    break;
            }
            */

            //Övning 3

            Console.WriteLine("Skriv in det första talet");
            double tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in det andra talet");
            double tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Välj metod som du vill andvända");
            Console.WriteLine("");
            char metod = char.Parse(Console.ReadLine());
            switch (metod) 
            {
                case '+':
                    Console.WriteLine("Det blir " + ((tal1 + tal2) * 1.0));
                    break;
                case '-':
                    Console.WriteLine("Det blir " + ((tal1 - tal2) * 1.0));
                    break;
                case '/':
                    Console.WriteLine("Det blir " + ((tal1 / tal2) * 1.0));
                    break;
                case '*':
                    Console.WriteLine("Det blir " + ((tal1 * tal2) * 1.0));
                    break;
                default:
                    Console.WriteLine("Fel");
                    break;
            }







                    Console.WriteLine("Tryck ned valfri tangent");
            Console.ReadKey();
            

        }
    }
}
