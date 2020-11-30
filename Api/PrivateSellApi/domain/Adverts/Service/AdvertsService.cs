using System.Collections.Generic;
using System.Threading.Tasks;
using PrivateSellApi.Domain.Adverts.Service.Entity;

namespace PrivateSellApi.Domain.Adverts.Service
{
    public interface AdvertsService
    { 
        Task<List<Advert>> GetAdverts();
    }
}