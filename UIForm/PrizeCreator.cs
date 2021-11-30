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

namespace UIForm
{
    public partial class PrizeCreator : Form
    {
        public PrizeCreator()
        {
            InitializeComponent();
        }

        private void buttonCreatePrize_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PrizeModel model = new PrizeModel(
                    textBoxPlaceName.Text, 
                    textBoxPlaceNumber.Text, 
                    textBoxPrizeAmount.Text, 
                    textBoxPrizePercentage.Text);
                foreach (var db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                textBoxPlaceName.Clear();
                textBoxPlaceNumber.Clear();
                textBoxPrizeAmount.Text = "0.0";
                textBoxPrizePercentage.Text = "0.0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
            }
        }

        private bool validateForm()
        {
            bool output = true;
            bool placeNumberValid = int.TryParse(textBoxPlaceNumber.Text, out int placeNumber);
            if (placeNumberValid == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (string.IsNullOrEmpty(textBoxPlaceName.Text))
            {
                output = false;
            }

            bool prizeAmountValid = decimal.TryParse(textBoxPrizeAmount.Text, out decimal prizeAmount);
            bool prizePercentageValid = double.TryParse(textBoxPrizePercentage.Text, out double prizePercentage);

            if (prizeAmountValid == false)
            {
                output = false;
            }

            if (prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0.0)
            {
                output = false;
            }

            if (prizePercentage < 0.0 || prizePercentage > 100.0)
            {
                output = false;
            }

            return output;
        }

        private void radioButtonAmount_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrizeAmount.Enabled = radioButtonAmount.Checked;
            textBoxPrizePercentage.Enabled = radioButtonPercentage.Checked;
        }

        private void radioButtonPercentage_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrizeAmount.Enabled = radioButtonAmount.Checked;
            textBoxPrizePercentage.Enabled = radioButtonPercentage.Checked;
        }
    }
}
