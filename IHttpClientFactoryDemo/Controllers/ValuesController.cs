using IHttpClientFactoryDemo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        MyBusinessService _myBusinessService;

        public ValuesController(MyBusinessService myBusinessService)
        {
            _myBusinessService = myBusinessService;
        }

        // GET api/values/get1

        [HttpGet]
        public async Task<string> Get1()
        {
            return await _myBusinessService.GetFirst();
        }

        // GET api/values/get2
        [HttpGet]
        public async Task<string> Get2()
        {
            return await _myBusinessService.GetSecond();
        }


    }
}
