using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Data = ReportCheckerWebApi.Features.Data;

namespace ReportCheckerWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly Data.Transform.Method transformMethod;
        private readonly Data.Store.Method storeMethod;

        public DataController(Data.Transform.Method transformMethod, Data.Store.Method storeMethod)
        {
            this.transformMethod = transformMethod;
            this.storeMethod = storeMethod;
        }

        [HttpPost("transform")]
        public IActionResult Tranform([FromBody] Data.Transform.RequestBody requestBody)
        {
            var result = transformMethod.Execute(requestBody.PureString, requestBody.Option);
            if (result is null)
            {
                return BadRequest();
            }
            var reponse = new Data.Transform.ReponseBody(result);
            return Ok(reponse);
        }
        [HttpPut("store")]
        public IActionResult Store([FromBody] Data.Store.RequestBody requestBody)
        {
            var result = storeMethod.Execute(requestBody.Items);
            return result ? NoContent() : BadRequest();
        }
    }
}
