using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace nba_fixture
{
    public class Matchup
    {
        public string Date { get; set; }
        public string Stadium { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Result { get; set; }
        public int ID { get; set; }
        

        public void printMatchups()
        {
            var matchups = ID.ToString() + "," + Date + "," + HomeTeam + "," + AwayTeam + "," + Stadium + "," + Result + "\n";
            Console.WriteLine(matchups);
        }




    }
}

