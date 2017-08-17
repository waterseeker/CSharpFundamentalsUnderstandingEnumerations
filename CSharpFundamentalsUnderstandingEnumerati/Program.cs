using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsUnderstandingEnumerati
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray; //changes color of the font in the console
            Console.BackgroundColor = ConsoleColor.DarkGreen; //highlight color around the text in the console
      

            Console.Title = "Welcome to the friggin' console."; //set title of console window

            //Console.WriteLine("Hello world!");


            Console.WriteLine("Type in a superhero's name to see his nickname: ");
            string userValue = Console.ReadLine();

            SuperHero myValue;

            //try to convert user input into an enum from a string
            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))

                //3 params in tryparse
                //userValue is what you are evaluating
                //true is whether we are going to ignore capitalization
                //out myValue  the output paramater that is sent from the method to the caller. This differes from 
                        //a return statement in that the out will return the result of the operation (true or false in this case) and also
                        //the value of the output param (in this case the value of myValue)
            {

                switch (myValue)
                {
                    case SuperHero.Batman:
                        break;
                    case SuperHero.Superman:
                        break;
                    case SuperHero.GreenLantern:
                        break;
                    default:
                        break;
                }

            }



            Console.ReadLine();
        }
    }

    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }

}
