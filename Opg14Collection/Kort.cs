using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14Collection
{
    class Kort
    {
        public String Kulør { get; set; }
        public int Værdi { get; set; }

        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }
}
