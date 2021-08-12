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
        private readonly Data.GetAllItemsAndDetails.Method getAllItemsAndDetailsMethod;
        private readonly Data.GetAllNameOfItems.Method getAllNameOfItemsMethod;
        private readonly Data.GetItemDetailByName.Method getItemDetailByNameMethod;

        public DataController(
            Data.Transform.Method transformMethod, 
            Data.Store.Method storeMethod, 
            Data.GetAllItemsAndDetails.Method getAllItemsAndDetailsMethod,
            Data.GetAllNameOfItems.Method getAllNameOfItemsMethod,
            Data.GetItemDetailByName.Method getItemDetailByNameMethod
        ) {
            this.transformMethod = transformMethod;
            this.storeMethod = storeMethod;
            this.getAllItemsAndDetailsMethod = getAllItemsAndDetailsMethod;
            this.getAllNameOfItemsMethod = getAllNameOfItemsMethod;
            this.getItemDetailByNameMethod = getItemDetailByNameMethod;
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
        [HttpGet("get-all-items-and-details")]
        public IActionResult GetAllItemsAndDetails()
        {
            var result = getAllItemsAndDetailsMethod.Execute();
            return Ok(result);
        }
        [HttpGet("get-all-name-of-items")]
        public IActionResult GetAllNameOfItems()
        {
            var result = getAllNameOfItemsMethod.Execute();
            return Ok(result);
        }
        [HttpPost("get-item-detail-by-name")]
        public IActionResult GetItemDetailByName([FromBody] Data.GetItemDetailByName.RequestBody requestBody)
        {
            var result = getItemDetailByNameMethod.Execute(requestBody.Name);
            return Ok(result);
        }
    }
}
