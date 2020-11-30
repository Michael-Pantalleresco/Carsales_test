using System.Net;
using FluentAssertions;
using RestSharp;
using Xunit;

namespace PrivateSellAcceptanceTests.AcceptanceTests
{
    public class PrivateSellApiAcceptanceTests
    {
        [Fact]
        public async void Given_CallToDetailsEndpoint_When_DetailsAreFound_ReturnDetails()
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
            
            RestClient client = new RestClient("https://localhost:5001");

            RestRequest request = new RestRequest("/details/95e1dee2-6217-4d71-b2a4-032c80c6be1c", Method.GET);
            
            IRestResponse response = await client.ExecuteAsync(request);

            string expectedResponse = @"{""advertId"":""95e1dee2-6217-4d71-b2a4-032c80c6be1c"",""memberId"":""1c06d3fe-4c43-7b18-9019-b39f7d2d97d6"",""heroImage"":""https://carsales.pxcrush.net/au/cars/private/9o4hs2j9qia0msiv3wapui5yq.png"",""title"":""2019 Mitsubishi Outlander"",""vertical"":""Car"",""price"":22000.0,""dateCreated"":""2020-11-16T14:41:38.57"",""dateLastUpdated"":""2020-11-16T14:46:22.673"",""odometer"":45000,""colorInterior"":""Black"",""colorExterior"":""Grey"",""registration"":""ABC123"",""registrationExpiryMonth"":10,""registrationExpiryYear"":2021,""make"":""Mitsubishi"",""model"":""Outlander"",""year"":2019,""comments"":""EXCEPTIONAL FUNCTIONALITY\nLow km with only 45000 on the clock. This 2019 Mitsubishi Outlander can move your entourage and gear all in style. This car has 7 airbags fitted for your protection with an ANCAP safety rating of 5. This Mitsubishi Outlander has audio controls on steering column. It has USB audio input, front fog lamps, bluetooth connectivity, keyless start, side airbags and rear cargo blind. \n\nEXCITING FEATURES\n- ABS brakes\n- Remote central locking\n- Rear vision camera\n- Voice recognition\n- Front cup holders\n- Rear cup holders\n- Storage compartment in centre console\n- Knee airbag for driver\n- Adaptive cruise control\n\n\nHas plenty of rego left on it. Don't let this go at this price!. This Mitsubishi Outlander LS SUV has passenger airbag. It has storage compartment in centre console and rear cargo blind."",""seller"":{""firstName"":""John"",""surname"":""Smith"",""phoneNumber"":""+61411222333""},""location"":{""postcode"":""3000"",""state"":""VIC"",""suburb"":""Melbourne"",""country"":""AU""},""photos"":[{""mediaId"":""5d1448b1-1c2c-44ed-a96d-bd0f484a0005"",""secureUrl"":""https://carsales.pxcrush.net/au/cars/private/9o4hs2j9qia0msiv3wapui5yq.png""}]}";
            
            response.Content.Should().Be(expectedResponse);
        }
    }
}