namespace TrackerUI
{
    partial class CreateTournamentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentScreen));
            createTournamentLabel = new Label();
            tournamentNameLabel = new Label();
            tournamentNameTextBox = new TextBox();
            newTeamLink = new LinkLabel();
            teamSelectDropDown = new ComboBox();
            teamSelectLabel = new Label();
            addTeamButton = new Button();
            teamsInListBox = new ListBox();
            teamsInLabel = new Label();
            deleteTeamButton = new Button();
            deletePrizeButton = new Button();
            prizesInListBox = new ListBox();
            prizesInLabel = new Label();
            createPrizeButton = new Button();
            entryFeeLabel = new Label();
            entryFeeTextBox = new TextBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentLabel.ForeColor = Color.FromArgb(212, 175, 55);
            createTournamentLabel.Location = new Point(12, -2);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(219, 32);
            createTournamentLabel.TabIndex = 3;
            createTournamentLabel.Text = "Create Tournament";
            createTournamentLabel.Click += tournamentNameHolder_Click;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.Silver;
            tournamentNameLabel.Location = new Point(24, 30);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(231, 37);
            tournamentNameLabel.TabIndex = 2;
            tournamentNameLabel.Text = "Tournament Name:";
            tournamentNameLabel.Click += headerLabel_Click;
            // 
            // tournamentNameTextBox
            // 
            tournamentNameTextBox.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameTextBox.Location = new Point(34, 70);
            tournamentNameTextBox.Name = "tournamentNameTextBox";
            tournamentNameTextBox.Size = new Size(262, 32);
            tournamentNameTextBox.TabIndex = 8;
            // 
            // newTeamLink
            // 
            newTeamLink.AutoSize = true;
            newTeamLink.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            newTeamLink.LinkColor = Color.LightSkyBlue;
            newTeamLink.Location = new Point(103, 105);
            newTeamLink.Name = "newTeamLink";
            newTeamLink.Size = new Size(154, 23);
            newTeamLink.TabIndex = 9;
            newTeamLink.TabStop = true;
            newTeamLink.Text = "Create a new team";
            // 
            // teamSelectDropDown
            // 
            teamSelectDropDown.BackColor = Color.FromArgb(28, 28, 28);
            teamSelectDropDown.FlatStyle = FlatStyle.Flat;
            teamSelectDropDown.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamSelectDropDown.ForeColor = Color.FromArgb(230, 57, 70);
            teamSelectDropDown.FormattingEnabled = true;
            teamSelectDropDown.Items.AddRange(new object[] { "Team 1", "Team 2" });
            teamSelectDropDown.Location = new Point(103, 132);
            teamSelectDropDown.Name = "teamSelectDropDown";
            teamSelectDropDown.Size = new Size(193, 33);
            teamSelectDropDown.TabIndex = 11;
            // 
            // teamSelectLabel
            // 
            teamSelectLabel.AutoSize = true;
            teamSelectLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamSelectLabel.ForeColor = Color.Silver;
            teamSelectLabel.Location = new Point(25, 128);
            teamSelectLabel.Name = "teamSelectLabel";
            teamSelectLabel.Size = new Size(82, 37);
            teamSelectLabel.TabIndex = 10;
            teamSelectLabel.Text = "Team:";
            teamSelectLabel.Click += roundLabel_Click;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.LightGreen;
            addTeamButton.Location = new Point(190, 171);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(106, 32);
            addTeamButton.TabIndex = 13;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // teamsInListBox
            // 
            teamsInListBox.BackColor = Color.FromArgb(28, 28, 28);
            teamsInListBox.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamsInListBox.ForeColor = Color.FromArgb(230, 57, 70);
            teamsInListBox.FormattingEnabled = true;
            teamsInListBox.ItemHeight = 25;
            teamsInListBox.Location = new Point(363, 56);
            teamsInListBox.Name = "teamsInListBox";
            teamsInListBox.Size = new Size(256, 154);
            teamsInListBox.TabIndex = 15;
            // 
            // teamsInLabel
            // 
            teamsInLabel.AutoSize = true;
            teamsInLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamsInLabel.ForeColor = Color.Silver;
            teamsInLabel.Location = new Point(354, 11);
            teamsInLabel.Name = "teamsInLabel";
            teamsInLabel.Size = new Size(119, 37);
            teamsInLabel.TabIndex = 14;
            teamsInLabel.Text = "Teams in:";
            teamsInLabel.Click += roundLabel_Click_1;
            // 
            // deleteTeamButton
            // 
            deleteTeamButton.Enabled = false;
            deleteTeamButton.FlatStyle = FlatStyle.Flat;
            deleteTeamButton.Font = new Font("Segoe UI", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteTeamButton.ForeColor = Color.FromArgb(230, 57, 70);
            deleteTeamButton.Location = new Point(562, 22);
            deleteTeamButton.Name = "deleteTeamButton";
            deleteTeamButton.Size = new Size(57, 28);
            deleteTeamButton.TabIndex = 16;
            deleteTeamButton.Text = "Delete";
            deleteTeamButton.UseVisualStyleBackColor = true;
            // 
            // deletePrizeButton
            // 
            deletePrizeButton.Enabled = false;
            deletePrizeButton.FlatStyle = FlatStyle.Flat;
            deletePrizeButton.Font = new Font("Segoe UI", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            deletePrizeButton.ForeColor = Color.FromArgb(230, 57, 70);
            deletePrizeButton.Location = new Point(562, 224);
            deletePrizeButton.Name = "deletePrizeButton";
            deletePrizeButton.Size = new Size(57, 28);
            deletePrizeButton.TabIndex = 19;
            deletePrizeButton.Text = "Delete";
            deletePrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesInListBox
            // 
            prizesInListBox.BackColor = Color.FromArgb(28, 28, 28);
            prizesInListBox.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            prizesInListBox.ForeColor = Color.FromArgb(230, 57, 70);
            prizesInListBox.FormattingEnabled = true;
            prizesInListBox.ItemHeight = 25;
            prizesInListBox.Location = new Point(363, 258);
            prizesInListBox.Name = "prizesInListBox";
            prizesInListBox.Size = new Size(256, 154);
            prizesInListBox.TabIndex = 18;
            // 
            // prizesInLabel
            // 
            prizesInLabel.AutoSize = true;
            prizesInLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizesInLabel.ForeColor = Color.Silver;
            prizesInLabel.Location = new Point(354, 213);
            prizesInLabel.Name = "prizesInLabel";
            prizesInLabel.Size = new Size(90, 37);
            prizesInLabel.TabIndex = 17;
            prizesInLabel.Text = "Prizes:";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatStyle = FlatStyle.Popup;
            createPrizeButton.Font = new Font("Segoe UI", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.LightSkyBlue;
            createPrizeButton.Location = new Point(190, 258);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(106, 32);
            createPrizeButton.TabIndex = 20;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.Silver;
            entryFeeLabel.Location = new Point(34, 300);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(130, 37);
            entryFeeLabel.TabIndex = 21;
            entryFeeLabel.Text = "Entry Fee:";
            // 
            // entryFeeTextBox
            // 
            entryFeeTextBox.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeTextBox.Location = new Point(159, 305);
            entryFeeTextBox.Name = "entryFeeTextBox";
            entryFeeTextBox.Size = new Size(137, 32);
            entryFeeTextBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Enabled = false;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI", 16.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(230, 57, 70);
            createTournamentButton.Location = new Point(34, 362);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(282, 50);
            createTournamentButton.TabIndex = 23;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 44);
            ClientSize = new Size(657, 432);
            Controls.Add(createTournamentButton);
            Controls.Add(entryFeeTextBox);
            Controls.Add(entryFeeLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(deletePrizeButton);
            Controls.Add(prizesInListBox);
            Controls.Add(prizesInLabel);
            Controls.Add(deleteTeamButton);
            Controls.Add(teamsInListBox);
            Controls.Add(teamsInLabel);
            Controls.Add(addTeamButton);
            Controls.Add(teamSelectDropDown);
            Controls.Add(teamSelectLabel);
            Controls.Add(newTeamLink);
            Controls.Add(tournamentNameTextBox);
            Controls.Add(createTournamentLabel);
            Controls.Add(tournamentNameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(212, 175, 55);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentScreen";
            Text = "CreateTournamentScreen";
            Load += CreateTournamentScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentNameTextBox;
        private LinkLabel newTeamLink;
        private ComboBox teamSelectDropDown;
        private Label teamSelectLabel;
        private Button addTeamButton;
        private ListBox teamsInListBox;
        private Label teamsInLabel;
        private Button deleteTeamButton;
        private Button deletePrizeButton;
        private ListBox prizesInListBox;
        private Label prizesInLabel;
        private Button createPrizeButton;
        private Label entryFeeLabel;
        private TextBox entryFeeTextBox;
        private Button createTournamentButton;
    }
}