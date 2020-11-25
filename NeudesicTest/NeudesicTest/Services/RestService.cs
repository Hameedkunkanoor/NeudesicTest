using System;
using System.Net;
using System.Net.Http;
using System.Text;
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
            client.MaxResponseContentBufferSize = 20000000;
            client.Timeout = TimeSpan.FromSeconds(145);

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