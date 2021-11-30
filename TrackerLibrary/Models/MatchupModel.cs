using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner;
        public int MatchupRound { get; set; }
    }
}