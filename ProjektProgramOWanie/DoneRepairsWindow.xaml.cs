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
    public partial class DoneRepairsWindow : Window
    {

        public DoneRepairsWindow(string Plate)
        {
            InitializeComponent();
            list.ItemsSource = new OrderService(new appDbContext()).GetDoneRepairs(Plate);

        }        
    }
}
