namespace TrackerUI
{
    partial class CreateTeamScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamScreen));
            membersDropDown = new ComboBox();
            selectMemberLabel = new Label();
            teamNameLabel = new Label();
            deleteMemberButton = new Button();
            teamMembersListBox = new ListBox();
            teamMembersLabel = new Label();
            createNewMemberLabel = new Label();
            createTeamScreenLabel = new Label();
            memberNameTextBox = new TextBox();
            memberFirstNameLabel = new Label();
            memberPhoneTextBox = new TextBox();
            memberPhoneLabel = new Label();
            memberEmailTextBox = new TextBox();
            memberEmailLabel = new Label();
            addMemberButton = new Button();
            createNewMemberButton = new Button();
            creatTeamButton = new Button();
            newMemberGroupBox = new GroupBox();
            memberLastNameTextBox = new TextBox();
            memberSecondNameLabel = new Label();
            teamNameTextBox = new TextBox();
            newMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // membersDropDown
            // 
            membersDropDown.BackColor = Color.FromArgb(28, 28, 28);
            membersDropDown.FlatStyle = FlatStyle.Flat;
            membersDropDown.ForeColor = Color.FromArgb(230, 57, 70);
            membersDropDown.FormattingEnabled = true;
            membersDropDown.Items.AddRange(new object[] { "Mo Salah", "Sadio Mane`" });
            membersDropDown.Location = new Point(34, 127);
            membersDropDown.Name = "membersDropDown";
            membersDropDown.Size = new Size(201, 38);
            membersDropDown.TabIndex = 7;
            // 
            // selectMemberLabel
            // 
            selectMemberLabel.AutoSize = true;
            selectMemberLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectMemberLabel.ForeColor = Color.Silver;
            selectMemberLabel.Location = new Point(25, 87);
            selectMemberLabel.Name = "selectMemberLabel";
            selectMemberLabel.Size = new Size(195, 37);
            selectMemberLabel.TabIndex = 6;
            selectMemberLabel.Text = "Select Member:";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.Silver;
            teamNameLabel.Location = new Point(24, 34);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(157, 37);
            teamNameLabel.TabIndex = 4;
            teamNameLabel.Text = "Team Name:";
            // 
            // deleteMemberButton
            // 
            deleteMemberButton.Enabled = false;
            deleteMemberButton.FlatStyle = FlatStyle.Flat;
            deleteMemberButton.Font = new Font("Segoe UI", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteMemberButton.ForeColor = Color.FromArgb(230, 57, 70);
            deleteMemberButton.Location = new Point(571, 44);
            deleteMemberButton.Name = "deleteMemberButton";
            deleteMemberButton.Size = new Size(57, 28);
            deleteMemberButton.TabIndex = 22;
            deleteMemberButton.Text = "Delete";
            deleteMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BackColor = Color.FromArgb(28, 28, 28);
            teamMembersListBox.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamMembersListBox.ForeColor = Color.FromArgb(230, 57, 70);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 25;
            teamMembersListBox.Location = new Point(372, 87);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(256, 304);
            teamMembersListBox.TabIndex = 21;
            // 
            // teamMembersLabel
            // 
            teamMembersLabel.AutoSize = true;
            teamMembersLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamMembersLabel.ForeColor = Color.Silver;
            teamMembersLabel.Location = new Point(359, 34);
            teamMembersLabel.Name = "teamMembersLabel";
            teamMembersLabel.Size = new Size(195, 37);
            teamMembersLabel.TabIndex = 20;
            teamMembersLabel.Text = "Team Members:";
            teamMembersLabel.Click += teamMembersLabel_Click;
            // 
            // createNewMemberLabel
            // 
            createNewMemberLabel.AutoSize = true;
            createNewMemberLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            createNewMemberLabel.ForeColor = Color.Silver;
            createNewMemberLabel.Location = new Point(34, 179);
            createNewMemberLabel.Name = "createNewMemberLabel";
            createNewMemberLabel.Size = new Size(275, 37);
            createNewMemberLabel.TabIndex = 23;
            createNewMemberLabel.Text = "Create a new member:";
            // 
            // createTeamScreenLabel
            // 
            createTeamScreenLabel.AutoSize = true;
            createTeamScreenLabel.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamScreenLabel.ForeColor = Color.FromArgb(212, 175, 55);
            createTeamScreenLabel.Location = new Point(239, 2);
            createTeamScreenLabel.Name = "createTeamScreenLabel";
            createTeamScreenLabel.Size = new Size(147, 32);
            createTeamScreenLabel.TabIndex = 24;
            createTeamScreenLabel.Text = "Create Team";
            createTeamScreenLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // memberNameTextBox
            // 
            memberNameTextBox.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            memberNameTextBox.Location = new Point(112, 34);
            memberNameTextBox.Name = "memberNameTextBox";
            memberNameTextBox.Size = new Size(169, 30);
            memberNameTextBox.TabIndex = 32;
            // 
            // memberFirstNameLabel
            // 
            memberFirstNameLabel.AutoSize = true;
            memberFirstNameLabel.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            memberFirstNameLabel.ForeColor = Color.Silver;
            memberFirstNameLabel.Location = new Point(8, 39);
            memberFirstNameLabel.Name = "memberFirstNameLabel";
            memberFirstNameLabel.Size = new Size(102, 25);
            memberFirstNameLabel.TabIndex = 29;
            memberFirstNameLabel.Text = "Fisrt Name:";
            memberFirstNameLabel.Click += memberNameLabel_Click;
            // 
            // memberPhoneTextBox
            // 
            memberPhoneTextBox.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            memberPhoneTextBox.Location = new Point(112, 108);
            memberPhoneTextBox.Name = "memberPhoneTextBox";
            memberPhoneTextBox.Size = new Size(169, 30);
            memberPhoneTextBox.TabIndex = 34;
            // 
            // memberPhoneLabel
            // 
            memberPhoneLabel.AutoSize = true;
            memberPhoneLabel.Font = new Font("Segoe UI Light", 15.25F, FontStyle.Regular, GraphicsUnit.Point);
            memberPhoneLabel.ForeColor = Color.Silver;
            memberPhoneLabel.Location = new Point(8, 106);
            memberPhoneLabel.Name = "memberPhoneLabel";
            memberPhoneLabel.Size = new Size(74, 30);
            memberPhoneLabel.TabIndex = 33;
            memberPhoneLabel.Text = "Phone:";
            // 
            // memberEmailTextBox
            // 
            memberEmailTextBox.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            memberEmailTextBox.Location = new Point(112, 145);
            memberEmailTextBox.Name = "memberEmailTextBox";
            memberEmailTextBox.Size = new Size(169, 30);
            memberEmailTextBox.TabIndex = 36;
            // 
            // memberEmailLabel
            // 
            memberEmailLabel.AutoSize = true;
            memberEmailLabel.Font = new Font("Segoe UI Light", 15.25F, FontStyle.Regular, GraphicsUnit.Point);
            memberEmailLabel.ForeColor = Color.Silver;
            memberEmailLabel.Location = new Point(8, 143);
            memberEmailLabel.Name = "memberEmailLabel";
            memberEmailLabel.Size = new Size(64, 30);
            memberEmailLabel.TabIndex = 35;
            memberEmailLabel.Text = "Email:";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.LightGreen;
            addMemberButton.Location = new Point(251, 132);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(106, 32);
            addMemberButton.TabIndex = 37;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // createNewMemberButton
            // 
            createNewMemberButton.FlatStyle = FlatStyle.Flat;
            createNewMemberButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            createNewMemberButton.ForeColor = Color.LightBlue;
            createNewMemberButton.Location = new Point(84, 193);
            createNewMemberButton.Name = "createNewMemberButton";
            createNewMemberButton.Size = new Size(115, 29);
            createNewMemberButton.TabIndex = 38;
            createNewMemberButton.Text = "Create Member";
            createNewMemberButton.UseVisualStyleBackColor = true;
            createNewMemberButton.Click += createNewMemberButton_Click;
            // 
            // creatTeamButton
            // 
            creatTeamButton.Enabled = false;
            creatTeamButton.FlatStyle = FlatStyle.Flat;
            creatTeamButton.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            creatTeamButton.ForeColor = Color.FromArgb(230, 57, 70);
            creatTeamButton.Location = new Point(372, 401);
            creatTeamButton.Name = "creatTeamButton";
            creatTeamButton.Size = new Size(256, 54);
            creatTeamButton.TabIndex = 39;
            creatTeamButton.Text = "Create Team";
            creatTeamButton.UseVisualStyleBackColor = true;
            // 
            // newMemberGroupBox
            // 
            newMemberGroupBox.Controls.Add(memberLastNameTextBox);
            newMemberGroupBox.Controls.Add(memberSecondNameLabel);
            newMemberGroupBox.Controls.Add(memberNameTextBox);
            newMemberGroupBox.Controls.Add(memberFirstNameLabel);
            newMemberGroupBox.Controls.Add(createNewMemberButton);
            newMemberGroupBox.Controls.Add(memberPhoneLabel);
            newMemberGroupBox.Controls.Add(memberPhoneTextBox);
            newMemberGroupBox.Controls.Add(memberEmailTextBox);
            newMemberGroupBox.Controls.Add(memberEmailLabel);
            newMemberGroupBox.ForeColor = Color.Gray;
            newMemberGroupBox.Location = new Point(12, 209);
            newMemberGroupBox.Name = "newMemberGroupBox";
            newMemberGroupBox.Size = new Size(297, 232);
            newMemberGroupBox.TabIndex = 40;
            newMemberGroupBox.TabStop = false;
            newMemberGroupBox.Text = "Member Details";
            // 
            // memberLastNameTextBox
            // 
            memberLastNameTextBox.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            memberLastNameTextBox.Location = new Point(112, 71);
            memberLastNameTextBox.Name = "memberLastNameTextBox";
            memberLastNameTextBox.Size = new Size(169, 30);
            memberLastNameTextBox.TabIndex = 40;
            // 
            // memberSecondNameLabel
            // 
            memberSecondNameLabel.AutoSize = true;
            memberSecondNameLabel.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            memberSecondNameLabel.ForeColor = Color.Silver;
            memberSecondNameLabel.Location = new Point(8, 75);
            memberSecondNameLabel.Name = "memberSecondNameLabel";
            memberSecondNameLabel.Size = new Size(100, 25);
            memberSecondNameLabel.TabIndex = 39;
            memberSecondNameLabel.Text = "Last Name:";
            // 
            // teamNameTextBox
            // 
            teamNameTextBox.BackColor = Color.FromArgb(28, 28, 28);
            teamNameTextBox.Font = new Font("Segoe UI", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameTextBox.ForeColor = Color.FromArgb(230, 57, 70);
            teamNameTextBox.Location = new Point(175, 44);
            teamNameTextBox.Name = "teamNameTextBox";
            teamNameTextBox.Size = new Size(165, 27);
            teamNameTextBox.TabIndex = 41;
            // 
            // CreateTeamScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 44);
            ClientSize = new Size(642, 467);
            Controls.Add(teamNameTextBox);
            Controls.Add(newMemberGroupBox);
            Controls.Add(creatTeamButton);
            Controls.Add(addMemberButton);
            Controls.Add(createTeamScreenLabel);
            Controls.Add(createNewMemberLabel);
            Controls.Add(deleteMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(teamMembersLabel);
            Controls.Add(membersDropDown);
            Controls.Add(selectMemberLabel);
            Controls.Add(teamNameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(212, 175, 55);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamScreen";
            Text = "CreateTeamScreen";
            newMemberGroupBox.ResumeLayout(false);
            newMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox membersDropDown;
        private Label selectMemberLabel;
        private Label teamNameLabel;
        private Button deleteMemberButton;
        private ListBox teamMembersListBox;
        private Label teamMembersLabel;
        private Label createNewMemberLabel;
        private Label createTeamScreenLabel;
        private TextBox memberNameTextBox;
        private Label memberFirstNameLabel;
        private TextBox memberPhoneTextBox;
        private Label memberPhoneLabel;
        private TextBox memberEmailTextBox;
        private Label memberEmailLabel;
        private Button addMemberButton;
        private Button createNewMemberButton;
        private Button creatTeamButton;
        private GroupBox newMemberGroupBox;
        private TextBox teamNameTextBox;
        private TextBox memberLastNameTextBox;
        private Label memberSecondNameLabel;
    }
}