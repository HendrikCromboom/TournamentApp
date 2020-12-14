using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// What placement does this price relate to
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The semantic name of that place
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Flat amount 
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage amount
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
