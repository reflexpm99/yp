using Microsoft.Win32;
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
using WpfApp7.database;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для addProduct.xaml
    /// </summary>
    public partial class addProduct : Window
    {
        public addProduct()
        {
            InitializeComponent();
        }
        private void ChangeImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == true)
            {
                // Получите путь к выбранному изображению и выполните необходимые операции для сохранения в базу данных
                string imagePath = openFileDialog.FileName;

                // Ваш код для сохранения изображения в базу данных
            }
        }

        private void Close_ProductU_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_ProductU_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
