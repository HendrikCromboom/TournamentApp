using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    class MatchModel
    {
        /// <summary>
        /// Represents the matchups that this match is linked to
        /// </summary>
        public List<MatchupModel> Matchups { get; set; } = new List<MatchupModel>();
        /// <summary>
        /// The winner of this match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// What round is this match part of
        /// </summary>
        public int MatchRound { get; set; }



    }
}
