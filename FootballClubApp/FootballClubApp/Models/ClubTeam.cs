using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClubApp.Models
{
    public class ClubTeam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int GamePlayed { get; set; }
        public int Win { get; set; }
        public int Lose { get; set; }
        public int Draw { get; set; }
        public int GoalsScore { get; set; }
        public int GoalsAgainst { get; set; }
        public int CurrentPoints { get; set; }
    }
}