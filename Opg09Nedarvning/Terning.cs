using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg09Nedarvning
{
    class Terning
    {
        private static System.Random rnd;
        private int værdi;

        static Terning()
        {
            rnd = new Random();
        }
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        public Terning()
        {
            this.Ryst();
        }
        public int Værdi
        {
            get { return værdi;}
            set
            {
                if (value < 1 || value > 6)
                {
                    Console.WriteLine("Værdien er "+ value +"Tallet skal være mellem 1 og 6. værdien sættes til 1");
                    værdi = 1;
                }
                else
                {
                    værdi = value;
                }
                
            }
        }

        public int Ryst() {

            return this.Værdi = rnd.Next(1, 7);
        }

    }
}
