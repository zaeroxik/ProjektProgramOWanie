﻿using Microsoft.EntityFrameworkCore;
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

namespace ProjektProgramOWanie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() //wstrzykiwanie zaleznosci
        {
            InitializeComponent();

        }

        void login_Clicked(object sender, RoutedEventArgs e)
        {
            if (new LoginService(new appDbContext()).Authenticate(username.Text, password.Password))
            {
                AppWindow window = new AppWindow();
                window.Show();
                this.Close();
            }
            else
            {
                warning.Visibility = Visibility.Visible;
            }
        }
        }
    }

