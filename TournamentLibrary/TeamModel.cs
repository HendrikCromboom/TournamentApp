﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class TeamModel
    {
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        public string TeamName { get; set; };
    }
}
