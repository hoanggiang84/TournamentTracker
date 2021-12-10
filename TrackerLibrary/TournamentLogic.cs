using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Order our list randomly of teams
        // Check if it is big enough - if not, add in byes
        // Create our first round of matchups 
        // Create every round after that
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);
            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));
            CreateOtherRounds(model, rounds);
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();
            for (int r = 2; r <= rounds; r++)
            {
                foreach (var match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });
                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = r;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchupModel>();
            }
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> matchups = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();
            foreach (var team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });
                if(byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    matchups.Add(curr);
                    curr = new MatchupModel();

                    if (byes > 0)
                    {
                        byes--;
                    }
                }
            }
            return matchups;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int totalTeams = 1;
            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            return totalTeams - numberOfTeams;
        }
        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;
            while (val <teamCount)
            {
                val *= 2;
                output++;
            }

            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(t => Guid.NewGuid()).ToList();
        }
    }
}
