using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        //IMyCustomService _client;

        //public ValuesController(IMyCustomService client)
        //{
        //    _client = client;
        //}


        MyBusinessService _myBusinessService;
        public ValuesController(MyBusinessService myBusinessService)
        {
            _myBusinessService = myBusinessService;
        }

        // GET api/values
        [HttpGet]
        public async Task<string> Get()
        {
            return await _myBusinessService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
