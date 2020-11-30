using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PrivateSellApi.Domain.Details.Entity;
using PrivateSellApi.Domain.Details.Service;

namespace PrivateSellApi.Controllers
{
    public class DetailsController
    {
        private readonly DetailsService _detailsService;

        public DetailsController(DetailsService detailsService)
        {
            _detailsService = detailsService;
        }
        [HttpGet]
        [Route("/details/{advertId}")]
        public async Task<Detail> GetDetails(Guid advertId)
        {
            var details = await _detailsService.GetDetails(advertId);
            return details;
        }
    }
}