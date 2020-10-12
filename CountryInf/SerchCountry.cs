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
     
       // FormMain formMain = new FormMain();

        public string[] result = new string[6] ;// массив строк с данными о стране
        public string[] Serch(string country)
        {
            
            WebClient wc = new WebClient();
            string Page = wc.DownloadString("https://restcountries.eu/rest/v2/name/" + country); //Скачивание странницы с нужной странной

            Match countryName = Regex.Match(Page, ("(?<=\"name\":\")[^\"]*"));// Регулярное выражение для вывода названия страны
            Match countryCode = Regex.Match(Page, ("(?<=\"alpha2Code\":\")[^\"]*"));// Регулярное выражение для вывода кода страны
            Match countryCapital = Regex.Match(Page, ("(?<=\"capital\":\")[^\"]*"));// Регулярное выражение для вывода столицы страны
            Match countryArea = Regex.Match(Page, ("(?<=\"area\":)[^,]*"));// Регулярное выражение для вывода площади страны
            Match countryPopulation = Regex.Match(Page, ("(?<=\"population\":)[^,]*"));// Регулярное выражение для вывода населения страны
            Match countryRegion = Regex.Match(Page, ("(?<=\"region\":\")[^\"]*"));// Регулярное выражение для вывода региона страны
            
            result[0] = Convert.ToString(countryName);
            result[1] = Convert.ToString(countryCode);
            result[2] = Convert.ToString(countryCapital);
            result[3] = Convert.ToString(countryArea);
            result[4] = Convert.ToString(countryPopulation);
            result[5] = Convert.ToString(countryRegion);
             return result;

          
        }
       
    }
}
