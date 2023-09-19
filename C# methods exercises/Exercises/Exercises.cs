using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__methods_exercises.Exercises
{
    internal class Exercises
    {
        public static string UserName() //**************EXERCISE 01***************
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
           
            return userName;
        }



        public static string Hashtag() //**************EXERCISE 02***************
        {
            Console.WriteLine("What hashtag would you like to create?");
            string word = Console.ReadLine();
            string hashtag = word.Insert(0, "#");
            
            return hashtag;
        }

        public static string Definition(string message) //**************EXERCISE 03***************
        {
            Console.WriteLine($"{message}");
            string definition = Console.ReadLine();

            return definition;
        }

        public static string Priority(string word) //**************EXERCISE 04***************
        {
            Console.WriteLine($"Please enter a {word}, this will determine the priority of your hashtag");
            string priority = Console.ReadLine();

            return priority;
        }

        public static string UserInfo(string firstName, string lastName) //**************EXERCISE 05***************
        {
            string userInfo = ($"{lastName}, {firstName}");
            Console.WriteLine(userInfo);

            return userInfo;
        }
    }
}
