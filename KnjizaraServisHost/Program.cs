using KnjizaraServisHost.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KnjizaraServisHost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost sh = new ServiceHost(typeof(KnjizaraServis));
            sh.Open();
            Console.WriteLine("Service started...");
            Console.WriteLine("Press <ENTER> to terminate");
            Console.ReadLine();
            sh.Close();
        }
    }
}
