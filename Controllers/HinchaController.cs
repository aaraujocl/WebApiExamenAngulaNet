using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiExamenAngulaNet.Entity;
using WebApiExamenAngulaNet.Service;

namespace WebApiExamenAngulaNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HinchaController : Controller
    {
        private readonly IHinchaService HinchaService;

        public HinchaController(IHinchaService HinchaServiceIn)
        {
            this.HinchaService = HinchaServiceIn;
        }

        [HttpPost]
        public async Task<ActionResult<Hincha>> GuardarHincha([FromBody] Hincha hincha)
        {
            object result;
            try
            {
                var res = await HinchaService.CreateHincha(hincha);
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
