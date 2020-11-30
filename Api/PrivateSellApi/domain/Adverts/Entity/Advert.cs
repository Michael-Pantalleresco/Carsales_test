using System;

namespace PrivateSellApi.Domain.Adverts.Service.Entity
{
    public class Advert
    {
        public Guid advertId { get; set; }
        public Guid memberId { get; set; }
        public string heroImage { get; set; }
        public string title { get; set; }
        public string vertical { get; set; }
        public decimal price { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateLastUpdated { get; set; }
    }
}