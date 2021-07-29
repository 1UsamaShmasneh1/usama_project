using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Game
{
    class Memory_Game
    {
        private static void NumOfPlayers() // chose number of players
        {
            string scoop = "f";
            string input;
            while (true)
            {
                Console.WriteLine("\nenter your choice" +
                    $"\n{scoop}\n" +
                    "\n1- Start game for one player" +
                    "\n2- Start game for tow players" +
                    "\n3- Start game for four players" +
                    "\n0- Exit Game");
                input = Console.ReadLine();
                if (input == "0")
                {
                    Console.WriteLine("good by");
                    break;
                }
                switch (input)
                {
                    case "1":
                        Board(1);
                        break;
                    case "2":
                        Board(2);
                        break;
                    case "3":
                        Board(3);
                        break;
                    default:
                        scoop = "enter valid choice";
                        break;
                }
            }
        }
        private static void Board(int numPlayers) // chose type of board
        {
            string scoop = "f";
            string input;
            while (true)
            {
                Console.WriteLine("\nenter your choice" +
                    $"\n{scoop}\n" +
                    "\n1- Board 2X2" +
                    "\n2- Board 4X4" +
                    "\n3- Board 8X8" +
                    "\n0- Exit Game");
                input = Console.ReadLine();
                if (input == "0")
                {
                    Console.WriteLine("good by");
                    break;
                }
                switch (input)
                {
                    case "1":
                        Game(numPlayers, 2);
                        break;
                    case "2":
                        Game(numPlayers, 4);
                        break;
                    case "3":
                        Game(numPlayers, 8);
                        break;
                    default:
                        scoop = "enter valid choice";
                        break;
                }
            }
        }
        private static string[,] FillBoard(int board) // fill the board with chars
        {
            string[,] boardArray = new string[board, board];
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            for (int i = 0; i < boardArray.GetLength(0); i++)
            {
                for (int j = 0; j < boardArray.GetLength(1); j++)
                {
                    boardArray[i, j] = Convert.ToString(chars[random.Next(chars.Length)]);
                    j++;
                    boardArray[i, j] = boardArray[i, j - 1];
                }
            }
            ShuffleArray(boardArray);
            return boardArray;

        }
        private static void ShuffleArray(string[,] boardArray) // shuffle the board
        {
            int lengthRow = boardArray.GetLength(1);
            Random random = new Random();
            int i1;
            int i2;
            int j1;
            int j2;
            int j3;
            string temp;
            for (int i = boardArray.Length - 1; i > 0; i--)
            {
                i1 = i / lengthRow;
                i2 = i % lengthRow;

                j1 = random.Next(i + 1);
                j2 = j1 / lengthRow;
                j3 = j1 % lengthRow;

                temp = boardArray[i1, i2];
                boardArray[i1, i2] = boardArray[j2, j3];
                boardArray[j2, j3] = temp;
            }
        }
        private static string Design(string[] boardRounds, int board) // design the board array to string value to printe it
        {
            string boardSTR = "";
            switch (board)
            {
                case 2:
                    boardSTR = $"{boardRounds[0]} | {boardRounds[1]}" +
                        $"\n{boardRounds[2]} | {boardRounds[3]}";
                    break;
                case 4:
                    boardSTR = $" {boardRounds[0]} |  {boardRounds[1]} |  {boardRounds[2]} |  {boardRounds[3]}" +
                        $"\n {boardRounds[4]} |  {boardRounds[5]} |  {boardRounds[6]} |  {boardRounds[7]}" +
                        $"\n {boardRounds[8]} |  {boardRounds[9]} | {boardRounds[10]} | {boardRounds[11]}" +
                        $"\n{boardRounds[12]} | {boardRounds[13]} | {boardRounds[14]} | {boardRounds[15]}";
                    break;
                case 8:
                    boardSTR = $" {boardRounds[0]} |  {boardRounds[1]} |  {boardRounds[2]} |  {boardRounds[3]} |  {boardRounds[4]} |  {boardRounds[5]} |  {boardRounds[6]} |  {boardRounds[7]}" +
                        $"\n {boardRounds[8]} |  {boardRounds[9]} | {boardRounds[10]} | {boardRounds[11]} | {boardRounds[12]} | {boardRounds[13]} | {boardRounds[14]} | {boardRounds[15]}" +
                        $"\n{boardRounds[16]} | {boardRounds[17]} | {boardRounds[18]} | {boardRounds[19]} | {boardRounds[20]} | {boardRounds[21]} | {boardRounds[22]} | {boardRounds[23]}" +
                        $"\n{boardRounds[24]} | {boardRounds[25]} | {boardRounds[26]} | {boardRounds[27]} | {boardRounds[28]} | {boardRounds[29]} | {boardRounds[30]} | {boardRounds[31]}" +
                        $"\n{boardRounds[32]} | {boardRounds[33]} | {boardRounds[34]} | {boardRounds[35]} | {boardRounds[36]} | {boardRounds[37]} | {boardRounds[38]} | {boardRounds[39]}" +
                        $"\n{boardRounds[40]} | {boardRounds[41]} | {boardRounds[42]} | {boardRounds[43]} | {boardRounds[44]} | {boardRounds[45]} | {boardRounds[46]} | {boardRounds[47]}" +
                        $"\n{boardRounds[48]} | {boardRounds[49]} | {boardRounds[50]} | {boardRounds[51]} | {boardRounds[52]} | {boardRounds[53]} | {boardRounds[54]} | {boardRounds[55]}" +
                        $"\n{boardRounds[56]} | {boardRounds[57]} | {boardRounds[58]} | {boardRounds[59]} | {boardRounds[60]} | {boardRounds[61]} | {boardRounds[62]} | {boardRounds[63]}";
                    break;
            }
            return boardSTR;
        }
        private static int Round(string boardSTR, string[] boardRounds, string[,] boardArray, int conter, int board) // round to play for every player
        {
            string choice1;
            string choice2;
            string choiceElemnt1;
            string choiceElemnt2;
            int points = 0;
            while (conter < boardRounds.Length / 2)
            {
                while (true)
                {
                    Console.WriteLine("enter your first choice:" +
                        $"\n{boardSTR}");
                    choice1 = Console.ReadLine();
                    if (Array.IndexOf(boardRounds, choice1) != -1)
                    {
                        boardRounds[Convert.ToInt32(choice1)] = boardArray[Convert.ToInt32(choice1) / Convert.ToInt32(Math.Sqrt(boardRounds.Length)), Convert.ToInt32(choice1) % Convert.ToInt32(Math.Sqrt(boardRounds.Length))];
                        choiceElemnt1 = boardArray[Convert.ToInt32(choice1) / Convert.ToInt32(Math.Sqrt(boardRounds.Length)), Convert.ToInt32(choice1) % Convert.ToInt32(Math.Sqrt(boardRounds.Length))];
                        boardSTR = Design(boardRounds, board);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("enter number in the range");
                    }
                }
                while (true)
                {
                    Console.WriteLine("enter your second choice:" +
                        $"\n{boardSTR}");
                    choice2 = Console.ReadLine();
                    if (Array.IndexOf(boardRounds, choice2) != -1)
                    {
                        boardRounds[Convert.ToInt32(choice2)] = boardArray[Convert.ToInt32(choice2) / Convert.ToInt32(Math.Sqrt(boardRounds.Length)), Convert.ToInt32(choice2) % Convert.ToInt32(Math.Sqrt(boardRounds.Length))];
                        choiceElemnt2 = boardArray[Convert.ToInt32(choice2) / Convert.ToInt32(Math.Sqrt(boardRounds.Length)), Convert.ToInt32(choice2) % Convert.ToInt32(Math.Sqrt(boardRounds.Length))];
                        boardSTR = Design(boardRounds, board);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("enter number in the range");
                    }
                }
                conter++;
                Console.WriteLine("enter your second choice:" +
                        $"\n{boardSTR}");
                if (choiceElemnt1 == choiceElemnt2)
                {
                    points++;
                    Console.WriteLine("done");
                }
                else
                {
                    boardRounds[Convert.ToInt32(choice1)] = choice1;
                    boardArray[Convert.ToInt32(choice1) / Convert.ToInt32(Math.Sqrt(boardRounds.Length)), Convert.ToInt32(choice1) % Convert.ToInt32(Math.Sqrt(boardRounds.Length))] = choiceElemnt1;
                    boardRounds[Convert.ToInt32(choice2)] = choice2;
                    boardArray[Convert.ToInt32(choice2) / Convert.ToInt32(Math.Sqrt(boardRounds.Length)), Convert.ToInt32(choice2) % Convert.ToInt32(Math.Sqrt(boardRounds.Length))] = choiceElemnt2;
                    boardSTR = Design(boardRounds, 2);
                    Console.WriteLine("try again");
                    break;
                }
            }
            return points;
        }
        private static void PlayOnePlayer(string[,] boardArray, string[] boardRounds, string boardSTR) // game for one player
        {
            int points = 0;
            string choice = "";
            while (points < boardRounds.Length / 2)
            {
                points += Round(boardSTR, boardRounds, boardArray, points, boardArray.GetLength(0));
                Console.WriteLine("pres enter to continue / write 'exit' to exit");
                choice = Console.ReadLine();
                if (choice == "exit")
                    break;
            }
            Console.WriteLine($"you finesh th game with {points} points");
        }
        private static void PlayTowPlayers(string[,] boardArray, string[] boardRounds, string boardSTR) // game for tow players
        {
            int pointsPlayerOne = 0;
            int pointsPlayerTow = 0;
            int counter = 0;
            string choice = "";
            while (counter < boardRounds.Length / 2)
            {
                pointsPlayerOne += Round(boardSTR, boardRounds, boardArray, counter, boardArray.GetLength(0));
                Console.WriteLine("pres enter to continue / write 'exit' to exit");
                choice = Console.ReadLine();
                if (choice == "exit")
                    break;
                pointsPlayerTow += Round(boardSTR, boardRounds, boardArray, counter, boardArray.GetLength(0));
                counter += pointsPlayerOne + pointsPlayerTow;
                Console.WriteLine("pres enter to continue / write 'exit' to exit");
                choice = Console.ReadLine();
                if (choice == "exit")
                    break;
            }
            Console.WriteLine($"the game fineshed, player one {pointsPlayerOne} points, player tow {pointsPlayerTow} points");
        }
        private static void PlayFourPlayers(string[,] boardArray, string[] boardRounds, string boardSTR) // game for four players
        {
            int pointsPlayerOne = 0;
            int pointsPlayerTow = 0;
            int pointsPlayerThree = 0;
            int pointsPlayerFour = 0;
            int counter = 0;
            string choice = "";
            while (counter < boardRounds.Length / 2)
            {
                pointsPlayerOne += Round(boardSTR, boardRounds, boardArray, counter, boardArray.GetLength(0));
                Console.WriteLine("pres enter to continue / write 'exit' to exit");
                choice = Console.ReadLine();
                if (choice == "exit")
                    break;
                pointsPlayerTow += Round(boardSTR, boardRounds, boardArray, counter, boardArray.GetLength(0));
                Console.WriteLine("pres enter to continue / write 'exit' to exit");
                choice = Console.ReadLine();
                if (choice == "exit")
                    break;
                pointsPlayerThree += Round(boardSTR, boardRounds, boardArray, counter, boardArray.GetLength(0));
                Console.WriteLine("pres enter to continue / write 'exit' to exit");
                choice = Console.ReadLine();
                if (choice == "exit")
                    break;
                pointsPlayerFour += Round(boardSTR, boardRounds, boardArray, counter, boardArray.GetLength(0));
                counter += pointsPlayerOne + pointsPlayerTow + pointsPlayerThree + pointsPlayerFour;
                Console.WriteLine("pres enter to continue / write 'exit' to exit");
                choice = Console.ReadLine();
                if (choice == "exit")
                    break;
            }
            Console.WriteLine($"the game fineshed, player one {pointsPlayerOne} points, player tow {pointsPlayerTow} points, player three {pointsPlayerThree} points, player four {pointsPlayerFour} points");
        }
        private static void Game(int numOfPlayers, int board) // processor for the game
        {
            string[,] boardArray = FillBoard(board);
            string[] boardRounds = new string[1];
            string boardSTR = "";
            switch (board)
            {
                case 2:
                    boardRounds = new string[4] { "0", "1", "2", "3" };
                    boardSTR = Design(boardRounds, board);
                    break;
                case 4:
                    boardRounds = new string[16];
                    for (int i = 0; i < 16; i++)
                    {
                        boardRounds[i] = Convert.ToString(i);
                    }
                    boardSTR = Design(boardRounds, board);
                    break;
                case 8:
                    boardRounds = new string[64];
                    for (int i = 0; i < 64; i++)
                    {
                        boardRounds[i] = Convert.ToString(i);
                    }
                    boardSTR = Design(boardRounds, board);
                    break;
            }
            switch (numOfPlayers)
            {
                case 1:
                    PlayOnePlayer(boardArray, boardRounds, boardSTR);
                    break;
                case 2:
                    PlayTowPlayers(boardArray, boardRounds, boardSTR);
                    break;
                case 4:
                    PlayFourPlayers(boardArray, boardRounds, boardSTR);
                    break;
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            NumOfPlayers();
            Console.ReadLine();
        }
    }
}
