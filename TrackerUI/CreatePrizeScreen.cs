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
using TrackerLibrary.DB_Connection;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeScreen : Form
    {
        public CreatePrizeScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate the form and send it to the database - DONE
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    rankTextBox.Text,
                    rankNameTextBox.Text,
                    prizeAmountTextBox.Text,
                    prizePercentageTextBox.Text);

                /*/ deprecated as we only have one connection at a time 
                foreach (IDataConnection db in GlobalConfig.Connections) // (var db in Globa... etc) works just fine
                {
                    // save the data into each data-option we have, in this case SQL & textfile
                    db.CreatePrize(model);
                }
                */
                GlobalConfig.Connections.CreatePrize(model);

                // clear the data fields in the form
                rankTextBox.Text = "";
                rankNameTextBox.Text = "";
                prizeAmountTextBox.Text = "0";
                prizePercentageTextBox.Text = "0";
                // display success message 
                MessageBox.Show("Prize created!", "Success!");

            }
            else
            {
                // display some error message
                MessageBox.Show("Please ensure that you've entered the data correctly and try again!", "Error!");
            }
        }

        private bool ValidateForm()
        {
            bool valid = true;

            // Rank field validation
            int rankNumber = 0;
            bool validateRankIsNumber = int.TryParse(rankTextBox.Text, out rankNumber);
            if (!validateRankIsNumber)
            {
                valid = false;
            }
            if (rankNumber < 1)
            {
                valid = false;
            }

            // Rank Name field validation
            string rankName = rankNameTextBox.Text;
            if (rankName.IsNullOrWhiteSpace())
            {
                valid = false;
            }

            // Prize Amount & Prize Percentage fields validation
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool validateAmountIsNumber = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool validatePercentageIsNumber =
                double.TryParse(prizePercentageTextBox.Text, out prizePercentage);


            if (!validateAmountIsNumber)
            {
                valid = false;
            }

            if (!validatePercentageIsNumber)
            {
                valid = false;
            }

            if (prizeAmount <= 0 && prizePercentage < 0)
            {
                valid = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                valid = false;
            }

            return valid;
        }
    }
}
