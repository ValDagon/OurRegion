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
    public partial class Page7 : ContentPage
    {
        public Page7()
        {
            NavigationPage.SetHasNavigationBar(this, false);//уберает верхний бар
            InitializeComponent();
        }

        private void MenuTapped(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Page2());
        }
    }
}