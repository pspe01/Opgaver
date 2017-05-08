using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg07Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Terning t1 = new Terning();
            // Console.WriteLine("Random værdi fra default con "+t1.Værdi);

            // Terning t2 = new Terning(6);
            //Console.WriteLine("Værdi fra custom con " + t2.Værdi);

            // t2 = t1;
            // Console.WriteLine("t2 = t1");
            // Console.WriteLine(t1.Værdi);
            // Console.WriteLine(t2.Værdi);

            // t1.Værdi = 5;
            // Console.WriteLine("t1.værdi = 5");
            // Console.WriteLine(t1.Værdi);
            // Console.WriteLine(t2.Værdi);

            // t2.Værdi = 3;
            // Console.WriteLine("t2.værdi = 3");
            // Console.WriteLine(t1.Værdi);
            // Console.WriteLine(t2.Værdi);

            TerningSnyd t1 = new TerningSnyd();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            Console.WriteLine("");
            Console.WriteLine("");
            TerningSnyd t2 = new TerningSnyd(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

        }
    }
}
