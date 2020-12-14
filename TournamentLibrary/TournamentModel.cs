using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }

        public decimal EntryFee { get; set; }

        public List<TeamModel> Teams { get; set; } = new List<TeamModel>();

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<List<MatchModel>> Matches { get; set; } = new List<List<MatchModel>>();

    }
}
