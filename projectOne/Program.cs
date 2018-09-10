using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ask + gets first name
            Console.WriteLine("Let's begin! What is your first name?");
            string firstName = Console.ReadLine();
         
            //asks + gets last name
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            //asks + gets age
            Console.WriteLine("What is your age? (Please enter as an int)");
            int age = int.Parse(Console.ReadLine());

            //asks + gets birth month
            Console.WriteLine("What month were you born? (Please enter as an int: month 1 - 12)");
            int birthMonth = int.Parse(Console.ReadLine());

            //asks favorite color + gets color or help
            Console.WriteLine("What is your favorite ROYGBIV color? (To expand the accronym, type Help)");
            string color = Console.ReadLine().ToLower();

            //if gets help: types out ROYGBIV accronym, then asks + gets favorite color
            if (color == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet. Which of these colors is your favorite?");
                color = Console.ReadLine().ToLower();
            }
            
            //asks + gets number of siblings
            Console.WriteLine("How many siblings do you have? (Please enter as an int)");
            int siblings = int.Parse(Console.ReadLine());


            //Logic requirement variables
            int untilRetire;
            string vacationHome;
            string transportation;
            double bankMoney = 10000;

            //age is determined as even or odd, and then determines years until retirement
            if (age % 2 == 0)
            {
                untilRetire = 13;
            }
            else
            {
                untilRetire = 5;
            }
            
            //number of siblings determines vacation home
            if (siblings < 0)
            {
                vacationHome = "Pittsburgh";
            }
            else if (siblings == 0)
            {
                vacationHome = "Myrtle Beach";
            }
            else if (siblings == 1)
            {
                vacationHome = "West Palm Beach";
            }
            else if (siblings == 2)
            {
                vacationHome = "Nashville";
            }
            else if (siblings == 3)
            {
                vacationHome = "New York City";
            }
            else
            {
                vacationHome = "Cleveland";
            }


            //color input determines transportation
            switch (color)
            {
                case "red":
                    transportation = "Harley Davidson";
                    break;

                case "orange":
                    transportation = "minivan";
                    break;

                case "yellow":
                    transportation = "bicycle";
                    break;

                case "green":
                    transportation = "Mustang";
                    break;

                case "blue":
                    transportation = "Ford truck";
                    break;

                case "indigo":
                    transportation = "Ferrari";
                    break;

                case "violet":
                    transportation = "Prius";
                    break;

                default:
                    transportation = "donkey";
                    break;
            }

            //birth month grouping (months 1-4, 5-8, 9-12) determines how much money is in the bank                     
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankMoney *= 11;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankMoney += 50000;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankMoney /= 2;
            }
            else
            {
                bankMoney = 0;
            }

            //gives forturne to user based on the user inputs
            Console.WriteLine("{0} {1} will retire in {2} with {3} in the bank, a vacation home in {4}, and a {5}.", firstName, lastName, untilRetire, bankMoney, vacationHome, transportation);
                                 
        }
    }
}
