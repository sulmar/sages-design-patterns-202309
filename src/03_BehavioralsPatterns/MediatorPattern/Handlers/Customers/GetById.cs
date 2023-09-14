using MediatorPattern.Requests;
using MediatR;
using MediatorPattern.Models;
using System.Threading.Tasks;
using System.Threading;
using MediatorPattern.IServices;

namespace MediatorPattern.Handlers.Customers
{
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerById, Customer>
    {
        private readonly ICustomerRepository customerRepository;

        public GetCustomerByIdHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Task<Customer> Handle(GetCustomerById request, CancellationToken cancellationToken)
        {
            var customer = customerRepository.Get(request.Id);

            return Task.FromResult(customer);
        }
    }
}
