using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryController
    {
        List<Country> CountryDb = new List<Country>(); 
        
        
        public void CountryAction(Country c)
        {
            CountryView cc = new CountryView(c);
            cc.Display();
        }

        public void WelcomeAction()
        {
            CountryListView cl = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select from the following list: ");
            cl.Display();
            int input = int.Parse(Console.ReadLine());
            CountryAction(CountryDb[input]);

            Console.WriteLine("Would you like to learn about another country?");
        }
    }
}
