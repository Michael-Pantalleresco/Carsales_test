using System.Threading.Tasks;
using PrivateSellApi.Http;

namespace PrivateSellApiTests.Domain.Details.Service
{
    public class StringBackedDetailsHttpRequester : HttpRequester
    {
        public async Task<string> MakeRequest(string resource)
        {
            return @"{
                ""advertId"": ""95e1dee2-6217-4d71-b2a4-032c80c6be1c"",
                ""memberId"": ""1c06d3fe-4c43-7b18-9019-b39f7d2d97d6"",
                ""heroImage"": ""Test"",
                ""title"": ""New Car"",
                ""vertical"": ""Car"",
                ""price"": 200.0,
                ""odometer"": 100,
                ""colorInterior"": ""Black"",
                ""colorExterior"": ""Grey"",
                ""registration"": ""ABC123"",
                ""registrationExpiryMonth"": 10,
                ""registrationExpiryYear"": 2020,
                ""make"": ""Mitsubishi"",
                ""model"": ""Outlander"",
                ""year"": 2019,
                ""comments"": ""Test"",
                ""seller"": {
                    ""firstName"": ""John"",
                    ""surname"": ""Smith"",
                    ""phoneNumber"": ""+61411222333""
                },
                ""location"": {
                    ""postcode"": ""3000"",
                    ""state"": ""VIC"",
                    ""suburb"": ""Melbourne"",
                    ""country"": ""AU""
                },
                ""photos"": [
                {
                    ""mediaId"": ""5d1448b1-1c2c-44ed-a96d-bd0f484a0005"",
                    ""secureUrl"": ""https://carsales.pxcrush.net/au/cars/private/9o4hs2j9qia0msiv3wapui5yq.png""
                }
                ],
                ""dateCreated"": ""2020-11-16T14:41:38.57"",
                ""dateLastUpdated"": ""2020-11-16T14:46:22.673""
            }";
        }
    }
}