﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace nba_fixture
{
    class Filehandler
    { ////Import and parse CSV data
        public List<Matchup> ReadMatches()
        {
            List<Matchup> game = new List<Matchup>();
            using (var reader = new StreamReader(@"../../nbaData/nbaResults.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');

                    //Confirm that ID field always contains a number
                    int gameID = 0;
                    if (Int32.TryParse(data[0], out gameID) ==false)
                    {
                        Console.WriteLine("Game ID must be a number");
                        return new List<Matchup>();
                    }
                        var matchUp = new Matchup
                    {   
                        ID = gameID,
                        Date = data[1],
                        HomeTeam = data[2],
                        AwayTeam = data[3],
                        Result = data[4]
          
                    };
                    game.Add(matchUp);
                }
            }
            return game;
        }

        //Method used to write the data back to the file
        public void WriteGameResults(List<Matchup> MatchupResults) 
        {
            string csvfile = "gameID, Date, Home, Away, Result \n"; 
            foreach (Matchup game in MatchupResults)
            {
                csvfile += game.ID.ToString() + "," + game.Date + "," + game.HomeTeam + "," + game.AwayTeam + "," + game.Result + "\n";
            }

            {
                using (var writer = new StreamWriter(@"../../nbaData/nbaResults.csv")) 
                writer.Write(csvfile);
            }  
        }



    }
}
