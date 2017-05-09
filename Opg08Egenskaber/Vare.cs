using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg08Egenskaber
{
    public class Vare
    {

        public Vare()
        {

        }

        public Vare(string navn, int pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }

        private string navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("------Navn hentes i klasse------------");
                return navn;
            }
            set
            {
                Console.WriteLine("------Navn tildeles værdi i klassen------------");
                navn = value;
            }
        }

        private Double pris;

        public Double Pris
        {
            get
            {
                Console.WriteLine("------Pris hentes i klasse--------------");
                return pris;
            }
            set
            {
                Console.WriteLine("------Pris tildeles værdi i klassen------------");
                pris = value;
            }
        }


        public double PrisMedMoms()
        {
            Console.WriteLine("------Pris med moms fra metode------------");
            return this.pris = this.pris * 1.25;
        }


    }
}
