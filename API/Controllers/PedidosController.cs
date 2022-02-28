using Interface.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService _service;

        public PedidosController(IPedidoService service)
        {
            _service = service;
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
    }
}
