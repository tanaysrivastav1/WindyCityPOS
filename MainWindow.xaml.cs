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

namespace WindyCityPOS
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //delete
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            //pick up
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            //options
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            //Calculator Button
            CalculatorWindow calculator = new CalculatorWindow();
            calculator.Show();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            //weather
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
           //records 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //new order
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            //drivers
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            //clear
        }
    }
}
