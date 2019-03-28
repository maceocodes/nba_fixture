using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace nba_fixture
{
    //Class that models data in the list
    public class Matchup
    {
        public string Date { get; set; }
        public string Stadium { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Result { get; set; }
        public int ID { get; set; }
        

        public void printMatchup()
        {
            var matchups = ID.ToString() + " - " + Date + "  " + HomeTeam + "  @  " + AwayTeam + "  " + Result + "\n";
            Console.WriteLine(matchups);
        }




    }
}

