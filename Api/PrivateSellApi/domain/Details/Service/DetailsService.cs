using System;
using System.Threading.Tasks;
using PrivateSellApi.Domain.Details.Entity;

namespace PrivateSellApi.Domain.Details.Service
{
    public interface DetailsService
    {
        Task<Detail> GetDetails(Guid advertId);
    }
}