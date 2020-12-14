using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    class MatchModel
    {
        public List<MatchupModel> Matchups { get; set; } = new List<MatchupModel>();

        public TeamModel Winner { get; set; }

        public int MatchRound { get; set; }



    }
}
