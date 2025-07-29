
using Microsoft.AspNetCore.Mvc; // why use the mvc Libary?
using SaleProject.DTOs.Customer_DTOs;
using SaleProject.Services.Customer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleProject.Controllers
{
   

    [Route("Customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAllCustomers()
        {
            //var customers = await _customerService.GetAllCustomersAsync();
            //return Ok(customers);
            return NoContent(); // Placeholder for actual implementation
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> GetCustomerById(string id)
        {
            //var customer = await _customerService.GetCustomerByIdAsync(id);
            //if (customer == null)
            //{
            //    return NotFound();
            //}
         //   return Ok(customer);
         return NoContent(); // Placeholder for actual implementation
        }

        [HttpPost]
        public async Task<ActionResult<CustomerDto>> CreateCustomer(CreateCustomerDto createCustomerDto)
        {
            //var newCustomer = await _customerService.CreateCustomerAsync(createCustomerDto);
            return NoContent();
            //return CreatedAtAction(nameof(GetCustomerById), new { id = newCustomer.Id }, newCustomer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(string id, CreateCustomerDto createCustomerDto)
        {
            //var result = await _customerService.UpdateCustomerAsync(id, createCustomerDto);
            //if (!result)
            //{
            //    return NotFound();
            //}
            return NoContent();
        }

        [HttpDelete("deletCustomer/{id}")]
        public async Task<IActionResult> DeleteCustomer(string id)
        {
            //var result = await _customerService.DeleteCustomerAsync(id);
            //if (!result)
            //{
            //    return NotFound();
            //}
            return NoContent();
        }
    }
}
