using Microsoft.AspNetCore.Mvc;
using ProyectoFinal1.Models;
using ProyectoFinal1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoFinal1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET: api/<ViajesController>
        [HttpGet]
        public ActionResult<IEnumerable<tbl_clientes>> Get()
        {
            var clienteService = new ViajesServices();
            {
                var cliente = clienteService.GetClients();
                if (cliente != null)
                {
                    return Ok(cliente);
                }
                return NotFound("Mensaje: There is not clients");
            }
        }


        // GET api/<ViajesController>/5
        [HttpGet("{id}")]
        public ActionResult<tbl_clientes> Get(int id)
        {
            var clienteService = new ViajesServices();
            {
                var cliente = clienteService.GetClientById(id);
                if (cliente != null)
                {
                    return Ok(cliente);
                }
                return NotFound("Mensaje: There is not client with id:" + id);
            }
        }

        // POST api/<ViajesController>
        [HttpPost]
        public void Post([FromBody] tbl_clientes cliente)
        {
            var clienteService = new ViajesServices();
            {
                clienteService.AddClient(cliente);

            }
        }
    }
}
