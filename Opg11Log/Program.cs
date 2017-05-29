using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg11Log
{
    class Program
    {

        private static Logger log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            log.Trace("Enter");
            test1(5, 5);
            test2();
            log.Trace("Exit");
        }

        static void test1(int i, int x)
        {
            log.Trace("Enter {0} {1}", i,x );
            log.Debug("Enter i = {0} x = {1}", i, x);

            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(3000);
            log.Trace("Exit");
        }

        static void test2()
        {
            log.Trace("Enter");
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            log.Trace("Exit");
        }
    }
}


