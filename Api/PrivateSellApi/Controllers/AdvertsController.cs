using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PrivateSellApi.Domain.Adverts.Service.Entity;
using PrivateSellApi.Domain.Adverts.Service;
using RestSharp;

namespace PrivateSellApi.Controllers
{
    public class AdvertsController
    {
        private readonly AdvertsService _advertsService;

        public AdvertsController(AdvertsService advertsService)
        {
            _advertsService = advertsService;
        }
        
        [HttpGet]
        [Route("/adverts")]
        
        public async Task<IEnumerable<Advert>> Adverts()
        {
            var adverts = await _advertsService.GetAdverts();
            return adverts;
        }
    }
}