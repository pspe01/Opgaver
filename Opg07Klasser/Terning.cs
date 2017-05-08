using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg07Klasser
{
    class Terning
    {
        public int Værdi;

        public Terning()
        {
            this.Værdi = new Random().Next(1, 7);
        }

        public Terning(int tal)
        {
            this.Værdi = tal;
        }
    }
}
