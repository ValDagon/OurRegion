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

        }

        private Product selectedProduct;

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
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


}
