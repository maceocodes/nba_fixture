﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace nba_fixture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new 
            Filehandler execute = new Filehandler();
            List<Matchup> matchups = execute.ReadMatches();
            foreach (var game in matchups)
            {
                game.printMatchup();
            }
            Console.WriteLine("Type a number corresponding to the matchup you want to select and hit enter to edit");
            
            int gameIDParsed;
            //confirm that user input is a number represented in the list
            bool notAnInt = true;
            bool notInList = true;
            while (notAnInt || notInList)
            {
                var userInput = Console.ReadLine(); //initial user input
                notAnInt = !int.TryParse(userInput, out gameIDParsed);
                if (notAnInt)
                {
                    Console.WriteLine("Selection should be an integer");
                }

                foreach (var matchup in matchups)
                {
                    if (matchup.ID == gameIDParsed)
                    {
                        notInList = false;
                        matchup.printMatchup();
                        Console.WriteLine("Who's gonna win this game?");
                        var userResultInput = Console.ReadLine();
                        matchup.Result = userResultInput; //stores user 2nd input into the result column
                        matchup.printMatchup();
                        execute.WriteGameResults(matchups);
                        Console.WriteLine("Entry saved successfully");

                        break;

                    }
                    else
                    {
                        notInList = true;
                    }
                }

                if (notInList)
                { Console.WriteLine("Input is not a matchup in the list"); }

            }

            Console.ReadLine();

        }
    }
}