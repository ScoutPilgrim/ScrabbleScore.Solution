using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word to check its Scrabble score.");
    string userInput = Console.ReadLine();
    CheckScore newCheckScore = new CheckScore(userInput);
    newCheckScore.CalculateScore();
    int myScore = newCheckScore.GetUserScore();
    Console.WriteLine("Your Scrabble score for the word " + newCheckScore.GetUserInput()+ ": " + myScore + "!");

  }
}
