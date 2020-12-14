using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// All the Persons who are in this team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; };
    }
}
