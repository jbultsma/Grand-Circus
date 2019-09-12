using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryListView
    {
        public List<Country> Countries;

        public CountryListView(List<Country> countriesList)
        {
            this.Countries = countriesList;
        }

        public void Display()
        {
            int i = 0;
            foreach (var country in Countries)
            {
                Console.WriteLine($"{i} {country}");
                i++;
            }
        }
    }
}
