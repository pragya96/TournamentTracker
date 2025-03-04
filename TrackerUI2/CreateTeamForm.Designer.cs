namespace TrackerUI2
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(37, 46);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(431, 100);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Create Team";
            headerLabel.Click += headerLabel_Click;
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(37, 275);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(640, 65);
            teamNameValue.TabIndex = 11;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamNameLabel.Location = new Point(37, 198);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(250, 59);
            teamNameLabel.TabIndex = 10;
            teamNameLabel.Text = "Team Name";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            addMemberButton.Location = new Point(182, 580);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(326, 81);
            addMemberButton.TabIndex = 18;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(37, 495);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(640, 67);
            selectTeamMemberDropDown.TabIndex = 17;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamMemberLabel.Location = new Point(37, 411);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(421, 59);
            selectTeamMemberLabel.TabIndex = 16;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.ForeColor = Color.FromArgb(51, 153, 255);
            addNewMemberGroupBox.Location = new Point(37, 742);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(640, 631);
            addNewMemberGroupBox.TabIndex = 19;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(272, 96);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(337, 65);
            firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(23, 96);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(229, 59);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(272, 192);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(337, 65);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new Point(23, 192);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(225, 59);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(272, 291);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(337, 65);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.Location = new Point(23, 291);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(126, 59);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(270, 385);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(337, 65);
            cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            cellphoneLabel.Location = new Point(21, 385);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(214, 59);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new Point(125, 521);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(379, 81);
            createMemberButton.TabIndex = 19;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 59;
            teamMembersListBox.Location = new Point(825, 250);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(695, 1123);
            teamMembersListBox.TabIndex = 20;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteSelectedMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedMemberButton.Location = new Point(1537, 250);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(206, 132);
            deleteSelectedMemberButton.TabIndex = 21;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(557, 1448);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(506, 131);
            createTeamButton.TabIndex = 24;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1785, 1591);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}