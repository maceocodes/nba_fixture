using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nba_fixture
{
    class Filehandler
    { ////Import and parse CSV data
        public List<Matchup> ReadMatches()
        {
            List<Matchup> game = new List<Matchup>();
            using (var reader = new StreamReader(@"../../nbaData/nba_datasetTEST.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');

                    var matchUp = new Matchup
                    {
                        Date = data[0],
                        HomeTeam = data[2],
                        AwayTeam = data[3],
                        Stadium = data[1]
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
