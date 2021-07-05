using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using StringData = ReportCheckerWebApi.Features.StringData;

namespace ReportCheckerWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class StringDataController : ControllerBase
    {
        private readonly StringData.Transform.Method transformMethod;

        public StringDataController(StringData.Transform.Method transformMethod)
        {
            this.transformMethod = transformMethod;
        }

        [HttpPost("transform")]
        public IActionResult Tranform([FromBody] Features.StringData.Transform.RequestBody requestBody)
        {
            var result = transformMethod.Execute(requestBody.PureString, requestBody.Option);
            if (result is null)
            {
                return Ok(new Features.StringData.Transform.ReponseBody("fail"));
            }
            var reponse = new Features.StringData.Transform.ReponseBody("success");
            reponse.Data.Items = result;
            return Ok(reponse);
        }

    }
}
