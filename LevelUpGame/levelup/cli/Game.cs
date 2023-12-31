using Sharprompt;
using System.Collections;
using Console = Colorful.Console;
using System.Drawing;

namespace levelup.cli;
public class Game
{
    static GameMap gameMap = new GameMap();
    static GameController gameController = new GameController(gameMap);
    static Boolean isGameStarted = false;

    public enum startingMenuCommands
    {
        Help,
        CreateCharacter,
        //StartGame,
        Exit
    }

    public enum inGameCommands
    {
        Help,
        North,
        South,
        East,
        West,
        Exit
    }

    public enum CharacterType
    {
        Monk,
        FrenchConquistador,
        EnglishKnight,
        BlackKnight 
    }

    public enum MoveActionResult
    {
        Success,
        Bounce,
        Winner 
    }

    static void Main(string[] args)
    {
        printWelcomeMessage();

        while (!isGameStarted)
        {
            var type = Prompt.Select<startingMenuCommands>("Choose game command:");

            switch (type)
            {
                case startingMenuCommands.Help:
                    Help();
                    break;
                case startingMenuCommands.CreateCharacter:
                    CreateCharacter();
                    break;
                case startingMenuCommands.Exit:
                    EndGame();
                    break;
                // case startingMenuCommands.StartGame:
                //     StartGame();
                //     break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        while (true)
        {
            var type = Prompt.Select<inGameCommands>("Choose game command:");

            switch (type)
            {
                case inGameCommands.Help:
                    Help();
                    break;
                case inGameCommands.Exit:
                    EndGame();
                    break;
                case inGameCommands.North:
                    MoveNorth();
                    break;
                case inGameCommands.South:
                    MoveSouth();
                    break;
                case inGameCommands.East:
                    MoveEast();
                    break;
                case inGameCommands.West:
                    MoveWest();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    static void Help()
    {
        //TODO: FILL OUT USER HELP INSTRUCTIONS
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("HELP!");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Choose a command below using your arrow keys.");
        Console.WriteLine("Once a game is started, you will be able to move and explore.");
        Console.WriteLine("Once you are done exploring, choose Exit to see a summary.");
        Console.WriteLine("-------------------------------------------------");
    }

    private static void printWelcomeMessage()
    {
        Console.WriteAscii("Monty Python's", Color.FromArgb(255,215,0));
        Console.WriteAscii("Quest for the Holy Grail", Color.FromArgb(255, 254, 212));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Press ENTER to begin");
        Console.ReadLine();
    }

    static void CreateCharacter()
    {
        var characterName = Prompt.Input<string>("What is your character's name?");
        var characterType = Prompt.Select<CharacterType>("Choose Character Type:"); 
        gameController.CreateCharacter(characterName, characterType);
        var gameStatusCharacterName = gameController.GetStatus().characterName;
        Console.WriteLine($"Welcome {gameStatusCharacterName} the {characterType} to Quest for the Holy Grail!");
        Console.WriteLine("Press Enter to start game...");
        Console.ReadLine();
        isGameStarted = true;
    }

    static void StartGame()
    {
        isGameStarted = true;
        gameController.StartGame();
        Console.WriteLine("Entering to Quest for the Holy Grail!! You have entered a mysterious place.");
    }
    static void MoveNorth()
    {
        gameController.Move(GameController.DIRECTION.NORTH);
        updateStatus(gameController.GetStatus());
    }
    static void MoveSouth()
    {
        gameController.Move(GameController.DIRECTION.SOUTH);
        updateStatus(gameController.GetStatus());
    }
    static void MoveEast()
    {
        gameController.Move(GameController.DIRECTION.EAST);
        updateStatus(gameController.GetStatus());
    }

    static void MoveWest()
    {
        gameController.Move(GameController.DIRECTION.WEST);
        updateStatus(gameController.GetStatus());
    }

    static void EndGame()
    {
        var answer = Prompt.Confirm("Do you want to exit?");
        if (answer == true)
        {
            //TODO: PRINT FINAL SUMMARY
            Console.WriteLine("You exit the mysterious world.");
            PrintSummary();
            Environment.Exit(0);
        }
    }

    static void PrintSummary()
    {
        Console.WriteLine("Exiting the mysterious land!");
        foreach (MoveAction status in gameController.GameHistory)
        {
            // TODO: Override toString on game status to print pretty
            Console.WriteLine(status);
        }
        // TODO: Print anything else you committed to in your mockup

    }

    private static void updateStatus(GameController.GameStatus status)
    {
        //gameHistory.Add(status);
    }


}