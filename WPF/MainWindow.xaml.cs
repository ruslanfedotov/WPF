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
using WPF.Pages;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.ProductsPage());
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.ProductsPage());
        }

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.CartPage());
        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.OrderPage());
        }
    }
}
