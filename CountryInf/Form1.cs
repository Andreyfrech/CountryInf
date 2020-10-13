﻿using System;
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
        int i = 0;
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


            if (Convert.ToString(listViewCoutryInfo.Items[0].Text) != "")
            {

                
                DialogResult dialogResultSave = MessageBox.Show("Сохранить данные?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResultSave == DialogResult.Yes)
                {
                    ToolStripMenuItemSave_Click(sender, e);
                }
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

        public void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            //
            // Преобразование площади из string (записанная через точку) в double 
            //
            CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            double area = double.Parse(SerchCountry.result[3]);
            Thread.CurrentThread.CurrentCulture = temp_culture;

           // Сохранение данных в бд
             DataBase.SaveData(SerchCountry.result[0], SerchCountry.result[1], SerchCountry.result[2], area, Convert.ToInt32(SerchCountry.result[4]), SerchCountry.result[5]);
        }

        private void ToolStripMenuItemLoad_Click(object sender, EventArgs e)
        {
            DataBase.OutCountry();
            listViewCoutryInfo.Items.Clear();
            for (i = 0; i < DataBase.outCountry.Count ; i+=6)
            {
                ListViewItem item = listViewCoutryInfo.Items.Add(DataBase.outCountry[i]);
                item.SubItems.Add(DataBase.outCountry[i+1]);
                item.SubItems.Add(DataBase.outCountry[i+2]);
                item.SubItems.Add(DataBase.outCountry[i+3]);
                item.SubItems.Add(DataBase.outCountry[i+4]);
                item.SubItems.Add(DataBase.outCountry[i+5]);
            }
        }
    }
}
