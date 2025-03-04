namespace TrackerUI2
{
    partial class TournamentDashboardForm
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
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(338, 86);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(778, 100);
            headerLabel.TabIndex = 3;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(407, 378);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(640, 67);
            loadExistingTournamentDropDown.TabIndex = 19;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            loadExistingTournamentLabel.Location = new Point(471, 294);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(512, 59);
            loadExistingTournamentLabel.TabIndex = 18;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            loadTournamentButton.Location = new Point(533, 471);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(388, 81);
            loadTournamentButton.TabIndex = 20;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(474, 676);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(506, 131);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1477, 830);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            Load += TournamentDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}