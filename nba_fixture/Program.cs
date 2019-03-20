using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nba_fixture
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Import and parse CSV data


            using (var reader = new StreamReader(@"../../nbaData/nba_dataset.csv"))
             
            {
                List<Matchup> game = new List<Matchup>();
                while (!reader.EndOfStream)
                {
                    reader.Columns.Add("newRow", typeof(System.Int32));
                    var line = reader.ReadLine();
                    var data = line.Split(',');

                    var matchUp = new Matchup
                    {
                        Date = data[0],
                        HomeTeam = data[2],
                        AwayTeam = data[3],
                    };

                    game.Add(matchUp);

                }
                for (int i = 0; i < game.Count; i++)
                {
                    var game_data = game[i];
                    Console.WriteLine(game_data.Date + " " + game_data.HomeTeam + "  VS  " + game_data.AwayTeam + " " + game_data.Stadium);
                }

                Console.WriteLine("Type a number to select a matchup");
                var matchup = Console.ReadLine();
                Console.ReadLine();
            }

        }
    }
}