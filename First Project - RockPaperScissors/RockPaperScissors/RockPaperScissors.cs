﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
        //   ConsoleColor background = Console.BackgroundColor;
        //   ConsoleColor foreground = Console.ForegroundColor;

            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine($"Choose [r]ock, [p]aper, [s]cissors: ");

            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "Paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Invalid input. Try Again...");
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = String.Empty;

            switch (computerRandomNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    computerMove = Rock;
                     break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    computerMove = Paper;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    computerMove = Scissors;
                    break;                  
            }

            Console.WriteLine($"The computer chose {computerMove}.");

            if ((playerMove == Rock && computerMove == Scissors) ||
                (playerMove == Scissors && computerMove == Paper) ||
                (playerMove == Paper && computerMove == Rock))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You win.");
            }
            else if ((playerMove == Rock && computerMove == Paper) ||
                (playerMove == Scissors && computerMove == Rock) ||
                (playerMove == Paper && computerMove == Scissors))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
            }
            else if ((playerMove == Rock && computerMove == Rock) ||
                (playerMove == Scissors && computerMove == Scissors) ||
                (playerMove == Paper && computerMove == Paper))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("This game was a draw.");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
