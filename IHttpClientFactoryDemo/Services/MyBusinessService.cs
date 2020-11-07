using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHttpClientFactoryDemo
{
    public class MyBusinessService
    {

        IFirstHttpService _myHttpService;
        ISecondHttpService _secondHttpService;


        public MyBusinessService(IFirstHttpService myHttpService, ISecondHttpService secondHttpService)
        {
            _myHttpService = myHttpService;
            _secondHttpService = secondHttpService;
        }

        public async Task<string> GetFirst()
        {
            return await _myHttpService.Get();
        }


        public async Task<string> GetSecond()
        {
            return await _secondHttpService.Get();
        }
    }
}
