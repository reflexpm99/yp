using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;
using WpfApp7.admin;
using System.Collections.ObjectModel;
using WpfApp7.database;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public ObservableCollection<Product> Products { get; set; }
        public MainWindow2()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>();
            DataContext = this;
            LoadProducts();
        }
        public void LoadProducts()
        {
            using (var context = new balbesEntities())
            {
                var products = context.Product.ToList();
                foreach (var product in products)
                {
                    Products.Add(new Product
                    {
                        Image = product.Image,
                        ProductName = product.ProductName,///крч оно так то работает, пока то не трогать 
                        Status = product.Status,
                        Price = product.Price,
                        // Установка значений других свойств товара
                    });
                }
            }
        }
        private void Add_Product_Click(object sender, RoutedEventArgs e)
        {
            addProduct2 addProduct2 = new addProduct2();
            addProduct2.Show();
        }
    }
}
