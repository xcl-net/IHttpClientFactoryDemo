using System.Threading.Tasks;

namespace WebApplication4.Services
{
    public interface IMyHttpService
    {
        Task<string> Get();
    }
}
