using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryInf 
{
    class DataBase 
    {
      public static string connectionString = ConfigurationManager.ConnectionStrings["CountryInf.Properties.Settings.CountryInfConnectionString"].ConnectionString.ToString();
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        //public static string connectionString = ConfigurationManager.ConnectionStrings["CountryInf"].ConnectionString;

        SerchCountry serchCountry = new SerchCountry();
        public void SaveData(string name, string codeCountry, string capital, double area, int population, string region)
        {
            SqlCommand Command_InsertCountry = new SqlCommand();
            Command_InsertCountry.Connection = sqlConnection;
            Command_InsertCountry.CommandType = System.Data.CommandType.StoredProcedure;
            Command_InsertCountry.CommandText = "InsertCountry";
            Command_InsertCountry.Parameters.Add("@Country", SqlDbType.VarChar);
            Command_InsertCountry.Parameters["@Country"].Value = name;
            Command_InsertCountry.Parameters.Add("@CountryCode", SqlDbType.VarChar);
            Command_InsertCountry.Parameters["@CountryCode"].Value = codeCountry;
            Command_InsertCountry.Parameters.Add("@Capital", SqlDbType.VarChar);
            Command_InsertCountry.Parameters["@Capital"].Value = capital;
            Command_InsertCountry.Parameters.Add("@Area", SqlDbType.Float);
            Command_InsertCountry.Parameters["@Area"].Value = area;
            Command_InsertCountry.Parameters.Add("@Population", SqlDbType.Int);
            Command_InsertCountry.Parameters["@Population"].Value = population;
            Command_InsertCountry.Parameters.Add("@Region", SqlDbType.VarChar);
            Command_InsertCountry.Parameters["@Region"].Value = region;
            sqlConnection.Open();

            Command_InsertCountry.ExecuteNonQuery();
            //MessageBox.Show(Convert.ToString(area));// + " " + codeCountry + " " + capital + " " + area + " " + population);// + " " + region);

        }
    }
}
