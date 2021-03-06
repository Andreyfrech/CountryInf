﻿using System;
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

        int countCity, countRegion, countCountry;

        public void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        #region Сохранение в бд
        public void SaveCity (string capital)
        {
            //Проверка на наличие города
            string sqlCountCity = string.Format("SELECT Count(*) from Города where Города.Название = @Capital");
            //Вставка города
            string sqlInsertCity = string.Format("insert into Города (Города.Название) values (@Capital)");

            OpenConnection();
            SqlCommand Command_CountCity = new SqlCommand(sqlCountCity, sqlConnection);

            Command_CountCity.Parameters.Add("@Capital", SqlDbType.VarChar);
            Command_CountCity.Parameters["@Capital"].Value = capital;

            countCity = Convert.ToInt32(Command_CountCity.ExecuteScalar());

            SqlCommand Command_InsertCity = new SqlCommand(sqlInsertCity, sqlConnection);

            Command_InsertCity.Parameters.Add("@Capital", SqlDbType.VarChar);
            Command_InsertCity.Parameters["@Capital"].Value = capital;

            if (countCity == 0)
            {
                Command_InsertCity.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }

        public void SaveRegion(string region)
        {
            OpenConnection();
            //Проверка на наличие региона
            string sqlCountRegion = string.Format("Select Count(*) from Регионы where Название = @Region");
            //Вставка региона
            string sqlInsertRegion = string.Format("insert into Регионы (Регионы.Название) values (@Region)");

            SqlCommand Command_CountRegion = new SqlCommand(sqlCountRegion, sqlConnection);

            Command_CountRegion.Parameters.Add("@Region", SqlDbType.VarChar);
            Command_CountRegion.Parameters["@Region"].Value = region;

            countRegion = Convert.ToInt32(Command_CountRegion.ExecuteScalar());
            SqlCommand Command_InsertRegion = new SqlCommand(sqlInsertRegion, sqlConnection);
            Command_InsertRegion.Parameters.Add("@Region", SqlDbType.VarChar);
            Command_InsertRegion.Parameters["@Region"].Value = region;

            if (countRegion == 0)
            {
                Command_InsertRegion.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }
        public void SaveCountry(string name, string codeCountry, string capital, double area, int population, string region)
        {
            //Проверка на наличие страны
            string sqlCountCountry = string.Format("SELECT count(*) from Страны where [Код страны] = @CountryCode");
            //Вставка страны
            string sqlInsertCountry = string.Format("insert into Страны (Страны.Название, [Код страны], Столица, Площадь, Население, Регион) values (@Country, @CountryCode, (select id from Города where Название = @Capital), @Area, @Population, (select id from Регионы where Название = @Region))");
            //Обновление страны
            string sqlUpdateCountry = string.Format("Update Страны set Название = @Country, [Код страны] = @CountryCode, Столица = (select id from Города where Название = @Capital), Площадь = @Area, Население = @Population, Регион = (select id from Регионы where Название = @Region) 	where [Код страны] = @CountryCode");

           
            SqlCommand Command_CountCountry = new SqlCommand(sqlCountCountry, sqlConnection);
            Command_CountCountry.Parameters.Add("@CountryCode", SqlDbType.VarChar);
            Command_CountCountry.Parameters["@CountryCode"].Value = codeCountry;

          
          countCountry = Convert.ToInt32(Command_CountCountry.ExecuteScalar());
           
            SqlCommand Command_InsertCountry = new SqlCommand();
            if (countCountry == 0)
            {
                 Command_InsertCountry = new SqlCommand(sqlInsertCountry, sqlConnection);
            }
            else
            {
                Command_InsertCountry = new SqlCommand(sqlUpdateCountry, sqlConnection);
            }
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
