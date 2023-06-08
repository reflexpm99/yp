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

namespace WpfApp7.admin
{
    /// <summary>
    /// Логика взаимодействия для addProduct2.xaml
    /// </summary>
    public partial class addProduct2 : Window
    {
        public addProduct2()
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

        private void Save_ProductA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_ProductA_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

