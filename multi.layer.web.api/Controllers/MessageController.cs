using System;
using System.Collections.Generic;
using CSA.Technology.Core;
using Microsoft.AspNetCore.Mvc;

namespace CSA.Technology.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly Core.IMessageService _service;

        public MessageController(Core.IMessageService service)
        {
            _service = service;
        }
       

        // GET api/values/5
        [HttpGet] 
        public ActionResult<string> Get()
        {
            try
            {
                var result = _service.GetMessage();
                return  Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }           
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
