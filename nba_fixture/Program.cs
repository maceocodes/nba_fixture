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
                List<string> game = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');
                    game.AddRange(data);
                }

                for (int i = 0; i < game.Count; i++)
                {
                    Console.WriteLine(game[i]);
                }
                Console.ReadLine();
            }

        }
    }
}