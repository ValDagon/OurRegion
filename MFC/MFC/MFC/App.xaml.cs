using MFC.Views;
using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MFC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "Shapes_Experimental", "Expander_Experimental" });
            // MainPage = new SharedTransitionNavigationPage(new TravelIndustry());
            MainPage = new SharedTransitionNavigationPage(new MainPagee());
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
