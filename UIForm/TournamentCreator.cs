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
    public partial class TournamentCreator : Form
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
            TeamModel t = (TeamModel)comboBoxSelectTeam.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                wireUpLists();
            }
        }

        private void buttonRemoveSelectedTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)listBoxTournamentTeams.SelectedItem;

            if (t != null)
            {
                availableTeams.Add(t);
                selectedTeams.Remove(t);
                wireUpLists();
            }
        }
    }
}
