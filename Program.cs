using System;

namespace c__rps
{
  class Program
  {
    static void Main(string[] args)
    {
      int userCount = 0;
      int compCount = 0;
      Console.WriteLine("Hello World!");

      System.Console.WriteLine("Want to play Roschambeau? Y/N");
      string userInput = Console.ReadLine();
      bool playing = userInput.ToLower() == "y" || userInput.ToLower() == "yes";
      while (playing)
      {
      System.Console.WriteLine("Make a choice: rock, paper, scissors");
      string user = Console.ReadLine().ToLower();
      Random random = new Random();
      int compRPS = random.Next(0,3);
      string[] choices = new string[3] { "rock", "paper", "scissors" };
      Console.WriteLine("Computer: " + choices[compRPS]);
        if (user == "rock" && choices[compRPS] == "rock")
        {
          Console.WriteLine("It's a Tie");
          userCount += 0;
          compCount += 0;
        }
        else if (user == "paper" && choices[compRPS] == "rock")
        {
          Console.WriteLine("User Wins");
          userCount += 1;
          compCount += 0;
        }
        else if (user == "scissors" && choices[compRPS] == "rock")
        {
          Console.WriteLine("Computer Wins");
          userCount += 0;
          compCount += 1;
        }
        else if (user == "rock" && choices[compRPS] == "paper")
        {
          Console.WriteLine("Computer Wins");
          userCount += 0;
          compCount += 1;
        }
        else if (user == "paper" && choices[compRPS] == "paper")
        {
          Console.WriteLine("It's a Tie");
          userCount += 0;
          compCount += 0;
        }
        else if (user == "scissors" && choices[compRPS] == "paper")
        {
          Console.WriteLine("User Wins");
          userCount += 1;
          compCount += 0;
        }
        else if (user == "rock" && choices[compRPS] == "scissors")
        {
          Console.WriteLine("User Wins");
          userCount += 1;
          compCount += 0;
        }
        else if (user == "paper" && choices[compRPS] == "scissors")
        {
          Console.WriteLine("Computer Wins");
          userCount += 0;
          compCount += 1;
        }
        else if (user == "scissors" && choices[compRPS] == "scissors")
        {
          Console.WriteLine("It's a Tie!");
          userCount += 0;
          compCount += 0;
        }
        //NOTE End of initial round 
        System.Console.WriteLine("Do you want to play again? Y/N");
        string continueGame = Console.ReadLine();
        if(continueGame.ToLower() == "y" || continueGame.ToLower() == "yes")
        {
          compRPS = random.Next(1,3);
        }   
        else if(continueGame.ToLower() == "n" || continueGame.ToLower() == "no") {
          playing = false;
        }
        continue;
      }
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("User wins " + userCount + " times");
      Console.WriteLine("Computer wins " + compCount + " times");




    }
  }
}
