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
    public class HomeViewModel : MvxViewModel
    {

        RestService restService;
        public HomeViewModel(IMvxNavigationService navigationService)
        {
            restService = new RestService();
            this.navigationService = navigationService;
            getData = new GetData();

        }
        private readonly IMvxNavigationService navigationService;
        private string url = string.Empty;
      


        private MvxObservableCollection<Country> countriesList;
        public MvxObservableCollection<Country> CountriesList
        {
            get => countriesList;
            set
            {

                countriesList = value;
                RaisePropertyChanged(nameof(CountriesList));

            }
        }


        private GetData getData;



        public async Task GetCountries()
        {
            try
            {
                url = "https://restcountries.eu/rest/v2/all";
                List<Country> Result = await getData.FetchAllCountries(url);
                if (Result != null)
                {
                    foreach (var item in Result)
                    {
                        item.FlagUrl = item.Flag.AbsoluteUri;
                        if(item.Currencies!=null && item.Currencies.Count>0)
                        item.Currency = item.Currencies[0].NameCurrency;
                        CountriesList.Add(item);
                    }
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

        public async override void Prepare()
        {
            base.Prepare();
            CountriesList = new MvxObservableCollection<Country>() { };
            await GetCountries();
        }

    }
}
