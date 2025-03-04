namespace TrackerUI2
{
    partial class CreateTournamentForm
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
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewLink = new LinkLabel();
            addTeamButton = new Button();
            prizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(45, 58);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(640, 100);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new Point(45, 209);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(377, 59);
            tournamentNameLabel.TabIndex = 4;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(45, 286);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(640, 65);
            tournamentNameValue.TabIndex = 9;
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(270, 404);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(200, 65);
            entryFeeValue.TabIndex = 11;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(45, 410);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(199, 59);
            entryFeeLabel.TabIndex = 10;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(45, 610);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(640, 67);
            selectTeamDropDown.TabIndex = 13;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(45, 526);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(249, 59);
            selectTeamLabel.TabIndex = 12;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewLink
            // 
            createNewLink.AutoSize = true;
            createNewLink.Location = new Point(455, 548);
            createNewLink.Name = "createNewLink";
            createNewLink.Size = new Size(230, 59);
            createNewLink.TabIndex = 14;
            createNewLink.TabStop = true;
            createNewLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new Point(223, 692);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(269, 100);
            addTeamButton.TabIndex = 15;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // prizeButton
            // 
            prizeButton.FlatAppearance.BorderColor = Color.Silver;
            prizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            prizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            prizeButton.FlatStyle = FlatStyle.Flat;
            prizeButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            prizeButton.Location = new Point(223, 874);
            prizeButton.Name = "prizeButton";
            prizeButton.Size = new Size(269, 100);
            prizeButton.TabIndex = 16;
            prizeButton.Text = "Create Prize";
            prizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 59;
            tournamentPlayersListBox.Location = new Point(835, 286);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(695, 297);
            tournamentPlayersListBox.TabIndex = 17;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentPlayersLabel.Location = new Point(835, 209);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(316, 59);
            tournamentPlayersLabel.TabIndex = 18;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteSelectedPlayerButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedPlayerButton.Location = new Point(1569, 286);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(206, 132);
            deleteSelectedPlayerButton.TabIndex = 19;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteSelectedPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedPrizeButton.Location = new Point(1569, 727);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(206, 132);
            deleteSelectedPrizeButton.TabIndex = 22;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizesLabel.Location = new Point(835, 650);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(133, 59);
            prizesLabel.TabIndex = 21;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 59;
            prizesListBox.Location = new Point(835, 727);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(695, 297);
            prizesListBox.TabIndex = 20;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(590, 1101);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(506, 131);
            createTournamentButton.TabIndex = 23;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1843, 1256);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(prizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewLink;
        private Button addTeamButton;
        private Button prizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}