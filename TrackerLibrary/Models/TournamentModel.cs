using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team = TrackerLibrary.Models.TeamModel;
using Prize = TrackerLibrary.Models.PrizeModel;
using Matchup = TrackerLibrary.Models.MatchupModel;


namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        //   public string tournamentId { get; set; } // incase we need it
        public string TournamentName { get; set; }
        /// <summary>
        /// Number of players in the tournament 
        /// </summary>
        public int NumberOfPlayers { get; set; }
        /// <summary>
        /// Entry fee for each team
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams who can play in this tournament
        /// </summary>
        public List<Team> QualifiedTeams { get; set; } = new List<Team>();
        public List<Prize> Prizes { get; set; } = new List<Prize>();
        /// <summary>
        /// Rounds and each game in the round 
        /// </summary>
        public List<List<Matchup>> Rounds { get; set; }

    }
}
