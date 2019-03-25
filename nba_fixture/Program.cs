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
            Filehandler test = new Filehandler();
            List<Matchup> matchups = test.ReadMatches();
            matchups.First().Result="test";     
            test.WriteGameResults(matchups);

            Filehandler id = new Filehandler();
            List<Matchup> matchups02 = id.ReadMatches();
            foreach (Matchup in matchups02)
            {
                Console.WriteLine(ID++);
            }



            //    ////Import and parse CSV data

            //    ////appending new columns to data
            //    //List<string> gameNumberColumn = new List<string>() { "GameNumberData" };
            //    //List<string> resultsColumn = new List<string>() { "ResultsData" };

            //    ////add new column to the header row
            //    //gameNumberColumn[0] += "gameNumber";
            //    //int index = 1;

            //    //gameNumberColumn.Skip(1).ToList().ForEach(line =>
            //    //{
            //    //    gameNumberColumn[index] += "," + game[index - 1];
            //    //    index++;
            //    //});

            //    // new content is added here
            //    for (int i = 0; i < game.Count; i++)
            //    {
            //        var game_data = game[i];
            //        Console.WriteLine(game_data.Date + " " + game_data.HomeTeam + "  vs  " + game_data.AwayTeam + "  @  " + game_data.Stadium);
            //    }

            //    Console.WriteLine("Type a number to select a matchup");
            //        var matchup = Console.ReadLine();
            //        Console.ReadLine();

            //        //appending new columns to data
            //        List<string> gameNumberColumn = new List<string>() { "GameNumberData" };
            //        List<string> resultsColumn = new List<string>() { "ResultsData" };

            //        //add new column to the header row
            //        gameNumberColumn[0] += "gameNumber";
            //        int index = 1;

            //        gameNumberColumn.Skip(1).ToList().ForEach(line =>
            //        {
            //            gameNumberColumn[index] += "," + game[index - 1];
            //            index++;
            //        });


            //}



        }
    }
}