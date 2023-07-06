namespace TrackerUI
{
    partial class CreatePrizeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeScreen));
            createPrizeLabel = new Label();
            rankTextBox = new TextBox();
            rankLabel = new Label();
            rankNameTextBox = new TextBox();
            rankNameLabel = new Label();
            prizeAmountTextBox = new TextBox();
            prizeAmountLabel = new Label();
            stylingLineSeperate = new Label();
            prizePercentageTextBox = new TextBox();
            prizePercentageLabel = new Label();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = Color.FromArgb(212, 175, 55);
            createPrizeLabel.Location = new Point(12, 9);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(141, 32);
            createPrizeLabel.TabIndex = 4;
            createPrizeLabel.Text = "Create Prize";
            // 
            // rankTextBox
            // 
            rankTextBox.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            rankTextBox.Location = new Point(283, 75);
            rankTextBox.Name = "rankTextBox";
            rankTextBox.Size = new Size(137, 32);
            rankTextBox.TabIndex = 24;
            // 
            // rankLabel
            // 
            rankLabel.AutoSize = true;
            rankLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            rankLabel.ForeColor = Color.Silver;
            rankLabel.Location = new Point(76, 71);
            rankLabel.Name = "rankLabel";
            rankLabel.Size = new Size(77, 37);
            rankLabel.TabIndex = 23;
            rankLabel.Text = "Rank:";
            // 
            // rankNameTextBox
            // 
            rankNameTextBox.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            rankNameTextBox.Location = new Point(283, 125);
            rankNameTextBox.Name = "rankNameTextBox";
            rankNameTextBox.Size = new Size(137, 32);
            rankNameTextBox.TabIndex = 26;
            // 
            // rankNameLabel
            // 
            rankNameLabel.AutoSize = true;
            rankNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            rankNameLabel.ForeColor = Color.Silver;
            rankNameLabel.Location = new Point(76, 121);
            rankNameLabel.Name = "rankNameLabel";
            rankNameLabel.Size = new Size(152, 37);
            rankNameLabel.TabIndex = 25;
            rankNameLabel.Text = "Rank Name:";
            // 
            // prizeAmountTextBox
            // 
            prizeAmountTextBox.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountTextBox.Location = new Point(283, 176);
            prizeAmountTextBox.Name = "prizeAmountTextBox";
            prizeAmountTextBox.Size = new Size(137, 32);
            prizeAmountTextBox.TabIndex = 28;
            prizeAmountTextBox.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.Silver;
            prizeAmountLabel.Location = new Point(76, 171);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(177, 37);
            prizeAmountLabel.TabIndex = 27;
            prizeAmountLabel.Text = "Prize Amount:";
            // 
            // stylingLineSeperate
            // 
            stylingLineSeperate.AutoSize = true;
            stylingLineSeperate.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            stylingLineSeperate.ForeColor = Color.FromArgb(212, 175, 55);
            stylingLineSeperate.Location = new Point(33, 223);
            stylingLineSeperate.Name = "stylingLineSeperate";
            stylingLineSeperate.Size = new Size(414, 32);
            stylingLineSeperate.TabIndex = 29;
            stylingLineSeperate.Text = "----------------------------------------";
            stylingLineSeperate.Click += label1_Click;
            // 
            // prizePercentageTextBox
            // 
            prizePercentageTextBox.Font = new Font("Segoe UI", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageTextBox.Location = new Point(283, 279);
            prizePercentageTextBox.Name = "prizePercentageTextBox";
            prizePercentageTextBox.Size = new Size(137, 32);
            prizePercentageTextBox.TabIndex = 31;
            prizePercentageTextBox.Text = "0";
            prizePercentageTextBox.TextChanged += textBox4_TextChanged;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.Silver;
            prizePercentageLabel.Location = new Point(76, 275);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(212, 37);
            prizePercentageLabel.TabIndex = 30;
            prizePercentageLabel.Text = "Prize Percentage:";
            prizePercentageLabel.Click += label2_Click;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(212, 175, 55);
            createTournamentButton.Location = new Point(45, 343);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(390, 57);
            createTournamentButton.TabIndex = 32;
            createTournamentButton.Text = "Create Prize";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreatePrizeScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 44);
            ClientSize = new Size(476, 412);
            Controls.Add(createTournamentButton);
            Controls.Add(prizePercentageTextBox);
            Controls.Add(prizePercentageLabel);
            Controls.Add(stylingLineSeperate);
            Controls.Add(prizeAmountTextBox);
            Controls.Add(prizeAmountLabel);
            Controls.Add(rankNameTextBox);
            Controls.Add(rankNameLabel);
            Controls.Add(rankTextBox);
            Controls.Add(rankLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(212, 175, 55);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeScreen";
            Text = "CreatePrizeScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox rankTextBox;
        private Label rankLabel;
        private TextBox rankNameTextBox;
        private Label rankNameLabel;
        private TextBox prizeAmountTextBox;
        private Label prizeAmountLabel;
        private Label stylingLineSeperate;
        private TextBox prizePercentageTextBox;
        private Label prizePercentageLabel;
        private Button createTournamentButton;
    }
}