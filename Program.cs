using System;

namespace numberpicker
{
  class Program
  {

    static int PickNumber(int randomNumber)
    {
      var result = new Random().Next(randomNumber) + 1;
      // Side effects
      return result;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Let's create a numberpicker game");



      Console.WriteLine("Your number is, number");
      var number = Console.ReadLine();

      System.Console.WriteLine("You favorite number is " + number);

    }
  }
}
