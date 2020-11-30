using System.Net;
using FluentAssertions;
using RestSharp;
using Xunit;

namespace PrivateSellAcceptanceTests.AcceptanceTests
{
    public class AdvertsAcceptanceTests
    {
        [Fact]
        public async void Given_CallToTheAdvertsEndpoint_When_AdvertsFound_ReturnAdverts()
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
            
            RestClient client = new RestClient("https://localhost:5001");

            RestRequest request = new RestRequest("/adverts", Method.GET);
            
            IRestResponse response = await client.ExecuteAsync(request);

            string expectedResponse = @"[{""advertId"":""95e1dee2-6217-4d71-b2a4-032c80c6be1c"",""memberId"":""1c06d3fe-4c43-7b18-9019-b39f7d2d97d6"",""heroImage"":""https://carsales.pxcrush.net/au/cars/private/9o4hs2j9qia0msiv3wapui5yq.png"",""title"":""2019 Mitsubishi Outlander"",""vertical"":""Car"",""price"":22000.0,""dateCreated"":""2020-11-16T14:41:38.57"",""dateLastUpdated"":""2020-11-16T14:46:22.673""},{""advertId"":""1c582c52-4878-4943-886a-98983aa2b1ec"",""memberId"":""1c06d3fe-4c43-7b18-9019-b39f7d2d97d6"",""heroImage"":""https://carsales.pxcrush.net/au/cars/private/6js9v4g6k09t3ahgyif2dofdi.jpg"",""title"":""1990 Mitsubishi Galant"",""vertical"":""Car"",""price"":4500.0,""dateCreated"":""2020-11-16T14:47:37.987"",""dateLastUpdated"":""2020-11-16T14:48:27.213""},{""advertId"":""177b1765-5873-4bb1-a9a0-5c4134778ffd"",""memberId"":""1c06d3fe-4c43-7b18-9019-b39f7d2d97d6"",""heroImage"":""https://carsales.pxcrush.net/au/cars/private/4wgyct99vy7up9fjif2wt3sqe.jpg"",""title"":""2019 Tesla Model S"",""vertical"":""Car"",""price"":68000.0,""dateCreated"":""2020-11-16T14:48:56.57"",""dateLastUpdated"":""2020-11-16T14:49:52.65""},{""advertId"":""1e40aa05-a96a-4cc9-a769-28e21c52a180"",""memberId"":""1c06d3fe-4c43-7b18-9019-b39f7d2d97d6"",""heroImage"":""https://bikesales.pxcrush.net/au/bikes/private/apa4bzjq54zph6bw0miq7ex5w.png"",""title"":""2006 Aprilia RS1000 Touring [MY2006]"",""vertical"":""Bike"",""price"":1234.0,""dateCreated"":""2020-11-16T14:53:41.243"",""dateLastUpdated"":""2020-11-16T14:55:06.697""}]";
            
            response.Content.Should().Be(expectedResponse);
        }
    }
    
    
}