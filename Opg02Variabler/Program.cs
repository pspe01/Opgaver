using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg02Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int helTal = 10;
            helTal++;
            helTal--;

            helTal += 20;

            Console.WriteLine(helTal);
            //Console.ReadKey();

            double kommaTal = 12.5;
            Console.WriteLine(kommaTal);
            kommaTal++;
            Console.WriteLine(kommaTal);
            kommaTal--;
            Console.WriteLine(kommaTal);
            kommaTal *= 2;

            Console.WriteLine(kommaTal);
           // Console.ReadKey();

            //Enum
            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);
            //Console.ReadKey();

            //DateTime

            DateTime pspDatoTid = DateTime.Now;
            
            Console.WriteLine(pspDatoTid.ToString("D"));
            Console.WriteLine(pspDatoTid.ToString("O"));
            //Console.ReadKey();

            //Struct

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine(p.Navn);
            Console.ReadKey();

        }
    }

    enum FilTyper
    {
        csv,
        pdf,
        txt

    }


    struct Person
    {
        public int Id;
        public String Navn;

        
    }
}
