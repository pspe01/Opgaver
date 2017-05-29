using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg13Compare
{
    class Hund:IComparable
    {

        public String   Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund myDog = obj as Hund;

            if (myDog.Alder>this.Alder)
            {
                return -1;
            }

            if (myDog.Alder<this.Alder)
            {
                return 1;
            }
            return 0;

        }
    }
}
