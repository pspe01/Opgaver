using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Opg12Interface
{
    class Ubåd: IDbFunktioner
    {
        
        private static Logger log = LogManager.GetCurrentClassLogger();

        
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            log.Trace("Enter");
            log.Debug("Gemmer Ubåd");

            Console.WriteLine("Gemmer Ubåd");

            log.Trace("Exit");
        }
    }
}
