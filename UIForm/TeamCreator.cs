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

    public partial class TeamCreator : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetAllPersons();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public TeamCreator(ITeamRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();
            wireUpLists();
            callingForm = caller;
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Giang", LastName = "Hoang" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }

        private void wireUpLists()
        {
            comboBoxTeamMember.DataSource = null;
            comboBoxTeamMember.DataSource = availableTeamMembers;
            comboBoxTeamMember.DisplayMember = "FullName";

            listBoxTournamentPlayers.DataSource = null;
            listBoxTournamentPlayers.DataSource = selectedTeamMembers;
            listBoxTournamentPlayers.DisplayMember = "FullName";
        }
        private void buttonCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = textBoxNewMemberFirstName.Text;
                p.LastName = textBoxNewMemberLastName.Text;
                p.EmailAddress = textBoxNewMemberEmail.Text;
                p.CellphoneNumber = textBoxNewMemberPhoneNumber.Text;

                p = GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                wireUpLists();
                textBoxNewMemberFirstName.Clear();
                textBoxNewMemberLastName.Clear();
                textBoxNewMemberEmail.Clear();
                textBoxNewMemberPhoneNumber.Clear();
            }
            else
            {
                MessageBox.Show("You need to fill all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            // Add validation for create member method
            if (string.IsNullOrWhiteSpace(textBoxNewMemberFirstName.Text))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNewMemberLastName.Text))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNewMemberEmail.Text))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNewMemberPhoneNumber.Text))
            {
                return false;
            }

            return true;
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            PersonModel model = (PersonModel)comboBoxTeamMember.SelectedItem;
            
            if (model != null)
            {
                availableTeamMembers.Remove(model);
                selectedTeamMembers.Add(model);
                wireUpLists(); 
            }
        }

        private void buttonRemoveSelectedPlayer_Click(object sender, EventArgs e)
        {
            PersonModel model = (PersonModel)listBoxTournamentPlayers.SelectedItem;

            if (model != null)
            {
                availableTeamMembers.Add(model);
                selectedTeamMembers.Remove(model);
                wireUpLists(); 
            }
        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel model = new TeamModel();
            model.TeamName = textBoxTeamName.Text;
            model.TeamMembers = selectedTeamMembers;
            GlobalConfig.Connection.CreateTeam(model);
            callingForm.TeamComplete(model);
            this.Close();
                
        }
    }
}
