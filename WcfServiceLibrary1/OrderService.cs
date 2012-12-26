
namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class OrderService : IOrderService
    {
        public OrderItem GetOrderById(int id)
        {
            return new OrderItem() {Id = id, Name = "Test"};
        }
    }
}
