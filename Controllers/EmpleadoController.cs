using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeGestionDeCondominio.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaDeGestionDeCondominio.Controllers
{

    [Route("api/[controller]")]

    public class EmpleadoController : Controller
    {

        private static List<Empleado> empleados = new List<Empleado>()
        {
                new Empleado{
                    Id=1,
                    Nombre="Carlos",
                    ApellidoPaterno="Vargas",IdParqueo=1,
                    Email="vargass@gmail.com"
                }
        };
        [HttpGet]
        public async Task<ActionResult<List<Empleado>>> GetAllEmployees()
        {
            return Ok(empleados);
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Empleado>> GetSingleEmployee(int id)
        {
            var employee = empleados.Find(x => x.Id == id);
            if(employee is null)
            {
                return NotFound("Lo sentimos este Empleado no se encuentra");
            }
            return Ok(employee);
        }
    }
}

