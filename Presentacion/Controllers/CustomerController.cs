using ClaseTradicional;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {

        [HttpGet("Clase Tradicional")]
        public IActionResult GetCustomer()
        {
            var dto = new Customer
            {
                Id = 1,
                Name = "Ana Pérez",
                Email = "ana@example.com",
                CreatedAt = DateTime.Now
            };

            dto.Name = "Carlos Martínez"; // Se puede cambiar sin restricción

            return Ok(dto);
        }

        [HttpGet("DTO")]
        public IActionResult GetCustomerDTO()
        {
            var dto = new CustomerDTO(
            Id: 1,
            Name: "Ana Pérez",
            Email: "ana@example.com",
            CreatedAt: DateTime.Now
            );

            // No se modificar directamente:
            /*dto.Name = "Carlos Martínez";*/ // Error de compilación

            // Si se quiere cambiar algo, se debe crear una nueva instancia:
            var newDto = dto with { Name = "Carlos Martínez" };

            return Ok(newDto);
        }
    }
}
