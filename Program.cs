using System;

namespace numberpicker
{
  class Program
  {


    static void Main(string[] args)
    {
      //1st set your minimum and maximum within your main
      var minimum = 0;
      var maximum = 100;

      //2nd set the initial guess to half of the maximum using the binary search system(cuts the number in half with every loop) 
      var guess = maximum / 2;

      //Make your while loop true
      var guessing = true;

      //This will call your response after the userInput ReadLine from line 28. This will cue user for higher or lower
      Console.WriteLine(guess);

      //Name your while loop. this will make your if else statement run its loop as long as it is true.
      while (guessing)
      {
        //Defines where userInput comes from. Comes from the Console.ReadLine.
        Console.WriteLine("Is your number higher or lower?");
        var userInput = Console.ReadLine();

        //If user inputs higher use this logic
        if (userInput == "higher")
        {
          minimum = guess + 1;
          guess = (maximum + minimum) / 2;
          Console.WriteLine($"Is your number {guess}");
        }
        //If user inputs lower use this logic
        if (userInput == "lower")
        {
          maximum = guess - 1;
          guess = (maximum + minimum) / 2;
          Console.WriteLine($"Is your number {guess}");
        }
        //If the user inputs correct number use this logic
        if (userInput == "correct number")
        {
          //Below should stop the loop
          guessing = false;
          //Below print the end of the game WriteLine
          System.Console.WriteLine($"Your number is {guess}.");
        }
      }


      //Set the minimum number to 0
      //Set the maximum number to 100
      //Start at 50 as starting guess
      //Respond whether the player chose a number that needs to be lower --too high
      //Respond whether the player chose a number that needs to be higher --too low
      //Did the player respond correct number. If so, end the loop and display the correct number.

    }
  }
}