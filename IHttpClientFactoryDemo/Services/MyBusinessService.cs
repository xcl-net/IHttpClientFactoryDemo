using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Services
{
    public class MyBusinessService
    {

        IMyHttpService _myHttpService;
        public MyBusinessService(IMyHttpService myHttpService)
        {
            _myHttpService = myHttpService;
        }

        public async Task<string> Get()
        {
           return await _myHttpService.Get();
        }

    }
}
