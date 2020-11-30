using System;
using System.Collections.Generic;
using FluentAssertions;
using PrivateSellApi.Domain.Adverts.Service.Entity;
using PrivateSellApi.Domain.Adverts.Service;
using PrivateSellApi.Http;
using Xunit;

namespace PrivateSellApiTests.Domain.Adverts.Service
{
    public class AdvertsServiceTests
    {
        private AdvertsService _advertsService;
        
        [Fact]
        public async void When_AdvertsFound_Then_ReturnAdverts()
        {
            HttpRequester httpRequest = new StringBackHttpRequester();
            _advertsService = new ApiBackedAdvertsService(httpRequest);
            
            var expectedResponse = CreateExpectedAdverts();
            var adverts = await _advertsService.GetAdverts();
            adverts.Should().NotBeNull();
            adverts.Should().NotBeEmpty();
            adverts.Should().BeEquivalentTo(expectedResponse);
        }

        [Fact]
        public async void When_NoAdvertsFound_Then_ReturnEmptyList()
        {
            HttpRequester httpRequest = new EmptyHttpRequester();
            _advertsService = new ApiBackedAdvertsService(httpRequest);

            var adverts = await _advertsService.GetAdverts();
            adverts.Should().BeNull();
        }
        
        private List<Advert> CreateExpectedAdverts()
        {
            return new List<Advert>
            {
                new Advert
                {
                    advertId = Guid.Parse("c2bc8fd0-7adc-4f61-ab23-5534787f1648"),
                    memberId = Guid.Parse("06e74f1c-89b1-455a-a6f2-968ebc9458a7"),
                    title = "New Car",
                    vertical = "Car",
                    heroImage = "Test",
                    price = 200.0M,
                    dateCreated = DateTime.Parse("2020-11-23 20:49:14.803957"),
                    dateLastUpdated = DateTime.Parse("2020-11-23 20:49:14.803957")
                }
            };
        }
    }
}