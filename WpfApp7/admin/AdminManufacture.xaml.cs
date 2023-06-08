using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp7.database;

namespace WpfApp7.admin
{
   
    public partial class AdminManufacture : Window
    {
        public ObservableCollection<Manufacturer> Manufacturers { get; set; }
        public AdminManufacture()
        {
            InitializeComponent();
            Manufacturers = new ObservableCollection<Manufacturer>();
            DataContext = this;
            LoadManufacture2();
        }
        public void LoadManufacture2()
        {
            using (var context = new balbesEntities())
            {
                var manufacturers = context.Manufacturer.ToList();
                foreach (var manufacturer in manufacturers)
                {
                    Manufacturers.Add(new Manufacturer
                    {
                        ManufacturerName = manufacturer.ManufacturerName,
                        Date = manufacturer.Date,
                    });
                }
            }
        }


        private void Add_manufack_adm(object sender, RoutedEventArgs e)
        {
            addManufactureAA addManufactureAA = new addManufactureAA();
            addManufactureAA.Show();
        }
    }
}
