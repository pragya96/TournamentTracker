namespace TrackerUI2
{
    partial class CreatePrizeForm
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
            headerLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(42, 48);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(422, 100);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(406, 206);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(337, 65);
            placeNumberValue.TabIndex = 12;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(42, 206);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(290, 59);
            placeNumberLabel.TabIndex = 11;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(406, 315);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(337, 65);
            placeNameValue.TabIndex = 14;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(42, 315);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(248, 59);
            placeNameLabel.TabIndex = 13;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(406, 438);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(337, 65);
            prizeAmountValue.TabIndex = 16;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizeAmountLabel.Location = new Point(42, 438);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(280, 59);
            prizeAmountLabel.TabIndex = 15;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(406, 670);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(337, 65);
            prizePercentageValue.TabIndex = 18;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizePercentageLabel.Location = new Point(42, 670);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(336, 59);
            prizePercentageLabel.TabIndex = 17;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(300, 561);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(123, 59);
            orLabel.TabIndex = 19;
            orLabel.Text = "- or -";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(144, 838);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(506, 131);
            createPrizeButton.TabIndex = 25;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(863, 1010);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}
