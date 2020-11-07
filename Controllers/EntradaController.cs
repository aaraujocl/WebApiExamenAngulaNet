using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiExamenAngulaNet.Entity;
using WebApiExamenAngulaNet.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiExamenAngulaNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private readonly IEntradaService EntradaService;

        public EntradaController(IEntradaService EntradaServiceIn)
        {
            this.EntradaService = EntradaServiceIn;
        }

        // GET: api/<AlumnosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entrada>>> ObtenerEntradas()
        {
            object result;
            try
            {
                var res = await EntradaService.GetAllEntrada();
                result = new { Code = 100, Message = "Success", Result = res };
            }
            catch (Exception ex)
            {
                result = new { Code = -100, ex.Message };
            }

            return Ok(result);
        }

        // GET api/<AlumnosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AlumnosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlumnosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlumnosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
