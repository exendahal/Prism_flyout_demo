using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
        }

        public void NavigatePage1()
        {
            _navigationService.NavigateAsync("NavigationPage/Page1");
        }

        public void NavigatePage2()
        {
            _navigationService.NavigateAsync("NavigationPage/Page2");
        }
    }
}
