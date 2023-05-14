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
        void Back_Clicked(object sender, RoutedEventArgs e)
        {
            ListView.Visibility = Visibility.Visible;
            CreateView.Visibility = Visibility.Hidden;

        }
        void CreateConfirm_Clicked(object sender, RoutedEventArgs e)
        {
            var model = new CreateRepair()
            {
                Plate = _plate,
                Description = desc.Text,
                Price = Int32.Parse(price.Text),
                EmployeeName = EmployeeList.Text
            };
            new OrderService(new appDbContext()).CreateRepair(model);

            RepairsWindow repairsWindow = new RepairsWindow(_plate);
            repairsWindow.Show();
            this.Close();

        }

        void Done_Clicked(object sender, RoutedEventArgs e)
        {
            new OrderService(new appDbContext()).FinishRepair(((Button)sender).Tag.ToString());
            RepairsWindow repairsWindow = new RepairsWindow(_plate);
            repairsWindow.Show();
            this.Close();
        }
        void Delete_Clicked(object sender, RoutedEventArgs e)
        {
            new OrderService(new appDbContext()).DeleteRepair((((Button)sender).Tag.ToString()));
            RepairsWindow window = new RepairsWindow(_plate);
            window.Show();
            this.Close();
        }
    }
}
