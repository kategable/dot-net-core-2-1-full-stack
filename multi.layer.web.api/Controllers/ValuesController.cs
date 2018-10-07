using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using multy.layer.services;
using Microsoft.AspNetCore.Mvc;

namespace multi.layer.web.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValuesService _service;

        public ValuesController(IValuesService service)
        {
            _service = service;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                var result = _service.GetById(id);
                return  result;
            }
            catch (Exception e)
            {
                return NotFound(id);
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
