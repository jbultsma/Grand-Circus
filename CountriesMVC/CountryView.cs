using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryView
    {
        public Country DisplayCountry;
        public CountryView(Country name)
        {
            this.DisplayCountry = name;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nColors: {DisplayCountry.Colors}");
        }
    }
}
