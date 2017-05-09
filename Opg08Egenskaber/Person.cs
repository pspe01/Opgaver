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
        //private string fuldtNavn;

        //public string FuldtNavn
        //{
        //    get => this.Fornavn + " " + this.Efternavn;
        //    set { fuldtNavn = value; }
        //}

        private string fuldtnavn;

        public string FuldtNavn
        {
            get { return this.Fornavn+" "+this.Efternavn; }
            set { fuldtnavn = value; }
        }



        public string FuldtNavnMetode()
        {
            return this.Fornavn + " " + this.Efternavn;
        }
    }
}
