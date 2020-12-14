using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class MatchupModel
    {

        public TeamModel TeamCompeting { get; set; }

        public double Score { get; set; }

        public MatchModel ParentMatch { get; set; }
    }
}
