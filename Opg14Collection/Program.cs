using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Person> lst1 = new List<Person>();

            lst1.Add(new Person() { Id = 1, Navn = "Palle" });
            lst1.Add(new Person() { Id = 2, Navn = "Emilie" });
            lst1.Add(new Person() { Id = 3, Navn = "Emma" });

           
            foreach (var item in lst1)

            {
                Console.WriteLine(item.Navn);
            }
            Console.WriteLine("");
            lst1.Insert(2, new Person() { Id = 12, Navn = "Ea" });

            foreach (var item in lst1)

            {
                Console.WriteLine(item.Navn);
            }

            Console.WriteLine("");
            Dictionary<int,Person> lst2 = new Dictionary<int,Person>();

            lst2.Add(1, new Person() { Id = 1, Navn = "Palle" });
            lst2.Add(2, new Person() { Id = 12, Navn = "Emma" });
            lst2.Add(3, new Person() { Id = 14, Navn = "Emilie" });

            var p = lst2[3];

            Console.WriteLine(p.Navn);

            Console.WriteLine("--------------Kort--------------------");

            Bunke b = new Bunke();

            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "ruder", Værdi = 3 });

            b.Vis();

            var k = b.fjernKort();
            Console.WriteLine(k);

        }
    }
}
