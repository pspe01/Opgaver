using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg04String
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Palle";
            string efternavn = "Pedersen";
            string samletNavn;
            string navnStort;
            string navnLille;
            string navndel;


            samletNavn = fornavn + " " + efternavn;
            navnStort = samletNavn.ToUpper();
            navnLille = samletNavn.ToLower();
            navndel = samletNavn.Substring(6, 3);
            string[] navnsplit = samletNavn.Split(' ');

            Console.WriteLine(samletNavn);
            Console.WriteLine(navnStort);
            Console.WriteLine(navnLille);
            Console.WriteLine(navndel);
            

            foreach (var item in navnsplit)
            {
                Console.WriteLine(item);
            }

        }

    }
}
