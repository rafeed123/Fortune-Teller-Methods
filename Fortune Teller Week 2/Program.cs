using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_Week_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the fortune teller application you can EXIT anytime by entering \"QUIT\" or RESTART by entering \"RESTART\" ");
            Console.WriteLine("\n");
            Console.WriteLine("If you want to know your future please enter your first name.");

            string firstName = Console.ReadLine();

            if (firstName.ToLower() == "quit")
                Quit();

            if (firstName.ToLower() == "restart")
                Main(args);



            Console.WriteLine("Thank you " + firstName + "." + " Now please enter your last name.");

            string lastName = Console.ReadLine();

            if (lastName.ToLower() == "quit")
                Quit();

            if (lastName.ToLower() == "restart")
                Main(args);



            Console.WriteLine(Greetings(firstName, lastName));



            Console.WriteLine("Now please enter your age.");

            string ageStr = Console.ReadLine();



            if (ageStr.ToLower() == "quit")
                Quit();

            if (ageStr.ToLower() == "restart")
                Main(args);
            int age = int.Parse(ageStr);



            Console.WriteLine("Now that I know your age tell me what month you were born using a number.");
            string birthMonthStr = Console.ReadLine();
            if (birthMonthStr.ToLower() == "quit")
                Quit();

            if (birthMonthStr.ToLower() == "restart")
                Main(args);

            int birthMonth = int.Parse(birthMonthStr);


            Console.WriteLine("Now can you tell me you favorite ROYGBIV color, If you dont know what colors are in ROYGBIV enter help.");

            string yourClr = Console.ReadLine();
            yourClr = yourClr.ToLower();
            if (yourClr.ToLower() == "quit")
                Quit();

            if (yourClr.ToLower() == "restart")
                Main(args);
            if (yourClr == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                Console.WriteLine("Now enter your favorite ROYGBIV color.");
                yourClr = Console.ReadLine();
                if (yourClr.ToLower() == "quit")
                    Quit();

                if (yourClr.ToLower() == "restart")
                    Main(args);
            }



            Console.WriteLine("How many siblings you have");
            string sibsStr = Console.ReadLine();
            if (sibsStr.ToLower() == "quit")
                Quit();

            if (sibsStr.ToLower() == "restart")
                Main(args);
            int siblings = int.Parse(sibsStr);


            Console.WriteLine(firstName + " " + lastName + "you will retire in " + TimeUntillRetire(age) + " years with $" + RetirementFunds(birthMonth) + "K in the bank, a vacation home in " + RetireDestination(siblings) + " and you will drive a " + RetireVehicle(yourClr));
            Console.WriteLine("\n");


            Judgement();

        }

        //Methods used for recalling ones future


        static void Judgement()
        {
            Console.WriteLine("Wow looks like an interesting life ahead of you!");
        }

        static void Quit()
        {
            Environment.Exit(0);
        }

        static double RetirementFunds(int birthMonth)
        {
            double money;

            if (birthMonth == 1 - 4)
            {
                money = 25;
            }
            if (birthMonth == 5 - 8)
            {
                money = 50;
            }
            if (birthMonth == 9 - 12)
            {
                money = 100;
            }
            else
            {
                money = 10;
            }

            return money;
        }

        static string RetireVehicle(string yourClr)
        {

            string vehicle = "";

            if (yourClr == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                yourClr = Console.ReadLine();
            }

            switch (yourClr.ToLower())
            {
                case "red":
                    vehicle = ("red Ferrari");
                    break;
                case "orange":
                    vehicle = (" Audi");
                    break;
                case "yellow":
                    vehicle = ("Benz");
                    break;
                case "green":
                    vehicle = ("BMW");
                    break;
                case "blue":
                    vehicle = ("Hummer");
                    break;
                case "indigo":
                    vehicle = ("Jeep");
                    break;
                case "violet":
                    vehicle = ("Ford fiesta");
                    break;
            }

            return vehicle;
        }

        static string RetireDestination(int siblings)
        {

            string vacHome = "";


            if (siblings == 0)
            {
                vacHome = ("Paris");
            }
            if (siblings == 1)
            {
                vacHome = ("Bahamas");
            }
            if (siblings == 2)
            {
                vacHome = ("Belize");
            }
            if (siblings == 3)
            {
                vacHome = ("Costa Rica");
            }
            if (siblings > 3)
            {
                vacHome = ("Florida");
            }
            else if (siblings < 0)
            {
                vacHome = ("Prison");
            }


            return vacHome;

        }

        static int TimeUntillRetire(int age)
        {
            int ageResult;
            if (age % 2 == 0)
            {
                ageResult = 10;
            }
            else
            {
                ageResult = 20;
            }


            int TimeUntillRetire = ageResult;
            return TimeUntillRetire;
        }

        static string Greetings(string fName, string lName)
        {
            string Greetings = ("Greetings " + fName + " " + lName + " I will tell you your future.");

            return Greetings;
        }




    }
}


















