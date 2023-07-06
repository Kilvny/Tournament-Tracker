namespace TrackerUI
{
    partial class MainAppScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppScreen));
            openTournamentButton = new Button();
            tournamentDropDown = new ComboBox();
            tournamentTrackerLabel = new Label();
            selectTournamentLabel = new Label();
            loadTournamentLabel = new Label();
            stylingLineSeperate = new Label();
            createNewTournamentButton = new Button();
            SuspendLayout();
            // 
            // openTournamentButton
            // 
            openTournamentButton.FlatStyle = FlatStyle.Flat;
            openTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            openTournamentButton.ForeColor = Color.LightGreen;
            openTournamentButton.Location = new Point(118, 207);
            openTournamentButton.Name = "openTournamentButton";
            openTournamentButton.Size = new Size(408, 47);
            openTournamentButton.TabIndex = 42;
            openTournamentButton.Text = "Open Tournament";
            openTournamentButton.UseVisualStyleBackColor = true;
            // 
            // tournamentDropDown
            // 
            tournamentDropDown.BackColor = Color.FromArgb(28, 28, 28);
            tournamentDropDown.FlatStyle = FlatStyle.Flat;
            tournamentDropDown.ForeColor = Color.FromArgb(230, 57, 70);
            tournamentDropDown.FormattingEnabled = true;
            tournamentDropDown.Items.AddRange(new object[] { "Mo Salah", "Sadio Mane`" });
            tournamentDropDown.Location = new Point(118, 163);
            tournamentDropDown.Name = "tournamentDropDown";
            tournamentDropDown.Size = new Size(408, 38);
            tournamentDropDown.TabIndex = 41;
            // 
            // tournamentTrackerLabel
            // 
            tournamentTrackerLabel.AutoSize = true;
            tournamentTrackerLabel.Font = new Font("Segoe UI", 25.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentTrackerLabel.ForeColor = Color.LightSkyBlue;
            tournamentTrackerLabel.Location = new Point(157, 9);
            tournamentTrackerLabel.Name = "tournamentTrackerLabel";
            tournamentTrackerLabel.Size = new Size(324, 47);
            tournamentTrackerLabel.TabIndex = 39;
            tournamentTrackerLabel.Text = "Tournament Tracker";
            tournamentTrackerLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // selectTournamentLabel
            // 
            selectTournamentLabel.AutoSize = true;
            selectTournamentLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTournamentLabel.ForeColor = Color.Silver;
            selectTournamentLabel.Location = new Point(108, 121);
            selectTournamentLabel.Name = "selectTournamentLabel";
            selectTournamentLabel.Size = new Size(156, 37);
            selectTournamentLabel.TabIndex = 38;
            selectTournamentLabel.Text = "Tournament:";
            // 
            // loadTournamentLabel
            // 
            loadTournamentLabel.AutoSize = true;
            loadTournamentLabel.Font = new Font("Segoe UI Semilight", 14.75F, FontStyle.Regular, GraphicsUnit.Point);
            loadTournamentLabel.ForeColor = Color.LightSkyBlue;
            loadTournamentLabel.Location = new Point(206, 93);
            loadTournamentLabel.Name = "loadTournamentLabel";
            loadTournamentLabel.Size = new Size(226, 28);
            loadTournamentLabel.TabIndex = 43;
            loadTournamentLabel.Text = "Load existing tournament";
            loadTournamentLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // stylingLineSeperate
            // 
            stylingLineSeperate.AutoSize = true;
            stylingLineSeperate.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            stylingLineSeperate.ForeColor = Color.FromArgb(212, 175, 55);
            stylingLineSeperate.Location = new Point(-4, 307);
            stylingLineSeperate.Name = "stylingLineSeperate";
            stylingLineSeperate.Size = new Size(654, 32);
            stylingLineSeperate.TabIndex = 44;
            stylingLineSeperate.Text = "----------------------------------------------------------------";
            // 
            // createNewTournamentButton
            // 
            createNewTournamentButton.FlatStyle = FlatStyle.Flat;
            createNewTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createNewTournamentButton.ForeColor = Color.FromArgb(212, 175, 55);
            createNewTournamentButton.Location = new Point(118, 381);
            createNewTournamentButton.Name = "createNewTournamentButton";
            createNewTournamentButton.Size = new Size(408, 47);
            createNewTournamentButton.TabIndex = 45;
            createNewTournamentButton.Text = "Create a new tournament";
            createNewTournamentButton.UseVisualStyleBackColor = true;
            // 
            // MainAppScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 44);
            ClientSize = new Size(647, 488);
            Controls.Add(createNewTournamentButton);
            Controls.Add(stylingLineSeperate);
            Controls.Add(loadTournamentLabel);
            Controls.Add(openTournamentButton);
            Controls.Add(tournamentDropDown);
            Controls.Add(tournamentTrackerLabel);
            Controls.Add(selectTournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(212, 175, 55);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainAppScreen";
            Text = "MainAppScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openTournamentButton;
        private ComboBox tournamentDropDown;
        private Label selectMemberLabel;
        private Label tournamentTrackerLabel;
        private Label selectTournamentLabel;
        private Label loadTournamentLabel;
        private Label stylingLineSeperate;
        private Button createNewTournamentButton;
    }
}