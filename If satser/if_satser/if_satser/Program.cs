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
            Console.WriteLine("Mata in ditt mönsterdjup i mm :");
            string inmatat = Console.ReadLine();
            double tal = double.Parse(inmatat);
            
            if (tal < 1.6)
            {
                Console.WriteLine("Olagligt däck");
            }
            











            Console.WriteLine("Valfri knapp nedtryckt: ");
            Console.ReadKey();
            
        }
    }
}
