// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lets play Rock Paper Scissors!");


bool playing = true;


List<string> options = new List<string> {
    "rock",
    "paper",
    "scissors",
};
int score = 0;

do
{
  Random rand = new Random();
  int randomIndex = rand.Next(0, options.Count);
  string compChoice = options[randomIndex];
  string? input = "";
  // bool validInput = false;


  input = Console.ReadLine();
  if (input == "rock" || input == "paper" || input == "scissors")
  {
    if (input == "rock" && compChoice == "scissors")
    {
      Console.WriteLine("You win! Crush those " + compChoice);
      score += 1;
      Console.WriteLine("Score: " + score);
    }
    else if (input == "paper" && compChoice == "rock")
    {
      Console.WriteLine("You win! Cover that " + compChoice);
      score += 1;
      Console.WriteLine("Score: " + score);
    }
    else if (input == "scissors" && compChoice == "paper")
    {
      Console.WriteLine("You win! Cut that " + compChoice);
      score += 1;
      Console.WriteLine("Score: " + score);
    }
    else if (input == compChoice)
    {
      Console.WriteLine("Tie!! Please try again");
    }
    else
    {
      Console.WriteLine("You Suck! Comp uses " + compChoice + " to destroy your " + input);
      playing = false;
    }
  }
  else
  {
    Console.WriteLine("Please choose rock paper or scissors");
  };

  // Console.WriteLine(compChoice);
} while (playing);

