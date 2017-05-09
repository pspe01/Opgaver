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


            Console.WriteLine(p1.FuldtNavnMetode());

            Console.WriteLine(p1.Fornavn+" "+p1.Efternavn);

            p1.Efternavn = "Ha";
            Console.WriteLine(p1.FuldtNavnMetode());
            Console.WriteLine(p1.Fornavn + " " + p1.Efternavn);

            Instruktør i1 = new Instruktør() {Fornavn="Knud",Efternavn="Poulsen",NøgleId=23 };
           
            Console.WriteLine("Instruktør");
            Console.WriteLine(i1.Fornavn + " " + i1.Efternavn + " " + i1.NøgleId);

            Elev e1 = new Elev() { Fornavn="Hans", Efternavn="Hansen",Klasselokale="Lille klasse"};
            Console.WriteLine("Elev");
            Console.WriteLine(e1.Fornavn + " " + e1.Efternavn + " " + e1.Klasselokale);




        }
    }
}
