namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that 
        /// this team come from as a winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}