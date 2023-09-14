using MediatorPattern.Events;
using MediatorPattern.IServices;
using MediatorPattern.Models;
using MediatorPattern.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern.Controllers
{
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator mediator;

        public CustomersController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            mediator.Publish(new AddCustomerEvent(customer));            

            return Ok();
        }

        // GET https://localhost:5001/api/customers HTTP/1.1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            var customers = await mediator.Send(new GetCustomers());
            return Ok(customers);
        }

        // GET https://localhost:5001/api/customers/1 HTTP/1.1
        [HttpGet("{id}")]
        public async Task< ActionResult<Customer>> Get(int id)
        {
            var customer = await mediator.Send(new GetCustomerById(id));
            return Ok(customer);
        }

    }
}
