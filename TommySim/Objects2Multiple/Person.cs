﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects2Multiple
{
    class Person
    {
        private City homeCity;
        public string name { get; set; }
        static private Random rng = new Random();

        public Person(String name, City homeCity)
        {
            this.name = name;
            this.homeCity = homeCity;
        }

        public Person(City homeCity)
        {
            Console.Write("Name your new villager!: ");
            this.name = Console.ReadLine();
            Console.WriteLine();
            this.homeCity = homeCity;
        }

        public void Work()
        {
            Console.WriteLine();
            Console.WriteLine("Time for peon "+name+" to go to Work!");
            Console.WriteLine("Assign "+name+" a task:");
            Console.WriteLine("1) Chop Wood");
            Console.WriteLine("2) Get Water");
            Console.WriteLine("3) Get Food");
            Console.WriteLine("4) Build a house (Requires 5 wood)");
            Console.WriteLine("5) Build a well (Gives 1 gallon of water per day -- Requires 6 wood)");
            Console.WriteLine("6) Scavenge (find random resource)\n");
            Console.Write("What task shall peon " + name + " work on today?: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ChopWood();
                    break;
                case "2":
                    findWater();
                    break;
                case "3":
                    findFood();
                    break;
                case "4":
                    BuildHouse();
                    break;
                case "5":
                    BuildWell();
                    break;
                case "6":
                    Scavenge();
                    break;
                default:
                    Console.WriteLine("I'm sorry I didn't understand, let's try again");
                    Work();
                    break;
            }
        }

        public void ChopWood()
        {
            homeCity.IncreaseWood();
            homeCity.printWood();
            homeCity.Pause();
        }
        public void ChopWood(int amount)
        {
            homeCity.IncreaseWood(amount);
            homeCity.printWood();
            homeCity.Pause();
        }

        public void findWater()
        {
            int amount = rng.Next(1, 4);
            Console.WriteLine(name + " found " + amount + " gallons of water");
            homeCity.water+= amount;
            homeCity.printWater();
            homeCity.Pause();
        }

        public void findWater(int amount)
        {
            Console.WriteLine(name + " found " + amount + " gallons of water");
            homeCity.water += amount;
            homeCity.printWater();
            homeCity.Pause();
        }

        public void findFood()
        {
            int amount = rng.Next(1, 4);
            Console.WriteLine(name + " found " + amount + " buschels of food");
            homeCity.food += amount;
            homeCity.printFood();
            homeCity.Pause();
        }

        public void findFood(int amount)
        {
            Console.WriteLine(name + " found " + amount + " buschels of food");
            homeCity.food += amount;
            homeCity.printFood();
            homeCity.Pause();
        }

        public void BuildHouse()
        {
            homeCity.BuildHouse();
            homeCity.Pause();
        }

        public void BuildWell()
        {
            homeCity.BuildWell();
            homeCity.Pause();
        }

        public void Scavenge()
        {
            string[] resources = { "wood", "water", "watersource","nothing","nothing","death" };
            int r = rng.Next(resources.Count());
            string choice = resources[r];
            int amount = rng.Next(2, 6);
            //Console.WriteLine(choice);
            switch (choice)
            {
                case "wood":
                    Console.WriteLine(name + " found " + amount + " " + choice);
                    ChopWood(amount);
                    break;
                case "water":
                    Console.WriteLine(name + " found " + amount + " " + choice);
                    findWater(amount);
                    break;
                case "food":
                    Console.WriteLine(name + " found " + amount + " " + choice);
                    findFood(amount);
                    break;
                case "nothing":
                    Console.WriteLine(name + " found nothing");
                    break;
                case "death":
                    Console.WriteLine(name + " died");
                    homeCity.killPerson(this);
                    break;
                default:
                    Scavenge();
                    break;

            }

        }

        public bool Drink()
        {
            bool survive;
            if (homeCity.water > 0)
            {
                survive = true;
                homeCity.water--;
                Console.WriteLine(name + " drinks 1 water");
            }
            else
            {
                survive = false;
                Console.WriteLine(name + " couldn't find a drink! They died of thirst!");
            }
            return survive;
        }

        public bool Eat()
        {
            bool survive;
            if (homeCity.food > 0)
            {
                survive = true;
                homeCity.food--;
                Console.WriteLine(name + " eat's 1 buschel of food");
            }
            else
            {
                survive = false;
                Console.WriteLine(name + " couldn't find food! They died of hunger!");
            }
            return survive;
        }
    }
}