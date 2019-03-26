using System;
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
            using (var reader = new StreamReader(@"../../nbaData/nba_datasetTEST.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');

                    int gameID = 0;
                    if (Int32.TryParse(data[0], out gameID) ==false)
                    {
                        Console.WriteLine("Invalid game ID");
                        return new List<Matchup>();
                    }
                        var matchUp = new Matchup
                    {   
                        ID = gameID,
                        Date = data[1],
                        HomeTeam = data[3],
                        AwayTeam = data[4],
                        Stadium = data[2],
                    };
                    game.Add(matchUp);
                }
            }
            return game;
        }

        public void WriteGameResults(List<Matchup> MatchupResults)
        {
            string csvfile = "";
            foreach (Matchup game in MatchupResults)
            {
                csvfile += game.ID.ToString() + "," + game.Date + "," + game.HomeTeam + "," + game.AwayTeam + "," + game.Stadium + "," + game.Result + "\n";
            }

            using (var writer = new StreamWriter(@"../../nbaData/nba_datasetTEST.csv"))
            {
                writer.Write(csvfile);
            }  
        }



    }
}
