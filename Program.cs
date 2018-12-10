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


// const MIN = 1
// const MAX = 1000

// let upper, lower, guess, tries

// const startGame = () => {
//   lower = MIN
//   upper = MAX
//   tries = 0
//   updateGame()
//   document.querySelector('#intro').style.display = 'none'
//   document.querySelector('#game').style.display = 'block'
// }

// const endGame = () => {
//   document.querySelector('#game').style.display = 'none'
//   document.querySelector('#victory').style.display = 'block'
//   document.querySelector('#tries').textContent = tries
// }

// const resetGame = () => {
//   document.querySelector('#victory').style.display = 'none'
//   document.querySelector('#intro').style.display = 'block'
//   tries = 0
//   lower = MIN
//   upper = MAX
// }

// const guessLower = () => {
//   upper = guess - 1
//   updateGame()
// }

// const guessHigher = () => {
//   lower = guess + 1
//   updateGame()
// }

// const updateGame = () => {
//   guess = Math.round((lower + upper) / 2)
//   document.querySelector('#guess').textContent = guess
//   tries++
// }

// const main = () => {
//   document.querySelector('#min').textContent = MIN
//   document.querySelector('#max').textContent = MAX
//   document.querySelector('#dif').textContent = Math.round(Math.log(MAX) / Math.log(2))
//   document.querySelector('#ok').addEventListener('click', startGame)
//   document.querySelector('#lower').addEventListener('click', guessLower)
//   document.querySelector('#higher').addEventListener('click', guessHigher)
//   document.querySelector('#yes').addEventListener('click', endGame)
//   document.querySelector('#reset').addEventListener('click', resetGame)
// }

// main()