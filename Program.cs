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

      Console.WriteLine("Pick a number between 1 and 20");

    }
  }
}
