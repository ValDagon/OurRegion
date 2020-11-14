using MFC.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MFC.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Products = GetProducts();
            MenuList = GetMenus();

        }

        private Product selectedProduct;


        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
        }

        private Menu selectedMenu;

        public Menu SelectedMenu
        {
            get { return selectedMenu; }
            set { selectedMenu = value; }
        }
         private ObservableCollection<Menu> menuList;
        public ObservableCollection<Menu> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }
        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>
            {
                new Menu { Name = "Оплата госпошлин -30%", Name1 = "1 200 Р", Name2 ="850 Р"},
                new Menu { Name = "Авто штрафы -50%", Name1 = "900 Р", Name2 ="450 Р"},
                new Menu { Name = "Оплата госпошлин -30%", Name1 = "900 Р", Name2 ="850 Р"},
                new Menu { Name = "Оплата госпошлин -30%", Name1 = "450 Р", Name2 ="850 Р"}
            };
        }

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }



        public void ShowDetails()
        {
            var page = new DetailsPage() { BindingContext = new DetailsViewModel { SelectedProduct = SelectedProduct } };
            App.Current.MainPage.Navigation.PushAsync(page);
        }

        private ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>
            {
                new Product { Name = "Запись на услугу принята",  Image = "Tick.png", Model = "Получение загранпаспорта", Description = "16.11.20", Description1 = "09:00"},
                new Product { Name = "Запись на не услугу принята",  Image = "Points.png", Model = "Замена паспорта РФ в...", Description = "13.11.20", Description1 = "10:00"},
                new Product { Name = "Запись на услугу принята",  Image = "Tick.png", Model = "Прием в налоговую...", Description = "12.11.20", Description1 = "12:00"},
                new Product { Name = "Запись на услугу принята",  Image = "Tick.png", Model = "Получение загранпаспорта", Description = "11.11.20", Description1 = "08:00"}
                };
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

    public class Product
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Description1 { get; set; }
    }

    public class Menu
    {
        public string Name { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
    }



}
