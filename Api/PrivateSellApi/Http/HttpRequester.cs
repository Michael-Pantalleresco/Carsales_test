using System.Threading.Tasks;

namespace PrivateSellApi.Http
{
    public interface HttpRequester
    {
        Task<string> MakeRequest(string resource);
    }
}