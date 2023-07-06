using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team = TrackerLibrary.Models.TeamModel;
using MatchupGame = TrackerLibrary.Models.MatchupGameModel;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a match between two or more teams
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Competing teams in this matchup represented in a list
        /// </summary>
        public List<MatchupGame> Games { get; set; } = new List<MatchupGame>();
        /// <summary>
        /// Matchup winner
        /// </summary>
        public Team Winner { get; set; }
        public int MatchupRound { get; set; }


    }
}
