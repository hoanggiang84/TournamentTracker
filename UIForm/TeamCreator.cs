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
        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMebers = new List<PersonModel>();  

        public TeamCreator()
        {
            InitializeComponent();
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

                GlobalConfig.Connection.CreatePerson(p);

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
    }
}
