using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg08Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v1 = new Vare("Telefon", 2000);

            Console.WriteLine(v1.Navn);
            Console.WriteLine(v1.Pris);

            Double pMoms = v1.PrisMedMoms();
            Console.WriteLine(pMoms);

            Person p1 = new Person("Palle", "Pedersen");


            Console.WriteLine(p1.FuldtNavn());

            Console.WriteLine(p1.Fornavn+" "+p1.Efternavn);

            p1.Efternavn = "Ha";
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Fornavn + " " + p1.Efternavn);

        }
    }
}
