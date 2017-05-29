using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Opg12Interface
{
    class Hund: IDbFunktioner
    {
        
        private static Logger log = LogManager.GetCurrentClassLogger();

        public string Navn { get; set; }

        public void Gem()
        {
            log.Trace("Enter");
            log.Debug("Gemmer hund");

            Console.WriteLine("Gemmer hund");

            log.Trace("Exit");
        }
        
    }
}
