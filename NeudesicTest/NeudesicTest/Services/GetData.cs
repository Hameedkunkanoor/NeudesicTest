using NeudesicTest.Models;
using System;
using System.Threading.Tasks;

namespace NeudesicTest.Services
{
    public class GetData
    {



        private RestService restService;
        public GetData()
        {
            restService = new RestService();
        }
        public async Task<CountriesList> FetchAllCountries(string url)
        {
            try
            {
                var Profileurl = url;
                var result = await restService.GetAsync<CountriesList>(url);
                return result;
            }

            catch (Exception)
            {
                return new CountriesList
                {

                };
            }
        }

        public async Task<CountryDetails> FetchInstaPic(string url)
        {
            try
            {
                var Profileurl = url;
                var result = await restService.GetAsync<CountryDetails>(url);
                return result;
            }

            catch (Exception)
            {
                return new CountryDetails
                {

                };
            }
        }

    }
}
