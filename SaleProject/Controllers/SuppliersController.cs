
using Microsoft.AspNetCore.Mvc;
using SaleProject.DTOs.Supplier_DTOs;
using SaleProject.DTOs.SupplierDtos;
using SaleProject.Services.Supplier;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleProject.Controllers
{


    [Route("Suppliers")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet("GetAllSuppliers")]
        public async Task<ActionResult<IEnumerable<SupplierDto>>> GetAllSuppliers()
        {
            //return Ok(await _supplierService.GetAllSuppliersAsync());
            return NoContent();
        }

        [HttpGet("GetSupplier/{id}")]
        public async Task<ActionResult<SupplierDto>> GetSupplierById(string  id)
        {
            //var supplier = await _supplierService.GetSupplierByIdAsync(id);
            //if (supplier == null) return NotFound();
            //return Ok(supplier);
            return NoContent();
        }

        [HttpPost("AddSupplier")]
        public async Task<ActionResult<SupplierDto>> CreateSupplier(CreateSupplierDto createSupplierDto)
        {
            //var newSupplier = await _supplierService.CreateSupplierAsync(createSupplierDto);
            //return CreatedAtAction(nameof(GetSupplierById), new { id = newSupplier.Id }, newSupplier);
            return NoContent(); // Placeholder for actual implementation
        }

        [HttpPut("UpdateSupplier/{id}")]
        public async Task<IActionResult> UpdateSupplier(string id, CreateSupplierDto createSupplierDto)
        {
            //var result = await _supplierService.UpdateSupplierAsync(id, createSupplierDto);
            //if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("DeleteSupplier{id}")]
        public async Task<IActionResult> DeleteSupplier(string id)
        {
            var result = await _supplierService.DeleteSupplierAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
