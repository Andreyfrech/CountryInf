using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountryInf.ClassRegexCountry
{
    //класс вывод региона
    class RegexCountryRegion : SerchCountry, IRegex
    {
        public List<string> regex(string Page)
        {
            Match countryRegion = Regex.Match(Page, ("(?<=\"region\":\")[^\"]*"));// Регулярное выражение для вывода региона страны
            result.Add(Convert.ToString(countryRegion));
            return result;
        }
    }
}
