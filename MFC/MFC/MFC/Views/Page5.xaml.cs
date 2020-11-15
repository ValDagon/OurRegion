using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MFC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            NavigationPage.SetHasNavigationBar(this, false);//уберает верхний бар
            InitializeComponent();
        }

        private async void MenuTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPagee());
        }
    }
}