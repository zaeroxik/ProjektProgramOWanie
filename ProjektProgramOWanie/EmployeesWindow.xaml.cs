using Microsoft.EntityFrameworkCore;
using ProjektProgramOWanie.Models;
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
    /// Logika interakcji dla klasy CreateOrderWindow.xaml
    /// </summary>
    public partial class EmployeesWindow : Window
    {

        /// <summary>
        /// Loading employee table
        /// </summary>
        public EmployeesWindow()
        {
            InitializeComponent();
            list.ItemsSource = new AccountService(new appDbContext()).GetEmployees();
        }

        /// <summary>
        /// Creating object from database and refreshing current window
        /// </summary>
        void Create_Clicked(object sender, RoutedEventArgs e)
        {
            var emp = new Employee()
            {
                FirstName = firstname.Text,
                LastName = surname.Text,
                Telephone = phone.Text,
                FullName = $"{firstname.Text} {surname.Text}"
            };
            if(new AccountService(new appDbContext()).CreateEmployee(emp))
            {
                EmployeesWindow window = new EmployeesWindow();
                window.Show();
                this.Close();
            }


        }

        /// <summary>
        /// Deleting object from database 
        /// </summary>
        void Delete_Clicked(object sender, RoutedEventArgs e)
        {
            new AccountService(new appDbContext()).DeleteEmployee((((Button)sender).Tag.ToString()));
            EmployeesWindow window = new EmployeesWindow();
            window.Show();
            this.Close();
        }
    }
}
