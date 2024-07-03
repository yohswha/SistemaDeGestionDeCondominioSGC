using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeGestionDeCondominio.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaDeGestionDeCondominio.Controllers
{
    public class ClienteController : Controller
    {
        [Route("api/[controller]")]

        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> GetAllClientes()
        {
            var cliente = new List<Cliente>
            {
                new Cliente
                {
                    Id=1,
                    Nombre="Yohswha",
                    ApellidoPaterno="Bello",
                    ApellidoMaterno="", IdParqueo=1
                }
            };
            return Ok(cliente);
        }
    }
}

