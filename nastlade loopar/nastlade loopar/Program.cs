
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nastlade_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            for (int x = 0; x < 10; x++)
            {
                int z = 0;
                for (int y = 0;y < 5; y++)
                {
                    Console.Write("o#");
                    z++;
                    if (z == 5)
                    {
                        Console.WriteLine("");
                    }
                }
            }
            */
            /* Övning 2
            for (int x = 0; x < 11; x++)
            {
                if (x%2==0)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        Console.Write("o#");
                    }
                    Console.WriteLine("o");
                }
                else
                {
                    for (int z = 0; z < 5; z++)
                    {
                        Console.Write("#o");
                    }
                    Console.WriteLine("#");
                }
            }    
            */

            //Övning 3
           
            for (int x = 10; x > 0; x--)
            {
                string brödhög = new string('#', x);
                Console.WriteLine(brödhög);
            }
        
            Console.ReadKey();
        }
    }
}
