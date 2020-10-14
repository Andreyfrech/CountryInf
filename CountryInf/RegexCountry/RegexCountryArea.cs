using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountryInf.ClassRegexCountry
{
    //Класс вывод площади
    class RegexCountryArea : SerchCountry, IRegex
    {
        public List<string> regex(string Page)
        {
            Match countryArea = Regex.Match(Page, ("(?<=\"area\":)[^,]*"));// Регулярное выражение для вывода площади страны
            result.Add(Convert.ToString(countryArea));
            return result;
        }
    }
}
