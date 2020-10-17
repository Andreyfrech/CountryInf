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
        int i = 0;//счетчик в цикле
        SerchCountry SerchCountry = new SerchCountry();
        DataBase DataBase = new DataBase();
        public FormMain()
        {
            InitializeComponent();
     
        }
        //Очистка listview
        public void ListViewClear()
        {
            listViewCoutryInfo.Items.Clear();
        }
        private void buttonSerch_Click(object sender, EventArgs e)
        {
             ListViewClear();


            SerchCountry.Serch(textBoxEnterCountry.Text);// Вызов метода Serch (поиск информации о введенной стране) 

            //
            //Вывод информации в ListView
            // 
            
           
            try
            {
                for (i = 0; i < 6; i += listViewCoutryInfo.Columns.Count)
                {
                    ListViewItem item = listViewCoutryInfo.Items.Add(SerchCountry.result[i]);
                    item.SubItems.Add(SerchCountry.result[i+1]);
                    item.SubItems.Add(SerchCountry.result[i+2]);
                    item.SubItems.Add(SerchCountry.result[i+3]);
                    item.SubItems.Add(SerchCountry.result[i+4]);
                    item.SubItems.Add(SerchCountry.result[i+5]);
                }
                // Вывод сообщения сохранять данные или нет
            if (Convert.ToString(listViewCoutryInfo.Items[0].Text) != "")
            {

                
                DialogResult dialogResultSave = MessageBox.Show("Сохранить данные?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResultSave == DialogResult.Yes)
                {
                    ToolStripMenuItemSave_Click(sender, e);
                }
            }
            }
            catch { }
        }
        // Запрет поиска если textBoxEnterCountry пуст
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
        //Пункт меню сохранить данные
        public void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            if (listViewCoutryInfo.Items.Count == 1)
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
        }
        //Пункт меню вывод всех стран
        private void ToolStripMenuItemLoad_Click(object sender, EventArgs e)
        {
            DataBase.OutCountry();//вывод всех стран
            listViewCoutryInfo.Items.Clear();
            //добавление всех стран в listView
            for (i = 0; i < DataBase.outCountry.Count ; i+=listViewCoutryInfo.Columns.Count)
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
