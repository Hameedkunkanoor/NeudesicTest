using NeudesicTest.Models;
using System;
using System.Collections.Generic;
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
        public async Task<List<Country>> FetchAllCountries(string url)
        {
            try
            {
                var result = await restService.GetAsync<List<Country>>(url);
                return result;
            }

            catch (Exception)
            {
                return new List<Country>
                {

                };
            }
        }

        public async Task<CountryDetails> FetchCountryDetails(string url)
        {
            try
            {
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
