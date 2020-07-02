using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using WindyCityPOS.General;

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
            //LoadAllSizesinDataGridView();

            SqlConnection con = new SqlConnection("Data Source=windycityserver.database.windows.net;Initial Catalog=food;Persist Security Info=True;User ID=webappAdmin;Password=appAdmin2001");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select main_identifier, main_name from main_cata", con);
            SqlDataReader data = cmd.ExecuteReader();
            //LoadButton
            for (int i = 1; i < 12; i++)
            {

                while (data.Read())
                {
                    Button b = new Button();
                    b.Name = data.GetValue(i).ToString();
                    b.Content = data.GetValue(i).ToString();
                    //b.HorizontalAlignment = HorizontalAlignment.Left;
                    b.Width = 125;
                    b.Height = 50;
                    //b.Margin = (20, 0, 0, 0);
                    b.FontSize = 22;
                    //add buttons to the stack panel
                    sp.Children.Add(b);


                }
            }
            con.Close();

        }

        //Create property boolean to update the form
        public bool IsUpdate { get; set; }

        //Create a list using integer type
        private List<int> SizesCart = new List<int>();

        private void PizzaForm_Load(object sender, EventArgs e)
        {
            if (!this.IsUpdate)
            {
                //Not updated

            }
            LoadAllSizesinDataGridView();
            //LoadDataIntoComboBoxes();

        }

        //LoadAllSizes loads data into sizesdatagridview
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
            using (SqlCommand cmd = new SqlCommand("usp_Pizzas_LoadAllPizzas", con))
            {
            
                        //load procedure and given params
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@main_identifier", 11);

                        con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                        dtsizes.Load(sdr);
                //read data then load into dtsizes datatable
            }
        }
            return dtsizes;
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

        private void SizesDataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OrderNumberTxtBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            //Order Number Textbox
            SqlConnection con = new SqlConnection("Data Source=windycityserver.database.windows.net;Initial Catalog=customers;Persist Security Info=True;User ID=webappAdmin;Password=appAdmin2001");
            con.Open();
            if (OrderNumberTxtBox.Text != "")
            {

                SqlCommand cmd = new SqlCommand("Select OrderType, Phone, Name, Address from Orders where ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(OrderNumberTxtBox.Text));
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    OrderTypeTxtBox.Text = data.GetValue(0).ToString();
                    PhoneNumberTxtBox.Text = data.GetValue(1).ToString();
                    NameTxtBox.Text = data.GetValue(2).ToString();
                    AddressTxtBox.Text = data.GetValue(3).ToString();

                }
                con.Close();
            }

        }

        private void OrderTypeTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Order Type TextBox
        }

        private void PhoneNumberTxtBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            //Phone Number TextBox
        }

        private void NameTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Name TextBox
        }

        private void AddressTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Address Ttext box
        }
    }
}
