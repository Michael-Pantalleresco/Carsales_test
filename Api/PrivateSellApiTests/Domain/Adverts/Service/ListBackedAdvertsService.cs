using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PrivateSellApi.Domain.Adverts.Service.Entity;
using PrivateSellApi.Domain.Adverts.Service;

namespace PrivateSellApiTests.Domain.Adverts.Service
{
    public class ListBackedAdvertsService : AdvertsService
    {
        public async Task<List<Advert>> GetAdverts()
        {
            return new List<Advert> { new Advert()
            {
                advertId = Guid.NewGuid(), 
                memberId = Guid.NewGuid(), 
                title = "New Car", 
                vertical = "Car", 
                heroImage = "",
                price = 200.0M,
                dateCreated = DateTime.Now,
                dateLastUpdated = DateTime.Now
                
            } };
        }
    }
}