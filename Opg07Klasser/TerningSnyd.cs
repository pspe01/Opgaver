using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg07Klasser
{
    class TerningSnyd
    {
        private static Random rnd = new Random();
            public int værdi;
            private bool snyd;
        public TerningSnyd()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public TerningSnyd(bool Snyd)
        {
            this.værdi = 1;
            this.snyd = Snyd;
        }

        public void Skriv()
        {
            Console.WriteLine(this.værdi);
        }

        public void Ryst()
        {
            if (this.snyd)
            {
                Console.WriteLine(this.værdi=6);
            }
            else
            {
                Console.WriteLine(this.værdi = rnd.Next(1,7));
            }
        }
    }
}
