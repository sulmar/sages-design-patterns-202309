using MediatorPattern.Requests;
using MediatR;
using System.Collections.Generic;
using MediatorPattern.Models;
using System.Threading.Tasks;
using System.Threading;
using MediatorPattern.IServices;

namespace MediatorPattern.Handlers.Customers
{
    public class GetAll : IRequestHandler<GetCustomers, ICollection<Customer>>
    {
        private readonly ICustomerRepository customerRepository;

        public GetAll(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Task<ICollection<Customer>> Handle(GetCustomers request, CancellationToken cancellationToken)
        {
            var customers = customerRepository.Get();

            return Task.FromResult(customers);
        }
    }
}
