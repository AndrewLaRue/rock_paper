// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");



string greeting = "Hello World Class C# is cool but different";

// Arrays stink!
// string[] words = new string[3];
// words[0] = "hellow";
// words[1] = "whats up";
// words[2] = "howdy";

//list works just like arrays in javascript do, they just get created weirdly.
List<string> words = new List<string>() { "Hello", "Howdy", "what's up" };

Dictionary<string, int> numbers = new Dictionary<string, int>();
numbers.Add("first", 1);
numbers.Add("second", 2);
numbers.Add("third", 3);


Console.WriteLine(greeting);

for (int i = 0; i < words.Count; i++)
{
  Console.WriteLine(words[i]);
}

words.ForEach(word =>
{
  Console.WriteLine(word);
});


foreach (var item in numbers)
{
  Console.WriteLine(item.Value);
}


// string input = Console.ReadLine();
// Console.WriteLine("You Wrote :" + input);

List<string> possibleWords = new List<string> {
    "cigar",
};
int score = 0;

Console.WriteLine("WELCOME TO WORBLE");
bool playing = true;

<!-- start of play -->
do
{
  Random rand = new Random();
  int randomIndex = rand.Next(0, possibleWords.Count - 1);
  int attempts = 1;
  string secretWord = possibleWords[randomIndex];
  bool won = false;

  for (int i = 0; i < 6; i++)
  {
    // Console.WriteLine("attempt :" + attempts);
    bool validInput = false;
    string? input = "";
    do
    {
      input = Console.ReadLine();
      if (input.Length == 5)
      {
        validInput = true;
      }
    } while (validInput == false);


    if (input != null)
    {
      if (input == secretWord)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You smart little pickle, you got it!");
        Console.ForegroundColor = ConsoleColor.Gray;
        won = true;
        i = 6;
      }
      else
      {
        for (int j = 0; j < input.Length; j++)
        {
          if (secretWord[j] == input[j])
          {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(input[j]);
          }
          else if (secretWord.Contains(input[j]))
          {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(input[j]);
          }
          else
          {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("-");
          }
        }
        Console.BackgroundColor = ConsoleColor.Black;
      }
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    // Console.WriteLine(" ");
    attempts++;
  }
  if (won)
  {
    Console.WriteLine("you should work at nasa you're so smart");
    score++;
    Console.WriteLine("Score: " + score);
  }
  else
  {
    Console.WriteLine("Dang you must be dumb. couldn't you tell it was " + secretWord);
    playing = false;
  }
} while (playing);
