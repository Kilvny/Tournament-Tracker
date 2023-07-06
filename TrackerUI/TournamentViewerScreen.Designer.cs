namespace TrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            headerLabel = new Label();
            tournamentNameHolder = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            matchupListBox = new ListBox();
            unplayedCheckBox = new CheckBox();
            teamOneNameLabel = new Label();
            teamOneScoreBox = new TextBox();
            teamOneScoreLabel = new Label();
            teamTwoScoreLabel = new Label();
            teamTwoScoreBox = new TextBox();
            teamTwoNameLabel = new Label();
            saveResultButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Silver;
            headerLabel.Location = new Point(25, 14);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(156, 37);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentNameHolder
            // 
            tournamentNameHolder.AutoSize = true;
            tournamentNameHolder.ForeColor = Color.LightSkyBlue;
            tournamentNameHolder.Location = new Point(174, 20);
            tournamentNameHolder.Name = "tournamentNameHolder";
            tournamentNameHolder.Size = new Size(47, 30);
            tournamentNameHolder.TabIndex = 1;
            tournamentNameHolder.Text = "null";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = Color.Silver;
            roundLabel.Location = new Point(25, 66);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(96, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round:";
            // 
            // roundDropDown
            // 
            roundDropDown.BackColor = Color.FromArgb(28, 28, 28);
            roundDropDown.FlatStyle = FlatStyle.Flat;
            roundDropDown.ForeColor = Color.FromArgb(230, 57, 70);
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Items.AddRange(new object[] { "Round 1", "Round 2" });
            roundDropDown.Location = new Point(121, 65);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(285, 38);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.BackColor = Color.FromArgb(28, 28, 28);
            matchupListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            matchupListBox.ForeColor = Color.FromArgb(230, 57, 70);
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(25, 148);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(225, 244);
            matchupListBox.TabIndex = 4;
            // 
            // unplayedCheckBox
            // 
            unplayedCheckBox.AutoSize = true;
            unplayedCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedCheckBox.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedCheckBox.ForeColor = Color.LightSkyBlue;
            unplayedCheckBox.Location = new Point(121, 109);
            unplayedCheckBox.Name = "unplayedCheckBox";
            unplayedCheckBox.Size = new Size(232, 29);
            unplayedCheckBox.TabIndex = 5;
            unplayedCheckBox.Text = "Display Unplayed Games";
            unplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // teamOneNameLabel
            // 
            teamOneNameLabel.AutoSize = true;
            teamOneNameLabel.Location = new Point(333, 210);
            teamOneNameLabel.Name = "teamOneNameLabel";
            teamOneNameLabel.Size = new Size(71, 30);
            teamOneNameLabel.TabIndex = 6;
            teamOneNameLabel.Text = "team1";
            // 
            // teamOneScoreBox
            // 
            teamOneScoreBox.Location = new Point(333, 243);
            teamOneScoreBox.Name = "teamOneScoreBox";
            teamOneScoreBox.Size = new Size(103, 35);
            teamOneScoreBox.TabIndex = 7;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(256, 246);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(69, 30);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score:";
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(478, 246);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(69, 30);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score:";
            // 
            // teamTwoScoreBox
            // 
            teamTwoScoreBox.Location = new Point(555, 243);
            teamTwoScoreBox.Name = "teamTwoScoreBox";
            teamTwoScoreBox.Size = new Size(103, 35);
            teamTwoScoreBox.TabIndex = 10;
            // 
            // teamTwoNameLabel
            // 
            teamTwoNameLabel.AutoSize = true;
            teamTwoNameLabel.Location = new Point(555, 210);
            teamTwoNameLabel.Name = "teamTwoNameLabel";
            teamTwoNameLabel.Size = new Size(71, 30);
            teamTwoNameLabel.TabIndex = 9;
            teamTwoNameLabel.Text = "team2";
            // 
            // saveResultButton
            // 
            saveResultButton.FlatStyle = FlatStyle.Flat;
            saveResultButton.ForeColor = Color.FromArgb(230, 57, 70);
            saveResultButton.Location = new Point(494, 348);
            saveResultButton.Name = "saveResultButton";
            saveResultButton.Size = new Size(164, 44);
            saveResultButton.TabIndex = 12;
            saveResultButton.Text = "Save Result";
            saveResultButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 44);
            ClientSize = new Size(683, 419);
            Controls.Add(saveResultButton);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoScoreBox);
            Controls.Add(teamTwoNameLabel);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneScoreBox);
            Controls.Add(teamOneNameLabel);
            Controls.Add(unplayedCheckBox);
            Controls.Add(matchupListBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameHolder);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(212, 175, 55);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewer";
            Text = "Tournament View";
            Load += TournamentViewer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameHolder;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private ListBox matchupListBox;
        private CheckBox unplayedCheckBox;
        private Label teamOneNameLabel;
        private TextBox teamOneScoreBox;
        private Label teamOneScoreLabel;
        private Label teamTwoScoreLabel;
        private TextBox teamTwoScoreBox;
        private Label teamTwoNameLabel;
        private Button saveResultButton;
    }
}