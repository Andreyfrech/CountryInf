using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountryInf.ClassRegexCountry
{
    //класс вывод столицы
    class RegexCountryCapital : SerchCountry, IRegex
    {
        public List<string> regex(string Page)
        {
            Match countryCapital = Regex.Match(Page, ("(?<=\"capital\":\")[^\"]*"));// Регулярное выражение для вывода столицы страны
            result.Add(Convert.ToString(countryCapital));
            return result;
        }
    }
}
