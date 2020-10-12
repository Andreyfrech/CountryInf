using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CountryInf
{
    public partial class FormMain : Form
    {
        //string sqlConnection = ConfigurationManager.ConnectionStrings["CountryInf.Properties.Settings.CountryInfConnectionString"].ConnectionString.ToString();

        SerchCountry SerchCountry = new SerchCountry();
        DataBase DataBase = new DataBase();
        public FormMain()
        {
            InitializeComponent();
     
        }
       
        private void buttonSerch_Click(object sender, EventArgs e)
        {
            
            
            SerchCountry.Serch(textBoxEnterCountry.Text);// Вызов метода Serch (поиск информации о введенной стране) 

            ///<summary>
            ///Вывод информации в ListView
            /// </summary>
            
            listViewCoutryInfo.Items.Clear();
            ListViewItem item = listViewCoutryInfo.Items.Add(SerchCountry.result[0]);
            item.SubItems.Add(SerchCountry.result[1]);
            item.SubItems.Add(SerchCountry.result[2]);
            item.SubItems.Add(SerchCountry.result[3]);
            item.SubItems.Add(SerchCountry.result[4]);
            item.SubItems.Add(SerchCountry.result[5]);
           
            DialogResult dialogResultSave = MessageBox.Show("Сохранить данные?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResultSave == DialogResult.Yes)
            {
                ToolStripMenuItemSave_Click(sender, e);
            }
        }

        private void textBoxEnterCountry_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEnterCountry.Text))
            {
                buttonSerch.Enabled = false;
            }
            else 
            {
                buttonSerch.Enabled = true;
            }
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            //
            // Преобразование площади из string (записанная через точку) в double 
            //
            CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            double area = double.Parse(SerchCountry.result[3]);
            Thread.CurrentThread.CurrentCulture = temp_culture;

           // DataBase.SaveData(d);
             DataBase.SaveData(SerchCountry.result[0], SerchCountry.result[1], SerchCountry.result[2], area, Convert.ToInt32(SerchCountry.result[4]), SerchCountry.result[5]);
        }
    }
}
