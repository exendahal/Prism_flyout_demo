using BlankApp1.ViewModels;
using System;
using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Page1)));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var vm = BindingContext as MainPageViewModel;
            vm.NavigatePage1();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var vm = BindingContext as MainPageViewModel;
            vm.NavigatePage2();
        }
    }
}
