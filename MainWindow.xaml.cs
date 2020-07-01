using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            //FillDataGrid();
        }

        private void LoadAllSizesinDataGridView()
        {
           //SizesDataGridView.ItemsSource = GetSizesData().DefaultView;
            //remove visibility of ID numbers
            //SizesDataGridView.Columns[0].Visible = false;

        }

        //GetSizesData returns the datatable from SQL
        private DataTable GetSizesData()
        {
            //NOTE: compiler will through nullpointer error if datatable is null, so create an object

            DataTable dtsizes = new DataTable();

            //get and store the datatable through sql connection -> applicationsetting.cs
            using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
            {
                //runs sql command usp load pizzas (see .txt file)
                using (SqlCommand cmd = new SqlCommand("usp_Pizzas_LoadAllItems", con))
                {
                    //load procedure and given params
                     cmd.CommandType = CommandType.StoredProcedure;
                    
                    
                     cmd.Parameters.AddWithValue("@main_identifier", 1);
                   
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //read data then load into dtsizes datatable
                    dtsizes.Load(sdr);
                }
            }
            return dtsizes;
        }

        private void FillDataGrid()
        {
            LoadAllSizesinDataGridView();
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
    }
}
