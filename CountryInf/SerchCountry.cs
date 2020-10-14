using CountryInf.ClassRegexCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CountryInf
{
    
    class  SerchCountry 
    {
       
        public string Page { get; set; }
      
       public  List<string> result = new List<string>(); // массив строк с данными о стране
       
        //Поиск информации о стране
        public List<string> Serch(string country)
        {
            RegexCountryName regexCountryName = new RegexCountryName();
            RegexCountryCode regexCountryCode = new RegexCountryCode();
            RegexCountryCapital regexCountryCapital = new RegexCountryCapital();
            RegexCountryArea regexCountryArea = new RegexCountryArea();
            RegexCountryPopulation regexCountryPopulation = new RegexCountryPopulation();
            RegexCountryRegion regexCountryRegion = new RegexCountryRegion();
            

            WebClient wc = new WebClient();
            try
            {
                 Page = wc.DownloadString("https://restcountries.eu/rest/v2/name/" + country); //Скачивание странницы с нужной странной
                //Вывод информации о стране в List
                result =  regexCountryName.regex(Page).Concat(regexCountryCode.regex(Page)).Concat(regexCountryCapital.regex(Page)).Concat(regexCountryArea.regex(Page)).Concat(regexCountryPopulation.regex(Page)).Concat(regexCountryRegion.regex(Page)).ToList();   
            }
            
            catch
            {
                //Очистка List и вывод сообщения, что страна не найдена
                result.Clear();
                MessageBox.Show("Страна " + country + " не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            return result;


        }
       
    }
}
