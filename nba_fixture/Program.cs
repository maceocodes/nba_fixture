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

            using (StreamReader sr = new StreamReader(@"../../nbaData/nba_dataset.csv"))
            {
                string headerLine = sr.ReadLine();
                List<string> game = new List<string>();
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    List<string> myList = game.Split(',').ToList();
                    game.Add(line);
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
