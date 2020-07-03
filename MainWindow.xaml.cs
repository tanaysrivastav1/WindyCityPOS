using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
using WindyCityPOS.General;


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
            Main.Content = null;
            Main.Content = new TakeOrder();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            //drivers

            Main.Content = new DriversPage();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            //clear
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            
            
           
        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
