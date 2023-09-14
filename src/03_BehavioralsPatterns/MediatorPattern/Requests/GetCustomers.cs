using MediatR;
using System.Collections.Generic;
using MediatorPattern.Models;

namespace MediatorPattern.Requests
{
    public class GetCustomers : IRequest<ICollection<Customer>>
    {

    }
}
