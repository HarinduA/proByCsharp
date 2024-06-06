using System;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser(); // This is a Method
            string name = GetUserInput(); // Calling to method and returning the string value
            DisplayGreeting(name); // Calling to a method by string value
            var result = PerformCalculation();
            DisplayResults(result.Item1, result.Item2);
            DisplayFarewell();
            Invoice Myinvoice = new Invoice ();
            Myinvoice.Disiplayinvoiceamount(name);
            
        }

        static void GreetUser()
        {
            Console.WriteLine("Welcome to the OOP Example Program!");
        }

        static string GetUserInput()
        {
            Console.Write("Enter your name: ");
            return Console.ReadLine();
        }

        static void DisplayGreeting(string name)
        {
            string greetingMessage = "Hello, " + name + "!";
            Console.WriteLine(greetingMessage);
        }

        static void DisplayFarewell()
        {
            Console.WriteLine("Thank you for using the OOP Example Program!");
        }

        static Tuple<int, double> PerformCalculation()
        {
            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;
            double average = sum / 3.0;

            return Tuple.Create(sum, average);
        }

        static void DisplayResults(int sum, double average)
        {
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
        }
    }
}