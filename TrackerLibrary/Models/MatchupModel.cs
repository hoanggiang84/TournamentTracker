﻿using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        public TeamModel Winner;
        public int MatchupRound { get; set; }
    }
}