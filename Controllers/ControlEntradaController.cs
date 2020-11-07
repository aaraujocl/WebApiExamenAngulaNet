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
    public class ControlEntradaController : Controller
    {
        private readonly IControlService ControlService;

        public ControlEntradaController(IControlService ControlServiceIn)
        {
            this.ControlService = ControlServiceIn;
        }

        [HttpPost]
        public async Task<ActionResult<ControlEntrada>> GuardarEntrada([FromBody] ControlEntrada entrada)
        {
            object result;
            try
            {
                var res = await ControlService.CreateControlEntrada(entrada);
                result = new { Code = 100, Message = "Success", Result = res.IdHincha };
            }
            catch (Exception ex)
            {
                result = new { Code = -100, ex.Message };
            }

            return Ok(result);

        }

    }
}
