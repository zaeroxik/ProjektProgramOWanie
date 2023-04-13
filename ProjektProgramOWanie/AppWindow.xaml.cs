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

namespace ProjektProgramOWanie
{
    /// <summary>
    /// Logika interakcji dla klasy AppWindow.xaml
    /// </summary>
    public partial class AppWindow : Window
    {
        public AppWindow()
        {
            InitializeComponent();
            list.ItemsSource = new OrderService(new appDbContext()).GetAll();
        }

        void createOrder_Clicked(object sender, RoutedEventArgs e)
        {
            CreateOrderWindow window = new CreateOrderWindow();
            window.Show();
        }
        void Logout_Clicked(object sender, RoutedEventArgs e)
            {
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
            }

        
    }
}