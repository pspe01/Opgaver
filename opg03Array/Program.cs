using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg03Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] månedsløn = new int[6];
            månedsløn[0] = 10000;
            månedsløn[1] = 20000;
            månedsløn[2] = 15000;
            månedsløn[3] = 20000;
            månedsløn[4] = 30000;
            månedsløn[5] = 15000;

            double samletLøn = 0;
            Double gennemsnit = 0;

            for (int i = 0; i < månedsløn.Length; i++)
            {
                
                samletLøn += månedsløn[i];
                Console.WriteLine(månedsløn[i]);
               
            }

            gennemsnit = samletLøn / månedsløn.Length;
            Console.WriteLine(samletLøn);
            Console.WriteLine("Gennemsnit er: "+gennemsnit);

            Array.Sort(månedsløn);

            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            

         

        }
    }
}
