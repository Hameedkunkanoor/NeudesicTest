using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace NeudesicTest.Services
{
    public class RestService
    {
        HttpClient client;
        public RestService()
        {
            client = new HttpClient(new System.Net.Http.HttpClientHandler());
            client.MaxResponseContentBufferSize = 256000;
            client.Timeout = TimeSpan.FromSeconds(25);

        }
        const int _downloadImageTimeoutInSeconds = 15;
        readonly HttpClient _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(_downloadImageTimeoutInSeconds) };

        public async Task<byte[]> GetImageAsync(string imageUrl)
        {
            try
            {
                using (var httpResponse = await _httpClient.GetAsync(imageUrl))
                {
                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        return await httpResponse.Content.ReadAsByteArrayAsync();
                    }
                    else
                    {
                        //Url is Invalid
                        return null;
                    }
                }



            }
            catch (Exception e)
            {
                //Handle Exception
                return null;
            }
        }
        public async Task<T> GetAsync<T>(string WebAPIUrl)
        {
            try
            {
                var uri = new Uri(WebAPIUrl);
                var response = await client.GetAsync(uri);
                string Body = await response.Content.ReadAsStringAsync();
                var responseResult = JsonConvert.DeserializeObject<T>(Body);
                return responseResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}