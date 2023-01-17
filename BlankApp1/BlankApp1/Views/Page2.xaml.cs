using BlankApp1.ViewModels;
using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var vm = BindingContext as Page2ViewModel;
            vm.ShowAlert();
        }
    }
}
