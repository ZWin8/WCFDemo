using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        OrderItem GetOrderById(int id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class OrderItem
    {
        [DataMember] public int Id;
        [DataMember] public string Name;
    }
}