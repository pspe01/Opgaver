using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg09Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {

            LudoTerning l1 = new LudoTerning();

            l1.Værdi = l1.Ryst();
            Console.WriteLine(l1.Værdi);
            bool glous=l1.ErGlobus();
            Console.WriteLine(glous);
           
        }
    }
}
