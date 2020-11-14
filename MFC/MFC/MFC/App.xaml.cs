using MFC.Views;
using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Lora-Italic.ttf", Alias = "Lora")]
[assembly: ExportFont("PlayfairDisplay-Black.ttf", Alias = "PlayfairDisplay")]
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
