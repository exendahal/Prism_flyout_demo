using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
    public class Page2ViewModel : BindableBase
    {
        public Page2ViewModel()
        {

        }

        public async void ShowAlert()
        {
            await App.Current.MainPage.DisplayAlert("Hi","Hello","OK");
        }
    }
}
