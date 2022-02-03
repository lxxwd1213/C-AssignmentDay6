//Playing with Console App
using System;
namespace _01Introduction
{
    class Program
    {
        public static void Main(String[] args)
        {
            //1. Modify your console application to display a different message.
            Console.WriteLine("Welcome to C#!");
            //2. Add some mistakes to your program,
            //so you can see what kinds of error messages you get fromt the compiler.
            //2.1
            //int a = 10;
            //int b = 0;
            //Console.WriteLine("Division = " + (a / b));
            //2.2
            //int x = 10.1;
            //2.3
            //int y = NULL;
            //3. Using just the ReadLine and WriteLine methods and your current knowledge of variables,
            //you can have the user pass in quite a few bits of information.

            //String userName = null;
            //int passWord = 0;

            //Console.WriteLine("Please enter the User Name:");
            //userName = Console.ReadLine();
            //Console.WriteLine(userName);

            //Console.WriteLine("Please enter the password:");
            //passWord = Convert.ToInt32 (Console.ReadLine());
            //Console.WriteLine(passWord);

            //4. Using this approach, create a console application that asks the user a few questions
            //and then generates some custom  output for them.

            //String color = null;
            //String astrologySign = null;
            //int streetAddress = 0;

            //Console.WriteLine("Please enter your favorite color.");
            //color = Console.ReadLine();
            //Console.WriteLine("Please enter your astrology sign.");
            //astrologySign = Console.ReadLine();
            //Console.WriteLine("Please enter you street address number.");
            //streetAddress = Convert.ToInt32 (Console.ReadLine());

            //Console.WriteLine("Your hacker name is " + color + astrologySign + streetAddress);
        }
    }
}