using MediatR;
using MediatorPattern.Models;

namespace MediatorPattern.Requests
{
    public class GetCustomerById : IRequest<Customer>
    {
        public int Id { get; private set; }

        public GetCustomerById(int id)
        {
            Id = id;
        }
    }
}
