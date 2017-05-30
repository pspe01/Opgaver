using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg13Compare
{
    class Hund_byName : IComparable
    {
        public int CompareTo(object obj, object obj1)
        {
            Hund myDog = obj as Hund;
            Hund myDog1 = obj1 as Hund;
            return string.Compare(myDog.Navn, myDog.Navn);
        }
    }
}
