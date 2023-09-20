// See https://aka.ms/new-console-template for more information

using C__methods_exercises.Exercises;

string userName = Exercises.UserName();

string hashtag = Exercises.Hashtag();

string definition = Exercises.Definition("What is the hashtag about?");

string priority = Exercises.Priority("number");

string userInfo = Exercises.UserInfo($"{userName}", "See you");
Console.WriteLine(userInfo);
