using System;
using System.Windows.Input;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using NeudesicTest.Services;
using Xamarin.Forms;
using System.Collections.Generic;
using Xamarin.Essentials;

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
            CloseImage = new Command(CloseImagePopup);
            DontClose = new Command(DontCloseImagePopup);
            //CrossDownloadManager.Current.CollectionChanged += (sender, e) =>
            //  System.Diagnostics.Debug.WriteLine(
            //      "[DownloadManager] " + e.Action +
            //      " -> New items: " + (e.NewItems?.Count ?? 0) +
            //      " at " + e.NewStartingIndex +
            //      " || Old items: " + (e.OldItems?.Count ?? 0) +
            //      " at " + e.OldStartingIndex
            //  );
        }
        private string InstaUrlFormat = "https://www.instagram.com/{0}/?__a=1";
        private readonly IMvxNavigationService navigationService;
        private string url = string.Empty;
        public string Url
        {
            get => url;
            set
            {

                url = value;
                RaisePropertyChanged(nameof(Url));

            }
        }

        private bool showTheImage = false;
        public bool ShowTheImage
        {
            get => showTheImage;
            set
            {

                showTheImage = value;
                RaisePropertyChanged(nameof(ShowTheImage));

            }
        }
        private string picUrl = string.Empty;
        public string PicUrl
        {
            get => picUrl;
            set
            {

                picUrl = value;
                RaisePropertyChanged(nameof(PicUrl));

            }
        }

        private bool showImage = false;
        public bool ShowImage
        {
            get => showImage;
            set
            {

                showImage = value;
                RaisePropertyChanged(nameof(ShowImage));

            }
        }
        private GetData getData;

        private void CloseImagePopup()
        {
            ShowTheImage = false;
        }
        private void DontCloseImagePopup()
        {
            //ShowTheImage = false;
        }
        public ICommand DontClose { get; set; }

        public ICommand OpenProfile { get; set; }

        public ICommand CloseImage { get; set; }
  
        
        public override void ViewAppeared()
        {

            base.ViewAppeared();
        }

    }

}
