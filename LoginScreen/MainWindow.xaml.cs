﻿using System;
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

namespace LoginScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var userLogin = new UserLogin();    
            if (textBoxUser.Text == userLogin.UserName && passwordBox.Password == userLogin.Password
                    || textBoxUser.Text == userLogin.UserName && passwordBox.Password == "")
            MessageBox.Show("You are logged in!");
            else
            {
                MessageBox.Show("Login failed!");
            }
        }
    }
}
