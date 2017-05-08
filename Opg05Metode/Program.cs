using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg05Metode
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a = { 10000, 5000, 30000};
            int[] test = { 10,7,6,3,1,50,3};

            int res = Lægsammen(5, 2);
            Console.WriteLine(res);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            Udskriv();
            Udskriv("Dette er en test");

            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);

            double gns = Gennemsnit(a);
            Console.WriteLine(gns);

           
            var res4 = BeregnSorterArray(test);
           
        }

        static int Lægsammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return radius * radius * System.Math.PI;
        }

        static void Udskriv(string txt = "")
        {
            Console.WriteLine(txt);
        }

        static double BeregnMoms(double beløb, double momsPct=0.25)
        {
            return beløb * momsPct;
        }

        static double Gennemsnit(int[] måndesløn)
        {
            double samletløn = 0;
            for (var i = 0; i < måndesløn.Length; i++)
            {
                samletløn += måndesløn[i];
            }
            return samletløn/måndesløn.Length;
        }

        static LønBeregning BeregnSorterArray(int [] løntal)
        {

            LønBeregning l;
            l.sum = 0;

            for (var i = 0; i < løntal.Length; i++)
            {
                l.sum += løntal[i];
            }
            //foreach (var item in løntal)
            //{
            //    l.sum += løntal[item];
            //}
            l.gennemsnit = l.sum / løntal.Length;
           
            Array.Sort(løntal);


            return l;
           
        }

        struct LønBeregning
        {
            public double sum;
            public double gennemsnit;

        }
    }

}
