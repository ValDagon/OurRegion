using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static MFC.Views.MainPagee;

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

        private void Button_Clicked(object sender, EventArgs e)
        {
            ThirdName.Placeholder = ThirdName.Text;
            LastName.Placeholder = LastName.Text;
            FirstName.Placeholder = FirstName.Text;
            SNILS.Placeholder = SNILS.Text;
            Email.Placeholder = Email.Text;
            PhoneNumber.Placeholder = PhoneNumber.Text;
        }
    }
}