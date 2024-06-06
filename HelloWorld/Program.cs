using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the OOP Example Program!");

      Console.Write("Enter your name: "); 
      string name = Console.ReadLine();

      string greetingMessage = "Hello, " + name + "!"; 
      Console.WriteLine(greetingMessage);

      Console.Write("Enter number 1: "); 
      int num1 = int.Parse(Console.ReadLine());

      Console.Write("Enter number 2 : "); 
      int num2 = int.Parse(Console.ReadLine());



      int a = num1; 
      int b = num2; 
      int sum = a + b; 
      Console.WriteLine("The sum of " + a + " and " + b + " is: " + sum);


    }
  }
}