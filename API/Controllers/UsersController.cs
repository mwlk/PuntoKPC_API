using Interface.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAllAsync();

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Usuario model)
        {
            if (!ModelState.IsValid) return BadRequest();

            try
            {
                await _service.AddAsync(model);

                return Ok(model);
            }
            catch (Exception e)
            {
                return Problem("user add problem: ", e.Message);
            }
        }
    }
}
