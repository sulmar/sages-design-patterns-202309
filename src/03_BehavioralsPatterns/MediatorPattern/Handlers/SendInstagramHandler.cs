using MediatorPattern.Events;
using MediatorPattern.IServices;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPattern.Handlers
{
    public class SendInstagramHandler : INotificationHandler<AddCustomerEvent>
    {
        private readonly IMessageService messageService;

        public SendInstagramHandler(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public Task Handle(AddCustomerEvent notification, CancellationToken cancellationToken)
        {
            var customer = notification.Customer;

            messageService.Send(customer.Email, $"Welcome {customer.FullName} by Instagram");

            return Task.CompletedTask;
        }
    }
}
