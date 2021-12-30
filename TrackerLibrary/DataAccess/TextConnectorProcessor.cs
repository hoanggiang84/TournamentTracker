using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> prizes = new List<PrizeModel>();
            foreach (var line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                prizes.Add(p);
            }

            return prizes;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> prizes, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (var p in prizes)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> personModels = new List<PersonModel>();
            foreach (var line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];

                personModels.Add(p);
            }

            return personModels;
        }

        public static void SaveToPersonFile(this List<PersonModel> personModels, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (var p in personModels)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellphoneNumber }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            // id, team name, list of ids separated by pipe
            // E.g: 2, Tim's team, 1|2|4
            List<TeamModel> teams = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel tm = new TeamModel();
                tm.Id = int.Parse(cols[0]);
                tm.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');
                foreach (string id in personIds)
                {
                    tm.TeamMembers.Add(people.Where(p => p.Id == int.Parse(id)).First());
                }

                teams.Add(tm);
            }

            return teams;
        }

        public static void SaveToTeamFile(this List<TeamModel> teams, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (var tm in teams)
            {
                string line = $"{ tm.Id },{ tm.TeamName }, {ConvertPeopleListToIdString(tm.TeamMembers)}";
                lines.Add(line);
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToIdString(List<PersonModel> people)
        {
            if (people.Count == 0)
            {
                return string.Empty;
            }

            string output = string.Empty;
            foreach (var p in people)
            {
                output += $"{ p.Id }|";
            }

            return output.Substring(0, output.Length - 1);
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, 
            string teamFileName,
            string peopleFileName,
            string prizeFileName,
            string matchupFileName)
        {
            // id,TournamentName,EntryFee,(id|id|id - Entered teams), (id|id|id - Prizes),(Rounds - id^id^id|id^id^id|id^id^id)
            List<TournamentModel> tournaments = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = matchupFileName.FullFilePath().LoadFile().ConvertToMatchupModels();
            foreach (var line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                // Entered teams
                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(t => t.Id == int.Parse(id)).First());
                }

                // Prizes
                string[] prizeIds = cols[4].Split('|');
                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(p => p.Id == int.Parse(id)).First());
                }

                // TODO - Capture Rounds information
                string[] rounds = cols[5].Split('|');
                
                foreach (var round in rounds)
                {
                    string[] matchupText = round.Split('^');
                    List<MatchupModel> ms = new List<MatchupModel>();
                    foreach (var matchupId in matchupText)
                    {
                        ms.Add(matchups.Where(m => m.Id == int.Parse(matchupId)).First());
                    }
                    tm.Rounds.Add(ms);
                }
                tournaments.Add(tm);
            }
            return tournaments;
        }

        public static void SaveRoundsToFile(this TournamentModel model, string matchupFile, string matchupEntryFile)
        {
            // Loop through each round
            // Loop through each matchup
            // Get the id of the new matchup and save the record
            // Loop through each Entry, get the id and save it
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    // Load all the matchups from file
                    // Get the top id and add one
                    // Store the id 
                    // Save the matchup record
                    matchup.SaveToMatchupFile(matchupFile, matchupEntryFile);


                }

            }
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<TeamModel> teamModels = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PeopleFile);
            return teamModels.Where(t => t.Id == id).First();
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            return matchups.Where(m => m.Id == id).First();
        }


        public static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(this string entryIds)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<MatchupEntryModel> allEntries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            string[] ids = entryIds.Split('|');
            foreach (var id in ids)
            {
                output.Add(allEntries.Where(e => e.Id == int.Parse(id)).First());
            }
            return output;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            foreach (var line in lines)
            {
                string[] cols = line.Split(',');
                MatchupEntryModel entry = new MatchupEntryModel();
                entry.Id = int.Parse(cols[0]);
                if (string.IsNullOrWhiteSpace(cols[1]))
                    entry.TeamCompeting = null;
                else
                    entry.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                entry.Score = double.Parse(cols[2]);

                if (int.TryParse(cols[3], out int matchupId))
                {
                    entry.ParentMatchup = LookupMatchupById(matchupId);
                }
                else
                {
                    entry.ParentMatchup = null;
                }

                output.Add(entry);
            }

            return output;
        }

        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            // id, entries, winner, matchupRound
            List<MatchupModel> output = new List<MatchupModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupModel matchup = new MatchupModel();
                // id
                matchup.Id = int.Parse(cols[0]);

                // entries
                matchup.Entries = cols[1].ConvertStringToMatchupEntryModels();

                // winner
                if (string.IsNullOrWhiteSpace(cols[2]))
                    matchup.Winner = null;
                else
                    matchup.Winner = LookupTeamById(int.Parse(cols[2]));

                // matchup round
                matchup.MatchupRound = int.Parse(cols[3]);

                output.Add(matchup);
            }
            return output;
        }

        public static void SaveToMatchupEntryFile(this MatchupEntryModel entry, string fileName)
        {
            List<MatchupEntryModel> matchupEntries = new List<MatchupEntryModel>();
            int currentId = 1;
            if (matchupEntries.Count > 0)
            {
                currentId = matchupEntries.OrderByDescending(m => m.Id).First().Id + 1;
            }

            entry.Id = currentId;
            matchupEntries.Add(entry);

            // save to file
            List<string> lines = new List<string>();
            foreach (var e in matchupEntries)
            {
                string parent = string.Empty;
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = string.Empty;
                if(e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                string line = $"{ e.Id },{ teamCompeting },{ e.Score },{ parent }";
                lines.Add(line);
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToMatchupFile(this MatchupModel matchup, string matchupFileName, string matchupEntryFile)
        {
            List<MatchupModel> matchups = matchupFileName.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;
            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(m => m.Id).First().Id + 1;
            }

            matchup.Id = currentId;

            matchups.Add(matchup);

            foreach (MatchupEntryModel entryModel in matchup.Entries)
            {
                entryModel.SaveToMatchupEntryFile(matchupEntryFile);
            }

            // save to file
            List<string> lines = new List<string>();
            foreach (var m in matchups)
            {
                string winner = string.Empty;
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                // id, entries(id|id|..), winner, matchupRound
                lines.Add($"{ m.Id },{ConvertMatchupEntryListToIdString(m.Entries)},{winner},{m.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);

        }



        public static void SaveToTournamentFile(this List<TournamentModel> tournaments, string fileName)
        {
            List<string> lines = new List<string>();
            // id,TournamentName,EntryFee,(id|id|id - Entered teams), (id|id|id - Prizes),(Rounds - id^id^id|id^id^id|id^id^id)
            foreach (var tm in tournaments)
            {
                lines.Add($@"{ tm.Id },{ tm.TournamentName },{ tm.EntryFee },{ ConvertTeamListToIdString(tm.EnteredTeams) },{ ConvertPrizeListToIdString(tm.Prizes) },{ ConvertRoundsToIdString(tm.Rounds) }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertRoundsToIdString(List<List<MatchupModel>> rounds)
        {
            // Rounds - id^id^id|id^id^id|id^id^id
            if (rounds.Count < 0)
            {
                return string.Empty;
            }

            string output = string.Empty;
            foreach (var r in rounds)
            {
                output += $"{ ConvertMatchupsToIdString(r) }|";
            }

            return output.Substring(0, output.Length - 1);
        }

        private static string ConvertMatchupsToIdString(List<MatchupModel> matchups)
        {
            // Matchups - id^id^id
            if (matchups.Count == 0)
            {
                return string.Empty;
            }

            string output = string.Empty;
            foreach (var m in matchups)
            {
                output += $"{ m.Id }^";
            }

            return output.Substring(0, output.Length - 1);
        }

        private static string ConvertTeamListToIdString(List<TeamModel> teams)
        {
            if (teams.Count == 0)
            {
                return string.Empty;
            }

            string output = string.Empty;
            foreach (var t in teams)
            {
                output += $"{ t.Id }|";
            }

            return output.Substring(0, output.Length - 1);
        }

        private static string ConvertPrizeListToIdString(List<PrizeModel> prizes)
        {
            if (prizes.Count == 0)
            {
                return string.Empty;
            }

            string output = string.Empty;
            foreach (var p in prizes)
            {
                output += $"{ p.Id }|";
            }

            return output.Substring(0, output.Length - 1);
        }
        private static string ConvertMatchupEntryListToIdString(List<MatchupEntryModel> entries)
        {
            if (entries.Count == 0)
            {
                return string.Empty;
            }

            string output = string.Empty;
            foreach (var p in entries)
            {
                output += $"{ p.Id }|";
            }

            return output.Substring(0, output.Length - 1);
        }
    }
}
