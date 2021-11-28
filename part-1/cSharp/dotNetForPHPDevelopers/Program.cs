using System;

namespace dotNetForPHPDevelopers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables

            // This is an integer
            int numberOfHours = 12;

            // This is a string - Notice usage of Quotes 
            string firstName = "John";

            // This is a Char - Notice usage of single Quotes
            Char firstLetter = 'C';

            // These are booleans
            bool truthy = true;
            bool falsey = false;

            // This is a Float
            float tirePressure = 45.4f;

            // This is a double
            double decimalVal = 23.7;

            // These are arrays of things
            // Notice that the array type and size needs to be defined
            int[] agesList = new int[5]; // array of 5 integers
            bool[] flagsList = new bool[3] { true, false, true };

            // this is the usage of a class
            User theUser = new Person("John", "Doe", "eR4jADEWer2");

            var value = 2;
            // the row below will trigger an exception, if you uncomment it
            //value = "This is now a string";
            #endregion

            #region If Statements and conditions
            if (1 <= 3)
            {
                // execute if condition was met
            }
            else
            {
                // otherwise...
            }
            var result = 1 <= 3 ? "Option1" : "Option2";
            #endregion

            #region Loops

            // While
            var flag = true;
            while(flag == true)
            {
                // do something
                flag = false;
            }

            // do..while
            do
            {
                // do something
            } while (flag == true);

            // for
            for(int i = 0; i<= 10; i++)
            {
                // do something
            }

            // foreach
            string[] names = {"John", "Jane", "Bob"};
            
            foreach(string name in names)
            {
                // do something with name
            }

            #endregion

            #region OOP
            var person = new Person("John", "doe", "ksjdhfksdhfs");
            Console.WriteLine(person.GetToken());
            #endregion
        }
    }
}
