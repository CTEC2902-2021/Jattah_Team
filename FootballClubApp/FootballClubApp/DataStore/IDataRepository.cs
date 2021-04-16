using FootballClubApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClubApp.DataStore
{
    public interface IDataRepository
    {
        List<ClubTeam> GetAllTeams();
        List<TeamPlayer> GetTeamPlayers(int TeamId);
        string GetTeamName(int TeamId);
    }
}