using FootballClubApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClubApp.DataStore
{
    public class DataRepository : IDataRepository
    {
        public List<ClubTeam> ClubTeams = new List<ClubTeam>();
        public List<TeamPlayer> TeamPlayers = new List<TeamPlayer>();
        public DataRepository()
        {
            ClubTeams.Add(new ClubTeam() { ID = 1, Ranking = 1, NumberOfFans = 323211, Name = "Manchester City", GamePlayed = 32, Win = 23, Draw = 5, Lose = 4, GoalsScore = 67, GoalsAgainst = 23, CurrentPoints = 74 });
            ClubTeams.Add(new ClubTeam() { ID = 2, Ranking = 2, NumberOfFans = 235451, Name = "Manchester United", GamePlayed = 31, Win = 18, Draw = 9, Lose = 9, GoalsScore = 61, GoalsAgainst = 34, CurrentPoints = 63 });
            ClubTeams.Add(new ClubTeam() { ID = 3, Ranking = 3, NumberOfFans = 238727, Name = "Leicester City", GamePlayed = 31, Win = 17, Draw = 5, Lose = 8, GoalsScore = 55, GoalsAgainst = 37, CurrentPoints = 56 });
            ClubTeams.Add(new ClubTeam() { ID = 4, Ranking = 4, NumberOfFans = 235435, Name = "West Ham United", GamePlayed = 31, Win = 16, Draw = 7, Lose = 7, GoalsScore = 51, GoalsAgainst = 39, CurrentPoints = 55 });
            ClubTeams.Add(new ClubTeam() { ID = 5, Ranking = 5, NumberOfFans = 543534, Name = "Chelsea", GamePlayed = 31, Win = 15, Draw = 9, Lose = 9, GoalsScore = 50, GoalsAgainst = 31, CurrentPoints = 54 });
            ClubTeams.Add(new ClubTeam() { ID = 6, Ranking = 6, NumberOfFans = 76423, Name = "Liverpool", GamePlayed = 31, Win = 15, Draw = 7, Lose = 10, GoalsScore = 53, GoalsAgainst = 37, CurrentPoints = 52 });
            ClubTeams.Add(new ClubTeam() { ID = 7, Ranking = 7, NumberOfFans = 23545, Name = "Tottenham Hotspur", GamePlayed = 31, Win = 14, Draw = 7, Lose = 10, GoalsScore = 52, GoalsAgainst = 35, CurrentPoints = 49 });
            ClubTeams.Add(new ClubTeam() { ID = 8, Ranking = 8, NumberOfFans = 67534, Name = "Everton", GamePlayed = 30, Win = 14, Draw = 6, Lose = 4, GoalsScore = 41, GoalsAgainst = 38, CurrentPoints = 48 });
            ClubTeams.Add(new ClubTeam() { ID = 9, Ranking = 9, NumberOfFans = 75464, Name = "Arsenal", GamePlayed = 31, Win = 13, Draw = 6, Lose = 12, GoalsScore = 43, GoalsAgainst = 35, CurrentPoints = 45 });
            ClubTeams.Add(new ClubTeam() { ID = 10, Ranking = 10, NumberOfFans = 42345, Name = "Leeds United", GamePlayed = 31, Win = 14, Draw = 3, Lose = 14, GoalsScore = 49, GoalsAgainst = 49, CurrentPoints = 45 });
            ClubTeams.Add(new ClubTeam() { ID = 11, Ranking = 11, NumberOfFans = 34323, Name = "Aston Villa", GamePlayed = 30, Win = 13, Draw = 5, Lose = 12, GoalsScore = 43, GoalsAgainst = 33, CurrentPoints = 44 });
            ClubTeams.Add(new ClubTeam() { ID = 12, Ranking = 12, NumberOfFans = 65653, Name = "Wolverhampton Wanderers", GamePlayed = 31, Win = 10, Draw = 8, Lose = 13, GoalsScore = 31, GoalsAgainst = 41, CurrentPoints = 38 });
            ClubTeams.Add(new ClubTeam() { ID = 13, Ranking = 13, NumberOfFans = 23455, Name = "Crystal Palace", GamePlayed = 31, Win = 10, Draw = 8, Lose = 13, GoalsScore = 33, GoalsAgainst = 52, CurrentPoints = 38 });
            ClubTeams.Add(new ClubTeam() { ID = 14, Ranking = 14, NumberOfFans = 97856, Name = "Southampton", GamePlayed = 31, Win = 10, Draw = 6, Lose = 15, GoalsScore = 39, GoalsAgainst = 56, CurrentPoints = 36 });
            ClubTeams.Add(new ClubTeam() { ID = 15, Ranking = 15, NumberOfFans = 34536, Name = "Brighton & Hove Albion", GamePlayed = 31, Win = 7, Draw = 12, Lose = 12, GoalsScore = 33, GoalsAgainst = 38, CurrentPoints = 33 });

            LoanPlayerInformation();
        }
        public List<ClubTeam> GetAllTeams()
        {
            return ClubTeams;
        }

        public string GetTeamName(int TeamId)
        {
            return ClubTeams.First(x => x.ID == TeamId).Name;
        }

        public List<TeamPlayer> GetTeamPlayers(int TeamId)
        {
            return TeamPlayers.Where(x => x.TeamId == TeamId)?.ToList();
        }

        private void LoanPlayerInformation()
        {
            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 1, Name = "Ilkay Gündogan", Goals = 16, Assist = 3, Played = 37, TotalShots = 45, GoalConversion = 36, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 1, Name = "Phil Foden", Goals = 13, Assist = 9, Played = 41, TotalShots = 63, GoalConversion = 21, ShotAccuracy = 57 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 1, Name = "Raheem Sterling", Goals = 13, Assist = 9, Played = 41, TotalShots = 64, GoalConversion = 20, ShotAccuracy = 66 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 1, Name = "Gabriel Jesus", Goals = 13, Assist = 3, Played = 33, TotalShots = 43, GoalConversion = 30, ShotAccuracy = 58 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 1, Name = "Riyad Mahrez", Goals = 11, Assist = 7, Played = 41, TotalShots = 60, GoalConversion = 18, ShotAccuracy = 57 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 1, Name = "Ferran Torres", Goals = 9, Assist = 3, Played = 30, TotalShots = 38, GoalConversion = 24, ShotAccuracy = 58 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 1, Name = "Kevin De Bruyne", Goals = 8, Assist = 16, Played = 34, TotalShots = 63, GoalConversion = 13, ShotAccuracy = 49 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 1, Name = "Bernardo Silva", Goals = 5, Assist = 7, Played = 38, TotalShots = 34, GoalConversion = 15, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 1, Name = "John Stones", Goals = 5, Assist = 0, Played = 29, TotalShots = 12, GoalConversion = 42, ShotAccuracy = 59 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 1, Name = "Sergio Agüero", Goals = 3, Assist = 0, Played = 15, TotalShots = 10, GoalConversion = 30, ShotAccuracy = 50 });

            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 2, Name = "Bruno Fernandes", Goals = 24, Assist = 14, Played = 49, TotalShots = 102, GoalConversion = 24, ShotAccuracy = 64 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 2, Name = "Marcus Rashford", Goals = 20, Assist = 10, Played = 48, TotalShots = 78, GoalConversion = 26, ShotAccuracy = 72 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 2, Name = "Edinson Cavani", Goals = 9, Assist = 2, Played = 30, TotalShots = 33, GoalConversion = 27, ShotAccuracy = 55 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 2, Name = "Anthony Martial", Goals = 7, Assist = 5, Played = 36, TotalShots = 49, GoalConversion = 14, ShotAccuracy = 63 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 2, Name = "Mason Greenwood", Goals = 7, Assist = 5, Played = 43, TotalShots = 54, GoalConversion = 13, ShotAccuracy = 50 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 2, Name = "Scott McTominay", Goals = 7, Assist = 1, Played = 42, TotalShots = 25, GoalConversion = 28, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 2, Name = "Paul Pogba", Goals = 5, Assist = 5, Played = 34, TotalShots = 33, GoalConversion = 15, ShotAccuracy = 42 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 2, Name = "Daniel James", Goals = 5, Assist = 1, Played = 23, TotalShots = 17, GoalConversion = 29, ShotAccuracy = 71 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 2, Name = "Juan Mata", Goals = 2, Assist = 3, Played = 13, TotalShots = 10, GoalConversion = 20, ShotAccuracy = 90 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 2, Name = "Aaron Wan-Bissaka", Goals = 2, Assist = 3, Played = 46, TotalShots = 6, GoalConversion = 33, ShotAccuracy = 67 });

            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 3, Name = "Jamie Vardy", Goals = 14, Assist = 7, Played = 33, TotalShots = 58, GoalConversion = 24, ShotAccuracy = 59 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 3, Name = "Kelechi Iheanacho", Goals = 14, Assist = 4, Played = 30, TotalShots = 34, GoalConversion = 41, ShotAccuracy = 65 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 3, Name = "Harvey Barnes", Goals = 13, Assist = 4, Played = 35, TotalShots = 58, GoalConversion = 22, ShotAccuracy = 62 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 3, Name = "James Maddison", Goals = 11, Assist = 7, Played = 33, TotalShots = 56, GoalConversion = 20, ShotAccuracy = 43 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 3, Name = "Youri Tielemans", Goals = 8, Assist = 5, Played = 42, TotalShots = 35, GoalConversion = 23, ShotAccuracy = 63 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 3, Name = "James Justin", Goals = 3, Assist = 1, Played = 31, TotalShots = 10, GoalConversion = 30, ShotAccuracy = 40 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 3, Name = "Ayoze Pérez", Goals = 2, Assist = 0, Played = 27, TotalShots = 22, GoalConversion = 14, ShotAccuracy = 55 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 3, Name = "Cengiz Ünder", Goals = 2, Assist = 3, Played = 19, TotalShots = 25, GoalConversion = 8, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 3, Name = "Dennis Praet", Goals = 1, Assist = 2, Played = 23, TotalShots = 9, GoalConversion = 22, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 3, Name = "Marc Albrighton", Goals = 1, Assist = 6, Played = 33, TotalShots = 17, GoalConversion = 6, ShotAccuracy = 71 });


            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 4, Name = "Tomas Soucek", Goals = 43, Assist = 17, Played = 33, TotalShots = 44, GoalConversion = 24, ShotAccuracy = 65 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 4, Name = "Jarrod Bowen", Goals = 23, Assist = 3, Played = 30, TotalShots = 33, GoalConversion = 41, ShotAccuracy = 44 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 4, Name = "Jesse Lingard", Goals = 23, Assist = 23, Played = 35, TotalShots = 23, GoalConversion = 32, ShotAccuracy = 22 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 4, Name = "Michail Antonio", Goals = 43, Assist = 17, Played = 33, TotalShots = 43, GoalConversion = 20, ShotAccuracy = 23 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 4, Name = "Sébastien Haller", Goals = 28, Assist = 3, Played = 42, TotalShots = 54, GoalConversion = 55, ShotAccuracy = 63 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 4, Name = "Pablo Fornals", Goals = 4, Assist = 32, Played = 31, TotalShots = 43, GoalConversion = 32, ShotAccuracy = 32 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 4, Name = "Craig Dawson", Goals = 6, Assist = 0, Played = 27, TotalShots = 54, GoalConversion = 53, ShotAccuracy = 55 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 4, Name = "Andriy Yarmolenko", Goals = 3, Assist = 23, Played = 19, TotalShots = 66, GoalConversion = 34, ShotAccuracy = 43 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 4, Name = "Robert Snodgrass", Goals = 11, Assist = 2, Played = 23, TotalShots = 19, GoalConversion = 22, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 4, Name = "Angelo Ogbonna", Goals = 1, Assist = 3, Played = 33, TotalShots = 17, GoalConversion = 6, ShotAccuracy = 71 });

            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 5, Name = "Tammy Abraham", Goals = 24, Assist = 14, Played = 49, TotalShots = 102, GoalConversion = 24, ShotAccuracy = 64 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 5, Name = "Olivier Giroud", Goals = 20, Assist = 10, Played = 48, TotalShots = 78, GoalConversion = 26, ShotAccuracy = 72 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 5, Name = "Timo Werner", Goals = 9, Assist = 2, Played = 30, TotalShots = 33, GoalConversion = 27, ShotAccuracy = 55 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 5, Name = "Mason Mount", Goals = 7, Assist = 5, Played = 36, TotalShots = 49, GoalConversion = 14, ShotAccuracy = 63 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 5, Name = "Jorginho", Goals = 7, Assist = 5, Played = 43, TotalShots = 54, GoalConversion = 13, ShotAccuracy = 50 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 5, Name = "Kai Havertz", Goals = 7, Assist = 1, Played = 42, TotalShots = 25, GoalConversion = 28, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 5, Name = "Callum Hudson-Odoi", Goals = 5, Assist = 5, Played = 34, TotalShots = 33, GoalConversion = 15, ShotAccuracy = 42 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 5, Name = "Christian Pulisic", Goals = 5, Assist = 1, Played = 23, TotalShots = 17, GoalConversion = 29, ShotAccuracy = 71 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 5, Name = "Kurt Zouma", Goals = 2, Assist = 3, Played = 13, TotalShots = 10, GoalConversion = 20, ShotAccuracy = 90 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 5, Name = "Hakim Ziyech", Goals = 2, Assist = 3, Played = 46, TotalShots = 6, GoalConversion = 33, ShotAccuracy = 67 });

            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 6, Name = "Mohamed Salah", Goals = 14, Assist = 7, Played = 33, TotalShots = 58, GoalConversion = 24, ShotAccuracy = 59 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 6, Name = "Sadio Mané", Goals = 14, Assist = 4, Played = 30, TotalShots = 34, GoalConversion = 41, ShotAccuracy = 65 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 6, Name = "Diogo Jota", Goals = 13, Assist = 4, Played = 35, TotalShots = 58, GoalConversion = 22, ShotAccuracy = 62 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 6, Name = "Roberto Firmino", Goals = 11, Assist = 7, Played = 33, TotalShots = 56, GoalConversion = 20, ShotAccuracy = 43 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 6, Name = "Curtis Jones", Goals = 8, Assist = 5, Played = 42, TotalShots = 35, GoalConversion = 23, ShotAccuracy = 63 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 6, Name = "Takumi Minamino", Goals = 3, Assist = 1, Played = 31, TotalShots = 10, GoalConversion = 30, ShotAccuracy = 40 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 6, Name = "Georginio Wijnaldum", Goals = 2, Assist = 0, Played = 27, TotalShots = 22, GoalConversion = 14, ShotAccuracy = 55 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 6, Name = "Trent Alexander-Arnold", Goals = 2, Assist = 3, Played = 19, TotalShots = 25, GoalConversion = 8, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 6, Name = "Andrew Robertson", Goals = 1, Assist = 2, Played = 23, TotalShots = 9, GoalConversion = 22, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 6, Name = "Xherdan Shaqiri", Goals = 1, Assist = 6, Played = 33, TotalShots = 17, GoalConversion = 6, ShotAccuracy = 71 });

            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 7, Name = "Harry Kane", Goals = 16, Assist = 3, Played = 37, TotalShots = 45, GoalConversion = 36, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 7, Name = "Son Heung-Min", Goals = 13, Assist = 9, Played = 41, TotalShots = 63, GoalConversion = 21, ShotAccuracy = 57 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 7, Name = "Carlos Vinícius", Goals = 13, Assist = 9, Played = 41, TotalShots = 64, GoalConversion = 20, ShotAccuracy = 66 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 7, Name = "Gareth Bale", Goals = 13, Assist = 3, Played = 33, TotalShots = 43, GoalConversion = 30, ShotAccuracy = 58 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 7, Name = "Lucas Moura", Goals = 11, Assist = 7, Played = 41, TotalShots = 60, GoalConversion = 18, ShotAccuracy = 57 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 7, Name = "Tanguy Ndombele", Goals = 9, Assist = 3, Played = 30, TotalShots = 38, GoalConversion = 24, ShotAccuracy = 58 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 7, Name = "Giovani Lo Celso", Goals = 8, Assist = 16, Played = 34, TotalShots = 63, GoalConversion = 13, ShotAccuracy = 49 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 7, Name = "Erik Lamela", Goals = 5, Assist = 7, Played = 38, TotalShots = 34, GoalConversion = 15, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 7, Name = "Dele Alli", Goals = 5, Assist = 0, Played = 29, TotalShots = 12, GoalConversion = 42, ShotAccuracy = 59 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 7, Name = "Harry Winks", Goals = 3, Assist = 0, Played = 15, TotalShots = 10, GoalConversion = 30, ShotAccuracy = 50 });

            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 8, Name = "Dominic Calvert-Lewin", Goals = 24, Assist = 14, Played = 49, TotalShots = 102, GoalConversion = 24, ShotAccuracy = 64 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 8, Name = "Richarlison", Goals = 20, Assist = 10, Played = 48, TotalShots = 78, GoalConversion = 26, ShotAccuracy = 72 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 8, Name = "Gylfi Sigurdsson", Goals = 9, Assist = 2, Played = 30, TotalShots = 33, GoalConversion = 27, ShotAccuracy = 55 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 8, Name = "James Rodríguez", Goals = 7, Assist = 5, Played = 36, TotalShots = 49, GoalConversion = 14, ShotAccuracy = 63 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 8, Name = "Michael Keane", Goals = 7, Assist = 5, Played = 43, TotalShots = 54, GoalConversion = 13, ShotAccuracy = 50 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 8, Name = "Abdoulaye Doucouré", Goals = 7, Assist = 1, Played = 42, TotalShots = 25, GoalConversion = 28, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 8, Name = "Bernard", Goals = 5, Assist = 5, Played = 34, TotalShots = 33, GoalConversion = 15, ShotAccuracy = 42 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 8, Name = "Yerry Mina", Goals = 5, Assist = 1, Played = 23, TotalShots = 17, GoalConversion = 29, ShotAccuracy = 71 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 8, Name = "Alex Iwobi", Goals = 2, Assist = 3, Played = 13, TotalShots = 10, GoalConversion = 20, ShotAccuracy = 90 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 8, Name = "Moise Kean", Goals = 2, Assist = 3, Played = 46, TotalShots = 6, GoalConversion = 33, ShotAccuracy = 67 });

            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 9, Name = "Alexandre Lacazette", Goals = 24, Assist = 14, Played = 49, TotalShots = 102, GoalConversion = 24, ShotAccuracy = 64 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 9, Name = "Pierre-Emerick Aubameyang", Goals = 20, Assist = 10, Played = 48, TotalShots = 78, GoalConversion = 26, ShotAccuracy = 72 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 9, Name = "Nicolas Pépé", Goals = 9, Assist = 2, Played = 30, TotalShots = 33, GoalConversion = 27, ShotAccuracy = 55 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 9, Name = "Bukayo Saka", Goals = 7, Assist = 5, Played = 36, TotalShots = 49, GoalConversion = 14, ShotAccuracy = 63 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 9, Name = "Eddie Nketiah", Goals = 7, Assist = 5, Played = 43, TotalShots = 54, GoalConversion = 13, ShotAccuracy = 50 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 9, Name = "Joseph Willock", Goals = 7, Assist = 1, Played = 42, TotalShots = 25, GoalConversion = 28, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 9, Name = "Gabriel Magalhães", Goals = 5, Assist = 5, Played = 34, TotalShots = 33, GoalConversion = 15, ShotAccuracy = 42 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 9, Name = "Emile Smith Rowe", Goals = 5, Assist = 1, Played = 23, TotalShots = 17, GoalConversion = 29, ShotAccuracy = 71 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 9, Name = "Kieran Tierney", Goals = 2, Assist = 3, Played = 13, TotalShots = 10, GoalConversion = 20, ShotAccuracy = 90 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 9, Name = "Folarin Balogun", Goals = 2, Assist = 3, Played = 46, TotalShots = 6, GoalConversion = 33, ShotAccuracy = 67 });

            TeamPlayers.Add(new TeamPlayer() { ID = 1, TeamId = 10, Name = "Patrick Bamford", Goals = 14, Assist = 7, Played = 33, TotalShots = 58, GoalConversion = 24, ShotAccuracy = 59 });
            TeamPlayers.Add(new TeamPlayer() { ID = 2, TeamId = 10, Name = "Jack Harrison", Goals = 14, Assist = 4, Played = 30, TotalShots = 34, GoalConversion = 41, ShotAccuracy = 65 });
            TeamPlayers.Add(new TeamPlayer() { ID = 3, TeamId = 10, Name = "Stuart Dallas", Goals = 13, Assist = 4, Played = 35, TotalShots = 58, GoalConversion = 22, ShotAccuracy = 62 });
            TeamPlayers.Add(new TeamPlayer() { ID = 4, TeamId = 10, Name = "Raphinha", Goals = 11, Assist = 7, Played = 33, TotalShots = 56, GoalConversion = 20, ShotAccuracy = 43 });
            TeamPlayers.Add(new TeamPlayer() { ID = 5, TeamId = 10, Name = "Mateusz Klich", Goals = 8, Assist = 5, Played = 42, TotalShots = 35, GoalConversion = 23, ShotAccuracy = 63 });
            TeamPlayers.Add(new TeamPlayer() { ID = 6, TeamId = 10, Name = "Hélder Costa", Goals = 3, Assist = 1, Played = 31, TotalShots = 10, GoalConversion = 30, ShotAccuracy = 40 });
            TeamPlayers.Add(new TeamPlayer() { ID = 7, TeamId = 10, Name = "Rodrigo Moreno", Goals = 2, Assist = 0, Played = 27, TotalShots = 22, GoalConversion = 14, ShotAccuracy = 55 });
            TeamPlayers.Add(new TeamPlayer() { ID = 8, TeamId = 10, Name = "Ezgjan Alioski", Goals = 2, Assist = 3, Played = 19, TotalShots = 25, GoalConversion = 8, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 9, TeamId = 10, Name = "Pascal Struijk", Goals = 1, Assist = 2, Played = 23, TotalShots = 9, GoalConversion = 22, ShotAccuracy = 56 });
            TeamPlayers.Add(new TeamPlayer() { ID = 10, TeamId = 10, Name = "Liam Cooper", Goals = 1, Assist = 6, Played = 33, TotalShots = 17, GoalConversion = 6, ShotAccuracy = 71 });

        }
    }
}