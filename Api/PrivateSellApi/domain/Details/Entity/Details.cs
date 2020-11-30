using System;
using System.Collections.Generic;
using PrivateSellApi.Domain.Locations.Entity;
using PrivateSellApi.Domain.Sellers.Entity;

namespace PrivateSellApi.Domain.Details.Entity
{
    public class Detail
    {
        public Guid advertId { get; set; }
        public Guid memberId { get; set; }
        public string heroImage { get; set; }
        public string title { get; set; }
        public string vertical { get; set; }
        public decimal price { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateLastUpdated { get; set; }
        public int odometer { get; set; }
        public string colorInterior { get; set; }
        public string colorExterior { get; set; }
        public string registration { get; set; }
        public int registrationExpiryMonth { get; set; }
        public int registrationExpiryYear { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string comments { get; set; }
        public Seller seller { get; set; }
        public Location location { get; set; }
        public List<Photos> photos { get; set; }
    }

    public class Photos
    {
        public string mediaId { get; set; }
        public string secureUrl { get; set; }
    }
}