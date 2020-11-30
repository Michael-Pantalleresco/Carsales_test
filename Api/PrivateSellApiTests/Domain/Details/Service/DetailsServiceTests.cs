using System;
using System.Collections.Generic;
using FluentAssertions;
using Moq;
using PrivateSellApi.Domain.Details.Entity;
using PrivateSellApi.Domain.Details.Service;
using PrivateSellApi.Domain.Locations.Entity;
using PrivateSellApi.Domain.Sellers.Entity;
using PrivateSellApi.Http;
using PrivateSellApiTests.Domain.Adverts.Service;
using Xunit;

namespace PrivateSellApiTests.Domain.Details.Service
{
    public class DetailsServiceTests
    {
        private DetailsService _detailsService;
        
        [Fact]
        public async void When_AdvertsFound_Then_ReturnAdverts()
        {
            HttpRequester httpRequest = new StringBackedDetailsHttpRequester();
            _detailsService = new ApiBackedDetailsService(httpRequest);
            
            var expectedResponse = CreateExpectedDetails();
            
            var details = await _detailsService.GetDetails(It.IsAny<Guid>());
            details.Should().NotBeNull();
            details.Should().BeEquivalentTo(expectedResponse);
        }

        [Fact]
        public async void When_NoAdvertsFound_Then_ReturnEmptyList()
        {
            HttpRequester httpRequest = new EmptyHttpRequester();
            _detailsService = new ApiBackedDetailsService(httpRequest);

            var details = await _detailsService.GetDetails(It.IsAny<Guid>());
            details.Should().BeNull();
        }

        private Detail CreateExpectedDetails()
        {
            return new Detail
            {
                advertId = Guid.Parse("95e1dee2-6217-4d71-b2a4-032c80c6be1c"),
                memberId = Guid.Parse("1c06d3fe-4c43-7b18-9019-b39f7d2d97d6"),
                heroImage = "Test",
                title = "New Car",
                price = 200.0M,
                vertical = "Car",
                odometer = 100,
                colorInterior = "Black",
                colorExterior = "Grey",
                registration = "ABC123",
                registrationExpiryMonth = 10,
                registrationExpiryYear = 2020,
                make = "Mitsubishi",
                model = "Outlander",
                year = 2019,
                comments = "Test",
                seller = new Seller
                {
                    firstName = "John",
                    surname = "Smith",
                    phoneNumber = "+61411222333"
                },
                location = new Location
                {
                    suburb = "Melbourne",
                    postcode = "3000",
                    state = "VIC",
                    country = "AU"
                },
                dateCreated = DateTime.Parse("2020-11-16T14:41:38.57"),
                dateLastUpdated = DateTime.Parse("2020-11-16T14:46:22.673"),
                photos = new List<Photos>()
                {
                    new Photos()
                    {
                        mediaId = "5d1448b1-1c2c-44ed-a96d-bd0f484a0005",
                        secureUrl = "https://carsales.pxcrush.net/au/cars/private/9o4hs2j9qia0msiv3wapui5yq.png"
                    }
                }
            };
        }
    }
}