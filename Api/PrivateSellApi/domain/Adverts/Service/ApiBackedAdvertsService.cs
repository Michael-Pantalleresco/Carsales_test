using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrivateSellApi.Domain.Adverts.Service.Entity;
using PrivateSellApi.Http;

namespace PrivateSellApi.Domain.Adverts.Service
{
    public class ApiBackedAdvertsService : AdvertsService
    {
        private readonly HttpRequester _httpRequester;

        public ApiBackedAdvertsService(HttpRequester httpRequester)
        {
            _httpRequester = httpRequester;
        }
        public async Task<List<Advert>> GetAdverts()
        {
            var response = await _httpRequester.MakeRequest("/adverts");
            return JsonConvert.DeserializeObject<List<Advert>>(response);
        }
    }
}