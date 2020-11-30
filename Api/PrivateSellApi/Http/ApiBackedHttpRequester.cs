using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestSharp;
using RestSharp.Authenticators;

namespace PrivateSellApi.Http
{
    public class ApiBackedHttpRequester : HttpRequester
    {
        private static IConfiguration _configuration;
        private static ILogger _logger;

        public ApiBackedHttpRequester(IConfiguration configuration, ILogger<ApiBackedHttpRequester> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<string> MakeRequest(string resource)
        {
            var clientId = _configuration.GetValue<string>("ClientId");
            var clientSecret = _configuration.GetValue<string>("ClientSecret");

            var client = new RestClient(_configuration.GetValue<string>("BASE_URL"))
            {
                Authenticator = new HttpBasicAuthenticator(clientId, clientSecret)
            };
            
            var request = new RestRequest(resource, Method.GET);
            
            var response = await client.ExecuteAsync(request);
            _logger.Log(LogLevel.Information, $"Response StatusCode was {response.StatusCode.ToString()}");
            return response.Content;
            
        }
    }
}