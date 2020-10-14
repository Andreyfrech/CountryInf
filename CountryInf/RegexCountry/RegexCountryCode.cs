using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountryInf.ClassRegexCountry
{
    //класс вывод кода страны
    class RegexCountryCode : SerchCountry, IRegex
    {
     
        public List<string> regex(string Page)
        {
            Match countryCode = Regex.Match(Page, ("(?<=\"alpha2Code\":\")[^\"]*"));// Регулярное выражение для вывода кода страны
             result.Add(Convert.ToString(countryCode));
            return result;        
        }
    }
    
}
