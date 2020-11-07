using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiExamenAngulaNet.Entity;
using WebApiExamenAngulaNet.Service;

namespace WebApiExamenAngulaNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadioController : Controller
    {
        private readonly IEstadoService EstadioService;

        public EstadioController(IEstadoService EstadioServiceIn)
        {
            this.EstadioService = EstadioServiceIn;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estadio>>> ObtenerEstadios()
        {
            object result;
            try
            {
                var res = await EstadioService.GetAllEstadios();
                result = new { Code = 100, Message = "Success", Result = res };
            }
            catch (Exception ex)
            {
                result = new { Code = -100, ex.Message };
            }

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<Estadio>> ActualizarEstadio([FromBody] Estadio estadio)
        {
            object result;
            try
            {
                var res = await EstadioService.UpdateEstadio(estadio);
                result = new { Code = 100, Message = "Success", Result = res };
            }
            catch (Exception ex)
            {
                result = new { Code = -100, ex.Message };
            }

            return Ok(result);

        }

    }
}
