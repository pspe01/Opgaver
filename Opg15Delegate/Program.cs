using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15Delegate
{
    class Program
    {

        public delegate int MyDelegateBeregn(int a,int b);

        static void Main(string[] args)
        {
            int res;

            res = Beregner(5, 5, Plus);
            Console.WriteLine(res);
            Console.WriteLine("");

            res = Beregner(10,5, Minus);
            Console.WriteLine(res);
            Console.WriteLine("");

            res = Beregner(10, 5, Divider);
            Console.WriteLine(res);
            Console.WriteLine("");

            res = Beregner(10000, 20, Potens);
            Console.WriteLine(res);
            Console.WriteLine("");


        }

        public static int Beregner(int a, int b, MyDelegateBeregn r)
        {
            return r(a, b);
        }

        public static int Plus(int a, int b)

        {
            return a + b;
        }

        public static int Minus(int a, int b)

        {
            return a - b;
        }

        public static int Divider(int a, int b)

        {
            return a / b;
        }

        public static int Gange(int a, int b)

        {
            return a * b;
        }

        public static int Potens(int a, int b)

        {
            double aa = Convert.ToDouble(a);
            double bb = Convert.ToDouble(b);


            try
            {
                return Convert.ToInt32(Math.Pow(aa, bb));
            }
            catch (Exception ex)
            {

                ApplicationException ex1 = new ApplicationException("Der er sket en fejl: Første int " + aa + " anden int: " + bb, ex);
                throw ex1;
            }
            
        }
    }
}
