using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHttpClientFactoryDemo
{
    public interface ISecondHttpService
    {

        Task<string> Get();
    }
}
