using System.Threading.Tasks;
using PrivateSellApi.Http;

namespace PrivateSellApiTests.Domain.Adverts.Service
{
    public class EmptyHttpRequester : HttpRequester
    {
        public async Task<string> MakeRequest(string resource)
        {
            return "";
        }
    }
}