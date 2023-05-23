using Microsoft.EntityFrameworkCore;
using ProjektProgramOWanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Logika interakcji dla klasy CreateOrderWindow.xaml
    /// </summary>
    public partial class RepairsWindow : Window
    {
        public string _plate {get; set;}
        public RepairsWindow(string Plate)
        {
            InitializeComponent();
            list.ItemsSource = new OrderService(new appDbContext()).GetCurrentRepairs(Plate);
            _plate = Plate;
        }
        /// <summary>
        /// Moving to CreateView.Visibility window where you can add a repair and loading a list with employees
        /// </summary>
        void Create_Clicked(object sender, RoutedEventArgs e)
        {
            ListView.Visibility = Visibility.Hidden;
            CreateView.Visibility = Visibility.Visible;
            var elist = new List<string>();
            foreach (var item in new AccountService(new appDbContext()).GetEmployees())
            {
                elist.Add(item.FullName);
            }
            EmployeeList.ItemsSource = elist;
           
        }
        /// <summary>
        /// Moving back to main windows - RepairsWindow
        /// </summary>
        void Back_Clicked(object sender, RoutedEventArgs e)
        {
            ListView.Visibility = Visibility.Visible;
            CreateView.Visibility = Visibility.Hidden;

        }
        /// <summary>
        /// Creating new object under Repairs and refresing window
        /// </summary>
        void CreateConfirm_Clicked(object sender, RoutedEventArgs e)
        {
            var priceParsed = Int32.TryParse(price.Text, out int result);
            var model = new CreateRepair()
            {
                Plate = _plate,
                Description = desc.Text,
                Price = result,
                EmployeeName = EmployeeList.Text
            };
            new OrderService(new appDbContext()).CreateRepair(model);

            RepairsWindow repairsWindow = new RepairsWindow(_plate);
            repairsWindow.Show();
            this.Close();

        }
        /// <summary>
        /// Adding "1" attribute to current repair and moving to finished repair section (as this window shows only "not finished"
        /// </summary>
        void Done_Clicked(object sender, RoutedEventArgs e)
        {
            new OrderService(new appDbContext()).FinishRepair(((Button)sender).Tag.ToString());
            RepairsWindow repairsWindow = new RepairsWindow(_plate);
            repairsWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Deleting current repair from table and refreshing window
        /// </summary>
        void Delete_Clicked(object sender, RoutedEventArgs e)
        {
            new OrderService(new appDbContext()).DeleteRepair((((Button)sender).Tag.ToString()));
            RepairsWindow window = new RepairsWindow(_plate);
            window.Show();
            this.Close();
        }
    }
}
