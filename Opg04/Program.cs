using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int x = 1; x < 11; x++)
                {
                    
                    
                    if ((i * x) > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(x * i);
                    Console.Write("\t");
                }
                Console.Write("\n");

 
            }

            for (int i = 1; i < 11; i++)
            {
                for (int x = 1; x < 11; x++)
                {
                    string tal = (i * x).ToString();

                    if ((i*x)>50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(tal.PadLeft(4));

                }
                Console.Write("\n");
            }

        }
    }
}
