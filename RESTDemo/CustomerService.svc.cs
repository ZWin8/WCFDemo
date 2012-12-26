using System;
using System.ServiceModel.Web;

namespace RESTDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICustomerService
    {
        [WebGet(UriTemplate = "MyName={name}?MyAge={age}", RequestFormat = WebMessageFormat.Xml)]
        public Customer GetDataUsingDataContract(string name, string age)
        {
            return new Customer() {CustomerName = name, CustomerAge = Convert.ToInt32(age)};
        }
    }
}