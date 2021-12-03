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

        public TeamCreator()
        {
            InitializeComponent();
            //CreateSampleData();
            wireUpLists();
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
            // TODO - Add validation for create member method
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
            PersonModel p = (PersonModel)comboBoxTeamMember.SelectedItem;
            
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                wireUpLists(); 
            }
        }

        private void buttonRemoveSelectedPlayer_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)listBoxTournamentPlayers.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);
                wireUpLists(); 
            }
        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = textBoxTeamName.Text;
            t.TeamMembers = selectedTeamMembers;
            GlobalConfig.Connection.CreateTeam(t);
                
        }
    }
}
