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
        //Строка подключения к бд из app.config
      public static string connectionString = ConfigurationManager.ConnectionStrings["CountryInf.Properties.Settings.CountryInfConnectionString"].ConnectionString.ToString();
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        SqlDataReader dataReader;
       
        
        public List<string> outCountry = new List<string>();// список строк с данными о стране
        SerchCountry serchCountry = new SerchCountry();

        #region Сохранение в бд
        public void SaveData(string name, string codeCountry, string capital, double area, int population, string region)
        {
            //
            //Передача параметров в ХП и вызов ХП
            //
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

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            Command_InsertCountry.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Данные успешно сохранены","Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Вывод из БД
        public List<String> OutCountry()
        {
            
            SqlCommand Command_OutputCountry = new SqlCommand();
            Command_OutputCountry.Connection = sqlConnection;
            Command_OutputCountry.CommandType = System.Data.CommandType.StoredProcedure;
            Command_OutputCountry.CommandText = "OutputCountry";

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            
            dataReader = Command_OutputCountry.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                        outCountry.Add(dataReader.GetValue(0).ToString());
                        outCountry.Add(dataReader.GetValue(1).ToString());
                        outCountry.Add(dataReader.GetValue(2).ToString());
                        outCountry.Add(dataReader.GetValue(3).ToString());
                        outCountry.Add(dataReader.GetValue(4).ToString());
                        outCountry.Add(dataReader.GetValue(5).ToString());
                }
            }
            dataReader.Close();
            sqlConnection.Close();
           return outCountry;
        }
        #endregion
    }
}
