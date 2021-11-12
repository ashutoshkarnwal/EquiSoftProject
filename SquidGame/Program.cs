using SquidGame.Game;
using SquidGame.Interfaces;
using System;
using SquidGame.ProductFactories;
using System.Collections.Generic;
using System.Linq;
using SquidGame.Factory;
using SquidGame.Enums;

namespace SquidGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Rules for the Game
            GameRules rules = new GameRules();
            rules.BuildGameRules();

            //Create Products to Play With
            ProductFactory factory = new ProductFactory(new ProductCreator());
            factory.CreateSquidGameProducts();

            //Create Players
            PlayerFactory playerFactory = new PlayerFactory(new PlayerCreator());

            List<Player> players = new List<Player>();

            int roundNumber = 1;
            int winningRound = 3;

            while (1 == 1)
            {
                Console.WriteLine("Lets Start The Game \n");
                Console.WriteLine("Please choose your opponent \n");
                Console.WriteLine("1: Other Human Player \n");
                Console.WriteLine("2: Computer \n");

                int Player2Type = Int32.Parse(Console.ReadLine());
                if (Player2Type == (int)PlayerTypeEnum.Regular)
                {
                    playerFactory.BuildHumanVsHumanPlayers();                    
                }
                else
                {
                    playerFactory.BuildHumanVsComputerPlayers();
                }

                players = playerFactory.GetAllPlayers();

                while (!players.Any(x => x.GetWinningCount() == winningRound))
                {
                    Console.WriteLine("=============================Lets Start Round no {0}=======================================\n", roundNumber);
                    foreach (Player player in players)
                    {
                        Console.WriteLine("{0} please select your choice from given products\n", player._Name);
                        player.SetPlayerChoice(factory);
                    }

                    (bool isPlayer1Winner, bool isPlayer2Winner) = rules.GetWinner(players[0].GetSelectedItem(), players[1].GetSelectedItem());
                    if (!isPlayer1Winner && !isPlayer2Winner)
                    {
                        Console.WriteLine("This Round is a Tie\n");
                        Console.WriteLine("Make Selection Again\n");
                        continue;
                    }
                    else if (isPlayer1Winner)
                    {
                        Console.WriteLine("{0} wins this round\n", players[0]._Name);
                        players[0].UpdateWinningCount();
                    }
                    else
                    {
                        Console.WriteLine("{0} wins this round\n", players[1]._Name);
                        players[1].UpdateWinningCount();
                    }

                    Console.WriteLine("Current Scores and selection for the player in this round are as below:-\n");
                    foreach (Player player in players)
                    {
                        Console.WriteLine("Score for {0} is {1} and Selection for this round is {2}\n", 
                            player._Name, player.GetWinningCount(),
                            factory.GetAllProducts().
                            Where(x => x.GetProductId() == (int)player.GetSelectedItem()).
                            FirstOrDefault().GetProductName());
                    }

                    roundNumber++;
                }

                Console.WriteLine("The Winner for this game is {0}. Congratulations!!!!\n",
                    players.Where(x => x.GetWinningCount() == 3).FirstOrDefault()._Name);

                Console.WriteLine("Press 1 to Continue. 0 to exit\n");
                if (Int32.Parse(Console.ReadLine()) == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    players.Clear();
                    roundNumber = 1;
                    continue;
                }

            }
        }
    }
}
