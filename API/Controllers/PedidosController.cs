using Interface.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService _service;
        private readonly IDetallePedidoService _detalle;

        public PedidosController(IPedidoService service, IDetallePedidoService detalle)
        {
            _service = service;
            _detalle = detalle;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            try
            {
                var data = await _service.GetAllAsync();

                if (data == null)
                {
                    //return NotFound();
                    throw new Exception();
                }
                else
                {
                    return Ok(data);
                }
            }
            catch (Exception e)
            {
                return Problem("fail ", e.Message);
            }
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            try
            {
                var data = await _service.GetByIdAsync(id);

                if (data == null) return NotFound();

                return Ok(data);
            }
            catch (Exception e)
            {

                return Problem("fail " + e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertOrder(Pedido model)
        {
            if (!ModelState.IsValid) return BadRequest();

            try
            {
                await _service.AddAsync(model);

                return Ok(model);
            }
            catch (Exception e)
            {
                return Problem("no insert " + e.Message);
            }
        }
    }
}
