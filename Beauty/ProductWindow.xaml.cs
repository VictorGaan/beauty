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

namespace Beauty
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
            CmbManufacturies.ItemsSource = Helper.db.Manufacturer.ToList();
            DataContext = new Product();
        }
        public ProductWindow(Product product)
        {
            InitializeComponent();
            CmbManufacturies.ItemsSource = Helper.db.Manufacturer.ToList();
            DataContext = product;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((DataContext as Product).ID==0)
            {
                Helper.db.Product.Add(DataContext as Product);
            }
            Helper.db.SaveChanges();
        }
    }
}
