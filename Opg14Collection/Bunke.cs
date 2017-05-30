using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14Collection
{
    class Bunke
    {
        private Stack<Kort> bnk1 = new Stack<Kort>();


        public void TilføjKort(Kort k)
            {
                bnk1.Push(k);
            }

        public void Vis()
        {
            foreach (var item in bnk1)
            {
                Console.WriteLine(item);
            }
        }

        public Kort fjernKort()
        {
            return bnk1.Pop();
            
        }

    }
}
