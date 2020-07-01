using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindyCityPOS.General
{
    public class ApplicationSetting
    {
        //Returns connection string from the app config
        //Only needs to be changed here in this class since it is public
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            //provides access to configuration files for the client application (app.config)
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
                using (SqlCommand cmd = new SqlCommand("usp_Pizzas_LoadAllPizzas", con))
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
    }
}