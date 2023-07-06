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

namespace TrackerUI
{
    public partial class CreateTeamScreen : Form
    {
        public CreateTeamScreen()
        {
            InitializeComponent();
        }

        private void teamMembersLabel_Click(object sender, EventArgs e)
        {

        }

        private void memberNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void createNewMemberButton_Click(object sender, EventArgs e)
        {
            // validate the member/person input fields
            if(createNewMemberValidator())
            {
                PersonModel model = new PersonModel(
                    memberNameTextBox.Text,
                    memberLastNameTextBox.Text,
                    memberPhoneTextBox.Text,
                    memberEmailTextBox.Text
                    );
                // save the data to the PersonModel
                GlobalConfig.PersonConnection.CreatePerson(model);
                // clear the fields on the form
                memberNameTextBox.Text = ""; // cleared
                memberLastNameTextBox.Text = ""; // cleared
                memberPhoneTextBox.Text = ""; // cleared
                memberEmailTextBox.Text = ""; // cleared
                // show success message or error message based on validation
                MessageBox.Show("Member Created Successfully!", "Success!");
            }
            else
            {
                MessageBox.Show("Please ensure that you've entered the data correctly and try again!", "Error!");

            }
        }

        /// <summary>
        /// check input data
        /// </summary>
        /// <returns>return true if vaild false if not</returns>
        private bool createNewMemberValidator()
        {
            /// <summary> 
            /// validate if any field returns True as being empty, this will result in True and then
            /// we reach execution of the if path 
            /// </summary>
            bool isEmpty = memberNameTextBox.Text.IsNullOrWhiteSpace()
                || memberLastNameTextBox.Text.IsNullOrWhiteSpace()
                || memberPhoneTextBox.Text.IsNullOrWhiteSpace()
                || memberEmailTextBox.Text.IsNullOrWhiteSpace();
            if (isEmpty)
            {
                return false;
            }
            return true;
        }
    }
}
