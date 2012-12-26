using System.Runtime.Serialization;
using System.ServiceModel;

namespace RESTDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {

        [OperationContract]
        Customer GetDataUsingDataContract(string name, string age);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract(Namespace = "NatureDynasty",Name = "CustomerInfo")]
    public class Customer
    {
        
        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public int CustomerAge { get; set; }
    }
}
