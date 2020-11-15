﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.SharedTransitions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MFC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPagee : ContentPage
    {
        public MainPagee()
        {
            NavigationPage.SetHasNavigationBar(this, false);//уберает верхний бар
            InitializeComponent();
        }
        private void OpenMenu()
        {
            MenuGrid.IsVisible = true;

            Action<double> callback = input => MenuView.TranslationX = input;
            MenuView.Animate("anim", callback, -260, 0, 16, 300, Easing.CubicInOut);
        }

        private void CloseMenu()
        {
            Action<double> callback = input => MenuView.TranslationX = input;
            MenuView.Animate("anim", callback, 0, -260, 16, 300, Easing.CubicInOut);

            MenuGrid.IsVisible = false;
        }


        private void MenuTapped(object sender, EventArgs e)
        {
            OpenMenu();
        }

        private void OverlayTapped(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void ProductSelected(object sender, SelectionChangedEventArgs e)
        {
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, vm.SelectedProduct.Name);
            vm.ShowDetails();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            CloseMenu();
            Application.Current.MainPage = new NavigationPage(new MainPagee());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            CloseMenu();
            Application.Current.MainPage = new NavigationPage(new Page1());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            CloseMenu();
            Application.Current.MainPage = new NavigationPage(new Page3());
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            CloseMenu();
            Application.Current.MainPage = new NavigationPage(new Page2());
        }
    }
}