using Interface.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _service;

        public ProductosController(IProductoService service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _service.GetAllAsync();

                if (result == null) return NotFound();

                return Ok(result);
            }
            catch (Exception e)
            {

                return Problem("get all ", e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProducto(Producto model)
        {
            if (!ModelState.IsValid) return BadRequest();
            try
            {
                await _service.AddAsync(model);

                return Ok(model);
            }
            catch (Exception e)
            {
                return Problem("insert fail ", e.Message);
            }
        }
    }
}
