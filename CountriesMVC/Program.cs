using System;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CountryController c = new CountryController();
            c.WelcomeAction();
        }
    }
}
