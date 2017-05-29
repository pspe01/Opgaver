using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Opg12Interface
{
    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            log.Trace("Enter");


            IDbFunktioner[] i1 = new IDbFunktioner[5];

            i1[0] = new Hund();
            i1[1] = new Ubåd();
            i1[2] = new Hund();
            i1[3] = new Ubåd();
            i1[4] = new Hund();
            

            foreach (var item in i1)

            {
                item.Gem();
                log.Debug(item);
            }


            log.Trace("Exit");

        }
        
    }
}
