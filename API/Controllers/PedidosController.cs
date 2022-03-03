using Interface.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;
using Persistence.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService _service;
        private readonly IDetallePedidoService _detalle;
        private readonly IFacturaService _factura;
        private readonly EcommerceContext _context;

        public PedidosController(IPedidoService service, IDetallePedidoService detalle,
                                 IFacturaService factura, EcommerceContext context)
        {
            _service = service;
            _detalle = detalle;
            _factura = factura;
            _context = context;
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
        public async Task<IActionResult> InsertOrder(OrderViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest();

            try
            {
               using(var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        var orderVM = new PedidoViewModel()
                        {
                            ClienteId = model.pedido.ClienteId,
                            Estado = model.pedido.Estado,
                            FechaPedido = model.pedido.FechaPedido,
                            NumeroPedido = model.pedido.NumeroPedido,
                            VendedorId = model.pedido.VendedorId
                        };

                        var order = await _service.InsertPedido(orderVM);

                        if (order == null) throw new Exception();

                        foreach (var detail in model.detalles)
                        {
                            var detalle = new DetallePedido()
                            {
                                PedidoId = order.Id,
                                Cantidad = detail.Cantidad,
                                PrecioVenta = detail.PrecioVenta,
                                ProductoId = detail.ProductoId
                            };

                            var detailInsert = await _detalle.AddAsync(detalle);

                            if (detailInsert == null) throw new Exception();
                        }

                        var factura = new Factura()
                        {
                            Monto = model.detalles.Sum(d => d.Cantidad * d.PrecioVenta),
                            PedidoId = order.Id
                        };

                        await _factura.AddAsync(factura);

                        await transaction.CommitAsync();

                        return Ok(order);
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return Problem("rollback");
                    }
                }
            }
            catch (Exception e)
            {
                return Problem("no insert " + e.Message);
            }
        }
    }
}
