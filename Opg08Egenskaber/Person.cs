using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg08Egenskaber
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string fornavn, string efternavn)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length < 3)
                {
                    efternavn = "Efternavn for kort";
                }
                else
                {
                    efternavn = value;
                }
                
            }
        }

        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }
    }
}
