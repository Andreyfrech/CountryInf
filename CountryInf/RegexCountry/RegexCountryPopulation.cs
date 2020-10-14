using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountryInf.ClassRegexCountry
{
    //класс вывод население страны
    class RegexCountryPopulation : SerchCountry, IRegex
    {
        public List<string> regex(string Page)
        {
            Match countryPopulation = Regex.Match(Page, ("(?<=\"population\":)[^,]*"));// Регулярное выражение для вывода населения страны
            result.Add(Convert.ToString(countryPopulation));
            return result;
        }
    }
}
