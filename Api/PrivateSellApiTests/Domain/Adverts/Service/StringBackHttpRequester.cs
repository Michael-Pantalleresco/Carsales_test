using System.Threading.Tasks;
using PrivateSellApi.Http;

namespace PrivateSellApiTests.Domain.Adverts.Service
{
    public class StringBackHttpRequester : HttpRequester
    {
        public async Task<string> MakeRequest(string resource)
        {
            return @"[{
                ""advertId"": ""c2bc8fd0-7adc-4f61-ab23-5534787f1648"",
                ""memberId"": ""06e74f1c-89b1-455a-a6f2-968ebc9458a7"",
                ""heroImage"": ""Test"",
                ""title"": ""New Car"",
                ""vertical"": ""Car"",
                ""price"": 200.0,
                ""dateCreated"": ""2020-11-23 20:49:14.803957"",
                ""dateLastUpdated"": ""2020-11-23 20:49:14.803957""
            }]";
        }
    }
}