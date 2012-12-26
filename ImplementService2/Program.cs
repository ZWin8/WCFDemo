using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.ServiceModel;
using ServiceAndHost;

namespace ImplementService2
{
    /// <summary>
    /// 1. Endpoint address is the implementation class address
    /// 2. Append "mex" to endpoint address to get HttpGetUrl, which has nothing to do if not consuming through browser?
    /// 3. It seems HttpGetEnabled and HttpGetUrl has nothing to do with BasicHttpBinding().
    /// 4. Contract works with interface. Servicehost works with implementation!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri(@"http://localhost:8733/Design_Time_Addresses/ServiceAndHost/QueryService/");
            
            // Define Service Metadata Behaviro
            var behavior = new ServiceMetadataBehavior()
                {
                    HttpGetEnabled = true,
                    HttpGetUrl = new Uri(uri.OriginalString + "mex")
                };

            // Define Endpoint
            var contract = ContractDescription.GetContract(typeof (ServiceAndHost.IQueryService));
            var endpoint = new ServiceEndpoint( contract,
                                                new BasicHttpBinding(),
                                                new EndpointAddress(uri));

            // Define Host
            var sv = new ServiceHost(typeof(ServiceAndHost.QueryService), uri);
            sv.Description.Behaviors.Add(behavior);
            sv.Description.Endpoints.Add(endpoint);
            sv.Open();
            
            Console.ReadLine();
            sv.Close();

        }
    }
}
