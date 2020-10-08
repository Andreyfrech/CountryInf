using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CountryInf
{
    public partial class FormMain : Form
    {
       
        public FormMain()
        {
            InitializeComponent();
     
        }
       
        private void buttonSerch_Click(object sender, EventArgs e)
        {
            
            SerchCountry SerchCountry = new SerchCountry();
            SerchCountry.Serch(textBoxEnterCountry.Text);// Вызов метода Serch (поиск информации о введенной стране) 


            listViewCoutryInfo.Items.Clear();
            ListViewItem item = listViewCoutryInfo.Items.Add(SerchCountry.result[0]);
            item.SubItems.Add(SerchCountry.result[1]);
            item.SubItems.Add(SerchCountry.result[2]);
            item.SubItems.Add(SerchCountry.result[3]);
            item.SubItems.Add(SerchCountry.result[4]);
            item.SubItems.Add(SerchCountry.result[5]);

        }
    }
}
