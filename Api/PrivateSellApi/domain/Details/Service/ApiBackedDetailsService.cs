using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrivateSellApi.Domain.Details.Entity;
using PrivateSellApi.Http;

namespace PrivateSellApi.Domain.Details.Service
{
    public class ApiBackedDetailsService : DetailsService
    {
        private readonly HttpRequester _httpRequester;

        public ApiBackedDetailsService(HttpRequester httpRequester)
        {
            _httpRequester = httpRequester;
        }
        
        public async Task<Detail> GetDetails(Guid advertId)
        {
            var response = await _httpRequester.MakeRequest($"/adverts/{advertId}");
            return JsonConvert.DeserializeObject<Detail>(response);
        }
    }
    
}