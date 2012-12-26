using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ConsumeService2
{
    [ServiceContract]
    public interface IQueryService
    {
        [OperationContract]
        string GetFeedback(string greetings);
    }

    /// <summary>
    /// Run the assembly .exe file in ImplementService2/Debug before F5!
    /// 1. EndpointAddress points to the implementation class address.
    /// 2. A channal factory creates a channel between the interfaces in the client and in the server.
    /// 3. The interface variable in the client side then works like an implementation class instance!!!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var address = new EndpointAddress(new Uri(@"http://localhost:8733/Design_Time_Addresses/ServiceAndHost/QueryService"));
            IQueryService proxy = ChannelFactory<IQueryService>.CreateChannel(new BasicHttpBinding(), address);
            Console.WriteLine(proxy.GetFeedback("Fuck"));
            Console.ReadLine();
        }
    }
}
