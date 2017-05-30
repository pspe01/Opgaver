using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg16Watch
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher watcher = new System.IO.FileSystemWatcher();

            watcher.Path = @"c:\temp";
            watcher.EnableRaisingEvents = true;
          //  watcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            watcher.Changed += Watcher_Changed;

            do
            {

            } while (true);
        }

        private static void Watcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Der er sket ændringer " + e.Name);
        }
    }
}
