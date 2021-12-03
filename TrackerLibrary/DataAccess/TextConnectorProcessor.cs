﻿using System;
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
                tm.Name = cols[1];

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
                string line = $"{ tm.Id },{ tm.Name }, {ConvertPeopleListToIdString(tm.TeamMembers)}";
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
    }
}
