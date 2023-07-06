using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team = TrackerLibrary.Models.TeamModel;
using Matchup = TrackerLibrary.Models.MatchupModel;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team in the matchup
    /// </summary>
    public class MatchupGameModel
    {
        public Team TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score of that Team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup this team came
        /// from as the winner
        /// </summary>
        public Matchup ParentMatchup { get; set; }

    }
}
