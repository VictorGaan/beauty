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
    /// Логика взаимодействия для HistoryWindow.xaml
    /// </summary>
    public partial class HistoryWindow : Window
    {
        public HistoryWindow()
        {
            InitializeComponent();
            HistoryGrid.ItemsSource = Helper.db.ProductSale.ToList();
            CmbProducts.ItemsSource = Helper.db.Product.ToList();
        }
        public HistoryWindow(Product product)
        {
            InitializeComponent();
            HistoryGrid.ItemsSource = Helper.db.ProductSale.ToList().Where(x=>x.Product==product).ToList();
            CmbProducts.ItemsSource = Helper.db.Product.ToList();
        }

        private void CmbProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var product = CmbProducts.SelectedItem as Product;
            HistoryGrid.ItemsSource = Helper.db.ProductSale.ToList().Where(x => x.Product == product).ToList();
        }
    }
}
