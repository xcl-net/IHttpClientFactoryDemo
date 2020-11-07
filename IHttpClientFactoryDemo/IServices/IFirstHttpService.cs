using System.Threading.Tasks;

namespace IHttpClientFactoryDemo
{
    public interface IFirstHttpService
    {
        Task<string> Get();
    }
}
