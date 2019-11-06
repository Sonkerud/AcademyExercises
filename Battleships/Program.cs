using System;
using System.Collections.Generic;
using System.Linq;

namespace Battleships
{
    class Program

    {
        static int sizeOfMap;
        static int numberOfPlayers;
        static string[] nameOfPlayers;
        static Dictionary<string, int> players = new Dictionary<string, int>();
        static string[,] map;
        static string[,] mapWithShips;
        static string[,] ships;
        static Random random = new Random();
        static int numberOfBombs = 0;

        static void Main(string[] args)
        {
            StartUp();
            BuildShips();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                BuildMap();
                WelcomePlayer(i);
                RandomizeShipLocations();
                DrawMap();
                GuessLocationOfShips(i);
                AddScore(i);
                Console.ReadLine();
            }
            CalculateWinner();
        }
        static void StartUp()
        {
            bool numberofPlayersBool = false;
            while (!numberofPlayersBool)
            {
                try
                {
                    Console.WriteLine("Number Of Players: ");
                    numberOfPlayers = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a number between 1-4\n");
                }

                if (numberOfPlayers > 0 && numberOfPlayers < 5)
                {
                    numberofPlayersBool = true;
                }
                else
                {
                    Console.WriteLine("Input a number between 1-4\n");
                }
            }


            nameOfPlayers = new string[numberOfPlayers];
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.Clear();
                Console.WriteLine($"Player {i + 1}:");
                Console.WriteLine("Name:");
                Console.SetCursorPosition(6, 1);
                string name = Console.ReadLine();
                nameOfPlayers[i] = name;
            }


        }
        static void WelcomePlayer(int i)
        {
            Console.Clear();
            Console.WriteLine($"Welcome {nameOfPlayers[i]}. Good luck in sinking le Chips");
            Console.WriteLine("Press Enter to play:");
            Console.ReadLine();
        }
        static void BuildMap()
        {
            bool inputSizeOfMap = false;
            while (!inputSizeOfMap)
            {
                try
                {
                    Console.WriteLine("Decide size of map. Input a number between 6 - 10");
                    sizeOfMap = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a number between 6 - 10");
                }

                if (sizeOfMap > 5 && sizeOfMap < 11)
                {
                    inputSizeOfMap = true;
                }
                else
                {
                    Console.WriteLine("Input a number between 6 - 10");
                }
            }

            map = new string[sizeOfMap, sizeOfMap];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[i, x] = " #";
                }
            }
            mapWithShips = (string[,])map.Clone();
        }
        static void BuildShips()
        {
            ships = new string[3, 3];
            ships[0, 0] = " o";

            ships[1, 0] = " =";
            ships[1, 1] = " =";

            ships[2, 0] = " w";
            ships[2, 1] = " w";
            ships[2, 2] = " w";
        }
        static void RandomizeShipLocations()
        {
            bool correctRandomize = false;
            while (!correctRandomize)
            {

                int x = random.Next(0, sizeOfMap);
                int y = random.Next(0, sizeOfMap);
                mapWithShips[x, y] = ships[0, 0];

                int a = random.Next(0, sizeOfMap);
                int b = random.Next(0, sizeOfMap - 1);


                mapWithShips[a, b] = ships[1, 0];
                mapWithShips[a, b + 1] = ships[1, 1];

                int z = random.Next(0, sizeOfMap);
                int c = random.Next(0, sizeOfMap - 2);
                mapWithShips[z, c] = ships[2, 0];
                mapWithShips[z, c + 1] = ships[2, 1];
                mapWithShips[z, c + 2] = ships[2, 2];

                if (z == a || z == x || a == x)
                {

                    correctRandomize = false;
                    for (int o = 0; o < mapWithShips.GetLength(0); o++)
                    {
                        for (int p = 0; p < mapWithShips.GetLength(1); p++)
                        {
                            mapWithShips[o, p] = " #";
                        }
                    }

                }
                else
                {
                    correctRandomize = true;
                }
            }




        }
        static void DrawMap()
        {
            Console.Clear();
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("Battleship - The game of bombs");

            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.SetCursorPosition(1, i + 2);
                Console.WriteLine($"{i}");
            }


            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.SetCursorPosition(2, i + 2);
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    Console.Write(map[i, x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void GuessLocationOfShips(int i)
        {
            int x = 0;
            int y = 0;
            int battlecruiser = 3;
            int destroyer = 2;
            int sailboat = 1;
            Console.WriteLine("Let's bomb the ships!");
            while (true)
            {
                bool inputX = false;
                while (!inputX)
                {
                    try
                    {
                        Console.WriteLine("Input X-coordinate:");
                        x = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Input a number between 0 - {sizeOfMap - 1}");
                    }

                    if (x >= 0 && x <= sizeOfMap - 1)
                    {
                        inputX = true;
                    }
                    else
                    {
                        Console.WriteLine($"Input a number between 0 - {sizeOfMap - 1}");
                    }
                }
                bool inputY = false;
                while (!inputY)
                {
                    try
                    {
                        Console.WriteLine("Input Y-coordinate:");
                        y = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Input a number between 0 - {sizeOfMap - 1}");
                    }

                    if (y >= 0 && y <= sizeOfMap - 1)
                    {
                        inputY = true;
                    }
                    else
                    {
                        Console.WriteLine($"Input a number between 0 - {sizeOfMap - 1}");
                    }
                }

                if (mapWithShips[x, y] == " #")
                {
                    numberOfBombs++;
                    map[x, y] = " *";
                    Console.SetCursorPosition(0, 1);
                    DrawMap();
                    Console.WriteLine("You missed! Try again!");
                }
                else if (mapWithShips[x, y] == " w")
                {
                    numberOfBombs++;
                    battlecruiser--;
                    map[x, y] = " w";
                    mapWithShips[x, y] = " %";
                    Console.SetCursorPosition(0, 1);
                    DrawMap();
                    Console.WriteLine("You hit a battlecruiser!\n");
                }
                else if (mapWithShips[x, y] == " =")
                {
                    numberOfBombs++;
                    destroyer--;
                    map[x, y] = " =";
                    mapWithShips[x, y] = " %";
                    Console.SetCursorPosition(0, 1);
                    DrawMap();
                    Console.WriteLine("You hit a destroyer!\n");
                }
                else if (mapWithShips[x, y] == " o")
                {
                    numberOfBombs++;
                    sailboat--;
                    map[x, y] = " o";
                    mapWithShips[x, y] = " %";
                    Console.SetCursorPosition(0, 1);
                    DrawMap();
                    Console.WriteLine("You hit a small tiny sailboat!\n");
                }
                else if (mapWithShips[x, y] == " %")
                {
                    numberOfBombs++;
                    Console.SetCursorPosition(0, 1);
                    DrawMap();
                    Console.WriteLine("You already bomb that location!\n");
                }

                if (battlecruiser == 0)
                {
                    Console.WriteLine($"You sank the Battlecruiser!");
                    Console.WriteLine($"You have used {numberOfBombs} bombs!");
                }
                if (destroyer == 0)
                {
                    Console.WriteLine($"You sank the Destroyer!");
                    Console.WriteLine($"You have used {numberOfBombs} bombs!");
                }
                if (sailboat == 0)
                {
                    Console.WriteLine($"You sank the Sailboat!");
                    Console.WriteLine($"You have used {numberOfBombs} bombs!");
                }
                if (battlecruiser == 0 && destroyer == 0 && sailboat == 0)
                {
                    Console.WriteLine($"You sank the whole fleet! Well done Amiral {nameOfPlayers[i]}");
                    Console.WriteLine($"You needed {numberOfBombs} bombs!");
                    break;
                }
            }
        }

        static void AddScore(int i)
        {
            players.Add(nameOfPlayers[i], numberOfBombs);
            numberOfBombs = 0;
        }
        static void CalculateWinner()
        {
            Console.Clear();
            var winnerScore = players.Values.Max();

            foreach (var bombs in players.Values)
            {
                if (bombs == winnerScore)
                {
                    Console.WriteLine(players.Keys);
                }
            }
            
            for (int i = 0; i < players.Count; i++)
            {
               
            }
          

            
        }
    }
}
