// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Ready to build a mini game with .NET/C# with help from GitHub Copilot?");

//write 'Hello world' to the console
Console.WriteLine("Hello World!");

//create string array with 3 elements
string[] games = new string[3];
//assign values to the array    
games[0] = "rock";
games[1] = "paper";
// add   scissors element to the array
games[2] = "scissors";
//create a object to hold the number of wins, losses and ties
GameStats gameStats = new GameStats();

try
{
    PlayGame(games, args, gameStats);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}

static void PlayGame(string[] games, string[] args, GameStats gameStats)
{
    //create a object to hold the number of wins, losses and ties
    if (gameStats == null)
    {
        gameStats = new GameStats();
    }
    //create a variable to hold the number of wins, losses and ties
    int wins = gameStats.wins;
    int losses = gameStats.losses;
    int ties = gameStats.ties;

    //print the number of wins, losses and ties
    Console.WriteLine("Wins: " + wins);
    Console.WriteLine("Losses: " + losses);
    Console.WriteLine("Ties: " + ties);

    //ask user to choose element to play
    //put index and element in the same line
    Console.WriteLine("Choose a game: 0 - rock, 1 - paper, 2 - scissors");
    //get user input
    //parse user input to int
    string? input = Console.ReadLine();
    int userInputIndex;
    if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out userInputIndex) || userInputIndex < 0 || userInputIndex > 2)
    {
        Console.WriteLine("Invalid input. Please choose 0, 1 or 2.");
        //call the method again
        PlayGame(games, args, gameStats);
        return;
    }
    //get user input from the array
    string userInput = games[userInputIndex];
    //print user input
    Console.WriteLine("You chose: " + userInput);
    //create a random number generator
    Random random = new Random();
    //create a random number between 0 and 2
    int randomNumber = random.Next(0, 3);
    //print the element at the random number index
    Console.WriteLine("The random game is: " + games[randomNumber]);
    //check if user input is equal to random number
    if (userInputIndex == randomNumber)
    {

        //increment ties counter   
        gameStats.ties++;
        Console.WriteLine("It's a tie!");
    }
    else if (userInputIndex == 0 && randomNumber == 2)
    {
        //increment wins counter
        gameStats.wins++;
        Console.WriteLine("You win!");
    }
    else if (userInputIndex == 1 && randomNumber == 0)
    {
        //increment wins counter
        gameStats.wins++;
        Console.WriteLine("You win!");
    }
    else if (userInputIndex == 2 && randomNumber == 1)
    {
        //increment wins counter
        gameStats.wins++;
        Console.WriteLine("You win!");
    }
    else
    {
        //increment losses counter
        gameStats.losses++;
        Console.WriteLine("You lose!");
    }
    //ask user if they want to play again
    Console.WriteLine("Do you want to play again? (y/n)");
    //get user input
    string? playAgainInput = Console.ReadLine();
    string playAgain = playAgainInput ?? string.Empty;
    //check if user input is valid
    if (playAgain != "y" && playAgain != "n")
    {
        Console.WriteLine("Invalid input. Please choose y or n.");
        return;
    }
    //check if user input is y
    if (playAgain == "y")
    {
        //call the method again
        PlayGame(games, args, gameStats);
        return;
    }
    else
    {
        Console.WriteLine("Thanks for playing!");
            //print the number of wins, losses and ties
            Console.WriteLine("Wins: " + gameStats.wins);
            Console.WriteLine("Losses: " + gameStats.losses);   
            Console.WriteLine("Ties: " + gameStats.ties);

        //end of the program
            //wait for user input before closing the console
            Console.WriteLine("Press any key to exit...");
        Console.Read();
    }
}