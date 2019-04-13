using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.RavenDbManager;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public readonly IRavenDbDataManager dataManager;

        public ValuesController(IRavenDbDataManager manager)
        {
            dataManager = manager;
        }


        /// <summary>
        /// Get values a TodoItems.
        /// </summary>
        [HttpGet]
        public ActionResult<Customer> Get()
        {
            var person = dataManager.CreateCustomer();
            return Ok(person);
        }

        /// GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post()
        {
            var person = dataManager.CreateCustomer();
            return Ok(person);
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
