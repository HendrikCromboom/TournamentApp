using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents one of the teams competing in a match
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// The score of this team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the match that this team competed in
        /// </summary>
        public MatchModel ParentMatch { get; set; }
    }
}
