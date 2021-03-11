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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Beauty
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Manufacturer> Manufacturers = new List<Manufacturer>();
        public MainWindow()
        {
            InitializeComponent();
            Manufacturers = Helper.db.Manufacturer.ToList();
            Manufacturers.Insert(0, new Manufacturer { Name = "Все элементы" });
            CmbManufacturies.ItemsSource = Manufacturers;
            Load();
        }

        private void Load()
        {
            ProductsListView.ItemsSource = Helper.db.Product.ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text=="")
            {
                Load();
            }
            else
            {
             ProductsListView.ItemsSource = Helper.db.Product.ToList().Where(x => x.Title.StartsWith(textBox.Text));
            }
        }

        private void CmbManufacturies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbManufacturies.SelectedIndex==0)
            {
                ProductsListView.ItemsSource = Helper.db.Product.ToList();
            }
            else
            {
                var manufacture = CmbManufacturies.SelectedItem as Manufacturer;
                if (manufacture != null)
                {
                    ProductsListView.ItemsSource = Helper.db.Product.ToList().Where(x => x.Manufacturer == manufacture).ToList();
                }
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = (sender as Button).DataContext as Product;
                if (product != null)
                {
                    Helper.db.Product.Remove(product);
                    Helper.db.SaveChanges();
                    Load();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Обьект не может быть удалён, он связян с другой сущностью","Удаление",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
           
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            Product product = (sender as Button).DataContext as Product;
            if (product != null)
            {
                new ProductWindow(product).ShowDialog();
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            new ProductWindow().ShowDialog();
        }

        private void BtnHistory_Click(object sender, RoutedEventArgs e)
        {
            new HistoryWindow().ShowDialog();
        }

        private void BtnHistory_Click_1(object sender, RoutedEventArgs e)
        {
            Product product = (sender as Button).DataContext as Product;
            if (product != null)
            {
                new HistoryWindow(product).ShowDialog();
            }
        }
    }
}
