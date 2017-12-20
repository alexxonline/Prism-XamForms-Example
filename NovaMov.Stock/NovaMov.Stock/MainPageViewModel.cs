using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaMov.Stock
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
        }


        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Title = parameters.GetValue<string>("title");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

    }
}
