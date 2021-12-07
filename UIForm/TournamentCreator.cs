using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace UIForm
{
    public partial class TournamentCreator : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetAllTeams();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public TournamentCreator()
        {
            InitializeComponent();
            wireUpLists();
        }

        private void wireUpLists()
        {
            comboBoxSelectTeam.DataSource = null;
            comboBoxSelectTeam.DataSource = availableTeams;
            comboBoxSelectTeam.DisplayMember = "TeamName";

            listBoxTournamentTeams.DataSource = null;
            listBoxTournamentTeams.DataSource = selectedTeams;
            listBoxTournamentTeams.DisplayMember = "TeamName";

            listBoxPrizes.DataSource = null;
            listBoxPrizes.DataSource = selectedPrizes;
            listBoxPrizes.DisplayMember = "PlaceName";
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            TeamModel model = (TeamModel)comboBoxSelectTeam.SelectedItem;

            if (model != null)
            {
                availableTeams.Remove(model);
                selectedTeams.Add(model);
                wireUpLists();
            }
        }

        private void buttonRemoveSelectedTeam_Click(object sender, EventArgs e)
        {
            TeamModel model = (TeamModel)listBoxTournamentTeams.SelectedItem;

            if (model != null)
            {
                availableTeams.Add(model);
                selectedTeams.Remove(model);
                wireUpLists();
            }
        }

        private void buttonCreatePrize_Click(object sender, EventArgs e)
        {
            PrizeCreator prizeCreator = new PrizeCreator(this);
            prizeCreator.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            wireUpLists();
        }

        private void linkLabelCreateNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeamCreator teamCreator = new TeamCreator(this);
            teamCreator.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            wireUpLists();
        }

        private void buttonRemovePrize_Click(object sender, EventArgs e)
        {
            PrizeModel model = (PrizeModel)listBoxPrizes.SelectedItem;

            if(model != null)
            {
                selectedPrizes.Remove(model);
                wireUpLists();
            }
                 
        }

        private void buttonCreateTournament_Click(object sender, EventArgs e)
        {
            // Create tournament model
            bool validEntryFee = decimal.TryParse(textBoxEntryFee.Text, out decimal entryFee);
            if (validEntryFee == false)
            {
                MessageBox.Show("You need to enter a valid entry fee.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tm  = new TournamentModel();
            tm.TournamentName = textBoxTournamentName.Text;
            tm.EntryFee = entryFee;

            tm.Prizes.AddRange(selectedPrizes);
            tm.EnteredTeams.AddRange(selectedTeams);

            // TODO - Create our matchups

            // Create Tournament entry
            // Create all the prize entries
            // Create all team entries
            GlobalConfig.Connection.CreateTournament(tm);

            
        }
    }
}
