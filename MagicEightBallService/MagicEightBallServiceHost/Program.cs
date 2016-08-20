using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Console Based WCF Host *****");
            using (ServiceHost serviceHost=new ServiceHost(typeof(MagicEightBallService)))
            {
                serviceHost.Open();
                DisplayHostInfo(serviceHost);
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
            
        }

        static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("***** Host Info ******");
            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine($"Address:{se.Address}");
                Console.WriteLine($"Binding:{se.Binding.Name}");
                Console.WriteLine($"Contract:{se.Contract.Name}");
                Console.WriteLine();
            }
            Console.WriteLine("************************************");
        }
    }
}
