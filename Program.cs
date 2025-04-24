using System;
using System.Security.Cryptography.X509Certificates;
using GetingStarted;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;

// This C# program prompts the user for their name and then greets them with the current date and time.
namespace GetingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConcatenateStrings.Sub(args);
            // Numbers.Sub2(args);
            Structures.Sub3(args);
            // Bucles.Sub4(args);
            // Functions.Sub5(args);
            // TheClass.Sub6(args);
        }
    }
    class ConcatenateStrings
    {
        public static void Sub(string[] args)
        {
            // This is a simple C# console application that prompts the user for their name
            // and then greets them with the current date and time.
            // The program will wait for the user to press Enter before exiting.

            // Prompt the user for their name
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            // string name = "Juan";

            // Get the current date and time
            var currentDate = DateTime.Now;
            var greetings = string.Empty;

            if (currentDate.Hour < 12)
            {
                greetings = "Good morning!";
            }
            else if (currentDate.Hour < 18)
            {
                greetings = "Good afternoon!";
            }
            else
            {
                greetings = "Good evening!";
            }

            // Greet the user with their name, current date, and time
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t} it means {greetings}!");

            const string myConst = "My const string";
            Console.WriteLine(myConst);

            // Wait for the user to press Enter before exiting
            Console.Write($"{Environment.NewLine}Press Enter to exit...");
            Console.ReadLine();
        }
    }

    class Numbers
    {
        public static void Sub2(string[] args)
        {
            int myInt = 10;
            float myFloat = 13.5f;
            double myDouble = 18.5;
            decimal myDecimal = 20.5m;
            decimal sum = myInt + (decimal)myFloat + (decimal)myDouble + myDecimal;
            Console.WriteLine($"The sum of {myInt}, {myFloat}, {myDouble}, and {myDecimal} is: {sum}");

            dynamic myDynamic = 10;
            myDynamic = "Now is String value";
            Console.WriteLine($"The value of myDynamic is: {myDynamic}");
            Console.ReadLine();
        }
    }

    class Structures
    {
        public static void Sub3(string[] args)
        {
            // use of arrays.
            string[] anArray = { "Juan", "Pedro", "Maria" };

            foreach (var name in anArray)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"The first value is: {anArray[0]}");

            // use of dictionaries.
            var myDictionary = new Dictionary<string, string>
            {
                { "Juan", "My name is Juan" },
                { "Pedro", "My name is Pedro" },
                { "Maria", "My name is Maria" }
            };
            foreach (var _ in myDictionary)
            {
                Console.WriteLine($"{_.Key}: {_.Value}");
            }
            Console.WriteLine($"The first value is: {myDictionary["Juan"]}");
            Console.WriteLine("----------------------------------");

            // <string, int>
            var myDictionary2 = new Dictionary<string, int>
            {
                { "Juan", 1 },
                { "Pedro", 2 },
                { "Maria", 3 }
            };
            foreach (var i in myDictionary2)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
            Console.WriteLine($"The first value is: {myDictionary2["Juan"]}");
            Console.WriteLine("----------------------------------");

            // <string, object>
            var myDictionary3 = new Dictionary<string, object>
            {
                { "Juan", 1 },
                { "Pedro", "My name is Pedro" },
                { "Maria", 3.5 }
            };
            foreach (var o in myDictionary3)
            {
                Console.WriteLine($"{o.Key}: {o.Value}");
            }
            Console.WriteLine($"The first value is: {myDictionary3["Juan"]}");
            Console.WriteLine("----------------------------------");

            // use Set
            var mySet = new HashSet<string>
            {
                "Juan",
                "Juan",
                "Pedro",
                "Maria",
                "Maria"
            };
            foreach (var name in mySet)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"The first value is: {mySet.ElementAt(0)}");
            Console.WriteLine("----------------------------------");

            // use of tuples.
            var myTuple = Tuple.Create("Juan", 1, 3.5);
            Console.WriteLine($"The first value is: {myTuple}");
            Console.WriteLine($"The first value is: {myTuple.Item1}");
            Console.ReadLine();
        }
    }

    class Bucles
    {
        public static void Sub4(string[] args)
        {
            // use of for loop.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i is: {i}");
            }
            Console.WriteLine("----------------------------------");

            // use of while loop.
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"The value of j is: {j}");
                j++;
            }
            Console.WriteLine("----------------------------------");

            // use of do while loop.
            int k = 0;
            do
            {
                Console.WriteLine($"The value of k is: {k}");
                k++;
            } while (k < 10);
            Console.ReadLine();
        }
    }

    class Functions
    {
        public static void Sub5(string[] args)
        {
            MyFunction();
            Console.ReadLine();
        }
        // use of functions.
        static void MyFunction()
        {
            Console.WriteLine($"The sum is: {Sum(1, 2, 3, 4)}");
        }
        static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }

    class TheClass
    {
        public string myName { get; set; }
        public int myAge { get; set; }
        public string myAddress { get; set; }

        public static void Sub6(string[] args)
        {
            // use of classes.
            var myClass = new TheClass("Juan", 23, "Cra, 123 # 45 - 67");
            Console.WriteLine($"The name is: {myClass.myName}");
            Console.WriteLine($"The age is: {myClass.myAge}");
            Console.WriteLine($"The address is: {myClass.myAddress}");
            Console.ReadLine();
        }
        public TheClass(string name, int age, string address)
        {
            myName = name;
            myAge = age;
            myAddress = address;
        }
    }
}