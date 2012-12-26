using System;
using System.ServiceModel;

namespace ImplementWCFService
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var sv = new ServiceHost(typeof (WcfServiceLibrary1.OrderService)))
            {
                sv.Open();
                Console.ReadLine();
                sv.Close();
            }
        }
    }
}