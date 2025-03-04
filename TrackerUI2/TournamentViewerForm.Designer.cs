namespace TrackerUI2
{
    partial class TournamentViewerForm
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
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(31, 38);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(431, 100);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentName.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentName.Location = new Point(435, 38);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(300, 100);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.ForeColor = Color.FromArgb(51, 153, 255);
            roundLabel.Location = new Point(40, 175);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(148, 59);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(233, 167);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(502, 67);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.ForeColor = Color.FromArgb(51, 153, 255);
            unplayedOnlyCheckbox.Location = new Point(233, 240);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(330, 63);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 59;
            matchupListBox.Location = new Point(40, 349);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(695, 356);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.ForeColor = Color.FromArgb(51, 153, 255);
            teamOneName.Location = new Point(875, 167);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(262, 59);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamOneScoreLabel.Location = new Point(875, 266);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(130, 59);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(1011, 260);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(200, 65);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(1011, 585);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(200, 65);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoScoreLabel.Location = new Point(875, 591);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(130, 59);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoName.Location = new Point(875, 492);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(262, 59);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.ForeColor = Color.FromArgb(51, 153, 255);
            versusLabel.Location = new Point(980, 393);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(122, 59);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "- vs -";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = Color.FromArgb(51, 153, 255);
            scoreButton.Location = new Point(1232, 404);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(177, 100);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1477, 830);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}