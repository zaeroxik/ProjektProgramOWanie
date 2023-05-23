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
    public partial class CreateOrderWindow : Window
    {
        public CreateOrderWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creating new customer and closing current window CreateOrderWindow
        /// </summary>
        void Create_Clicked(object sender, RoutedEventArgs e)
        {
            if(Int64.TryParse(milage.Text, out long mileageParsed))
            {
                var veh = new Vehicle()
                {
                    Brand = brand.Text,
                    Model = model.Text,
                    Plate = plate.Text,
                    Milage = mileageParsed,
                    OwnerFirstName = firstname.Text,
                    OwnerLastName = lastname.Text,
                    OwnerTelephone = phone.Text,
                };
                 var result = new OrderService(new appDbContext()).CreateVehicle(veh);
                if (result is true)
                {
                    foreach (AppWindow a in Application.Current.Windows.OfType<AppWindow>())
                    {
                        AppWindow window = new AppWindow();
                        window.Show();
                        a.Close();
                    }
                    this.Close();
                }
                else
                {
                    warning.Visibility = Visibility.Visible;
                }
            }
            else
            {
                warning.Visibility = Visibility.Visible;
            }
           
        }
    }
}
