using FootballClubApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClubApp.DataStore
{
    public class DataRepository :IDataRepository
    {
        public List<ClubTeam> ClubTeams = new List<ClubTeam>();
        public List<TeamPlayer> TeamPlayers = new List<TeamPlayer>();
        public DataRepository()
        {
            ClubTeams.Add(new ClubTeam() { ID = 1, Name = "Manchester City", GamePlayed = 32, Win = 23, Draw = 5, Lose = 4, GoalsScore = 67, GoalsAgainst = 23, CurrentPoints = 74 });
            ClubTeams.Add(new ClubTeam() { ID = 2, Name = "Manchester United", GamePlayed = 31, Win = 18, Draw = 9, Lose = 9, GoalsScore = 61, GoalsAgainst = 34, CurrentPoints = 63 });
            ClubTeams.Add(new ClubTeam() { ID = 3, Name = "Leicester City", GamePlayed = 31, Win = 17, Draw = 5, Lose = 8, GoalsScore = 55, GoalsAgainst = 37, CurrentPoints = 56 });
            ClubTeams.Add(new ClubTeam() { ID = 4, Name = "West Ham United", GamePlayed = 31, Win = 16, Draw = 7, Lose = 7, GoalsScore = 51, GoalsAgainst = 39, CurrentPoints = 55 });
            ClubTeams.Add(new ClubTeam() { ID = 5, Name = "Chelsea", GamePlayed = 31, Win = 15, Draw = 9, Lose = 9, GoalsScore = 50, GoalsAgainst = 31, CurrentPoints = 54 });
            ClubTeams.Add(new ClubTeam() { ID = 6, Name = "Liverpool", GamePlayed = 31, Win = 15, Draw = 7, Lose = 10, GoalsScore = 53, GoalsAgainst = 37, CurrentPoints = 52 });
            ClubTeams.Add(new ClubTeam() { ID = 7, Name = "Tottenham Hotspur", GamePlayed = 31, Win = 14, Draw = 7, Lose = 10, GoalsScore = 52, GoalsAgainst = 35, CurrentPoints = 49 });
            ClubTeams.Add(new ClubTeam() { ID = 8, Name = "Everton", GamePlayed = 30, Win = 14, Draw = 6, Lose = 4, GoalsScore = 41, GoalsAgainst = 38, CurrentPoints = 48 });
            ClubTeams.Add(new ClubTeam() { ID = 9, Name = "Arsenal", GamePlayed = 31, Win = 13, Draw = 6, Lose = 12, GoalsScore = 43, GoalsAgainst = 35, CurrentPoints = 45 });
            ClubTeams.Add(new ClubTeam() { ID = 10, Name = "Leeds United", GamePlayed = 31, Win = 14, Draw = 3, Lose = 14, GoalsScore = 49, GoalsAgainst = 49, CurrentPoints = 45 });
            ClubTeams.Add(new ClubTeam() { ID = 11, Name = "Aston Villa", GamePlayed = 30, Win = 13, Draw = 5, Lose = 12, GoalsScore = 43, GoalsAgainst = 33, CurrentPoints = 44 });
            ClubTeams.Add(new ClubTeam() { ID = 12, Name = "Wolverhampton Wanderers", GamePlayed = 31, Win = 10, Draw = 8, Lose = 13, GoalsScore = 31, GoalsAgainst = 41, CurrentPoints = 38 });
            ClubTeams.Add(new ClubTeam() { ID = 13, Name = "Crystal Palace", GamePlayed = 31, Win = 10, Draw = 8, Lose = 13, GoalsScore = 33, GoalsAgainst = 52, CurrentPoints = 38 });
            ClubTeams.Add(new ClubTeam() { ID = 14, Name = "Southampton", GamePlayed = 31, Win = 10, Draw = 6, Lose = 15, GoalsScore = 39, GoalsAgainst = 56, CurrentPoints = 36 });
            ClubTeams.Add(new ClubTeam() { ID = 15, Name = "Brighton & Hove Albion", GamePlayed = 31, Win = 7, Draw = 12, Lose = 12, GoalsScore = 33, GoalsAgainst = 38, CurrentPoints = 33 });
        }
        public List<ClubTeam> GetAllTeams()
        {
            return ClubTeams;
        }

    }
}