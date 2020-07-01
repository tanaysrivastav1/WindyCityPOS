using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for TakeOrder.xaml
    /// </summary>
    public partial class TakeOrder : Page
    {
        public TakeOrder()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        bool payButtonFlag = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //payment
            if (payButtonFlag)
            {
                payButtonFlag = false;
                //Side.Content = new Payment();
            }
            else
            {
                payButtonFlag = true;
                //Side.Content = null;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //customer editor
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //for here
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //pick up
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //delivery
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
