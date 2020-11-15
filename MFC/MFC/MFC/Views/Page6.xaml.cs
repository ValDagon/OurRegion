using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MFC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            NavigationPage.SetHasNavigationBar(this, false);//уберает верхний бар
            InitializeComponent();
        }
        private async void MenuTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}