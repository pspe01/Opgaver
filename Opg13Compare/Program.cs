using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg13Compare
{
    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            log.Trace("Enter");
            Hund[] hunde = new Hund[2];

            hunde[0] = new Hund() { Alder = 9, Navn = "Mester" };
            hunde[1] = new Hund() { Alder = 1, Navn = "Odin" };

            Array.Sort(hunde);

            foreach (var item in hunde)
            {
                log.Debug(item.Alder);
                Console.WriteLine(item.Navn);
            }

            log.Trace("Exit");
        }
    }
}
