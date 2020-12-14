using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of the entire tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Entryfee, can be 0
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// All the competing teams as objects
        /// </summary>
        public List<TeamModel> Teams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// All the prizes in this game as objects
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// A combined list of all Matches
        /// </summary>
        public List<List<MatchModel>> Matches { get; set; } = new List<List<MatchModel>>();

    }
}
