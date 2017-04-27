using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg01HelloWorld1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Velkommen " + navn.ToUpper());
            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
