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

            string[] game = File.ReadAllLines(@"../../nbaData/nba_dataset.csv");

            for (int i = 0; i < game.Length; i++)
            {
                Console.WriteLine(game[i]);
            }

            Console.ReadLine();

        }
    }
}
