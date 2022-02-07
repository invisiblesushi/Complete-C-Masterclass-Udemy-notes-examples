﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WPFTasksE
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

        private async void MyButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/20MB.zip").Result;
            }
            ); 

            MyButton.Content = "Done Downloading";
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
