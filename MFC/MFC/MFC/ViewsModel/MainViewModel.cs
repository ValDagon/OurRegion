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
        /// <summary>
        private Menu selectedMenu;

        public Menu SelectedMenu
        {
            get { return selectedMenu; }
            set { selectedMenu = value; }
        }
        /// </summary>

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        private ObservableCollection<Menu> menuList;
        public ObservableCollection<Menu> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }

        public void ShowDetails()
        {
            var page = new DetailsPage() { BindingContext = new DetailsViewModel { SelectedProduct = SelectedProduct } };
            App.Current.MainPage.Navigation.PushAsync(page);
        }

        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>
            {
                new Menu { Icon = "order.png", Name = "My Order"},
                new Menu { Icon = "favorite.png", Name = "My WishList"},
                new Menu { Icon = "shopping.png", Name = "Shopping Cart"},
                new Menu { Icon = "settings.png", Name = "Settings"}
            };
        }

        private ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>
            {
                new Product { Name = "",  Image = "", Model = "", Description = ""},
                new Product { Name = "",  Image = "", Model = "", Description = ""},
                new Product { Name = "",  Image = "", Model = "", Description = ""},
                new Product { Name = "",  Image = "", Model = "", Description = ""}
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
    }

    public class Menu
    {
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
