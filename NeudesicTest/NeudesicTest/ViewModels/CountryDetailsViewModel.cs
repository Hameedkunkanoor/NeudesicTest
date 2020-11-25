using System;
using System.Windows.Input;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using NeudesicTest.Services;
using Xamarin.Forms;
using System.Collections.Generic;
using Xamarin.Essentials;
using NeudesicTest.Models;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NeudesicTest.ViewModels
{
    public class CountryDetailsViewModel : MvxViewModel<string>
    {

        RestService restService;
        public CountryDetailsViewModel(IMvxNavigationService navigationService)
        {
            restService = new RestService();
            this.navigationService = navigationService;
            getData = new GetData();

        }
        private readonly IMvxNavigationService navigationService;
        private string url = string.Empty;



        private CountryDetails countryDetails;
        public CountryDetails CountryDetails
        {
            get => countryDetails;
            set
            {

                countryDetails = value;
                RaisePropertyChanged(nameof(CountryDetails));

            }
        }
        
        private string capital;
        public string Capital
        {
            get => capital;
            set
            {

                capital = value;
                RaisePropertyChanged(nameof(Capital));

            }
        }


        private string fagUrl;
        public string FlagUrl
        {
            get => fagUrl;
            set
            {

                fagUrl = value;
                RaisePropertyChanged(nameof(FlagUrl));

            }
        }
        private string countryName;
        public string CountryName
        {
            get => countryName;
            set
            {

                countryName = value;
                RaisePropertyChanged(nameof(CountryName));

            }
        }
        private string population;
        public string Population
        {
            get => population;
            set
            {

                population = value;
                RaisePropertyChanged(nameof(Population));

            }
        }
        private string area;
        public string Area
        {
            get => area;
            set
            {

                area = value;
                RaisePropertyChanged(nameof(Area));

            }
        }
        private string currencyName;
        public string CurrencyName
        {
            get => currencyName;
            set
            {

                currencyName = value;
                RaisePropertyChanged(nameof(CurrencyName));

            }
        }
        private string demonym;
        public string Demonym
        {
            get => demonym;
            set
            {

                demonym = value;
                RaisePropertyChanged(nameof(Demonym));

            }
        }
        private string callingCodes;
        public string CallingCodes
        {
            get => callingCodes;
            set
            {

                callingCodes = value;
                RaisePropertyChanged(nameof(CallingCodes));

            }
        }
        private string region;
        public string Region
        {
            get => region;
            set
            {

                region = value;
                RaisePropertyChanged(nameof(Region));

            }
        }
        private string subRegion;
        public string SubRegion
        {
            get => subRegion;
            set
            {

                subRegion = value;
                RaisePropertyChanged(nameof(SubRegion));

            }
        }
        
              private string gini;
        public string Gini
        {
            get => gini;
            set
            {

                gini = value;
                RaisePropertyChanged(nameof(Gini));

            }
        }
        private GetData getData;

        private string alpha3Code = string.Empty;

        public async Task GetCountryDetails()
        {
            try
            {
                url =$"{"https://restcountries.eu/rest/v2/alpha/"}{alpha3Code}";
                CountryDetails Result = await getData.FetchCountryDetails(url);
                if (Result != null)
                {
                    CountryDetails = Result;
                    FlagUrl = CountryDetails.Flag;
                    Capital = CountryDetails.Capital;
                    CountryName = CountryDetails.Name;
                    Population = CountryDetails.Population;
                    Area = CountryDetails.Area;
                    CurrencyName = CountryDetails.Currencies[0].NameCurrency;
                    Demonym = CountryDetails.Demonym;
                    CallingCodes = CountryDetails.CallingCodes[0];
                    Region = CountryDetails.Region;
                    SubRegion = CountryDetails.Subregion;
                    //Gini = CountryDetails.Gini;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        public override void ViewAppeared()
        {
            base.ViewAppeared();
        }

        public async override void Prepare(string parameter)
        {
            try
            {
                base.Prepare();
                CountryDetails = new CountryDetails() { };
                alpha3Code = parameter;
                await GetCountryDetails();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

    }
}
