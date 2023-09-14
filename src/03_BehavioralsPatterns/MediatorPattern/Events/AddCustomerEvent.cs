using MediatorPattern.Models;
using MediatR;

namespace MediatorPattern.Events
{    
    public class AddCustomerEvent : INotification    // marker interface
    {
        public Customer Customer { get; private set; }
        public AddCustomerEvent(Customer customer)
        {
            Customer = customer;
        }
    }
}
