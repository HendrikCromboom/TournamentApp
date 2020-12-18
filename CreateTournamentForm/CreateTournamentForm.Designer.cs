namespace CreateTournamentForm
{
    partial class CreateTournamentForm
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
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.createTeamLink = new System.Windows.Forms.LinkLabel();
            this.entriesLabel = new System.Windows.Forms.Label();
            this.entriesBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createTournamentLabel.Location = new System.Drawing.Point(13, 9);
            this.createTournamentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(324, 50);
            this.createTournamentLabel.TabIndex = 0;
            this.createTournamentLabel.Text = "Create Tournament";
            this.createTournamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentNameLabel.Location = new System.Drawing.Point(26, 74);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(239, 37);
            this.tournamentNameLabel.TabIndex = 1;
            this.tournamentNameLabel.Text = "Tournament Name";
            this.tournamentNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(39, 128);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(211, 21);
            this.tournamentNameValue.TabIndex = 2;
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.entryFeeLabel.Location = new System.Drawing.Point(26, 164);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.entryFeeLabel.TabIndex = 1;
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(158, 180);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(92, 21);
            this.entryFeeValue.TabIndex = 2;
            this.entryFeeValue.Text = "0";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addTeamButton.Location = new System.Drawing.Point(105, 347);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(113, 42);
            this.addTeamButton.TabIndex = 6;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectTeamLabel.Location = new System.Drawing.Point(26, 265);
            this.selectTeamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(159, 37);
            this.selectTeamLabel.TabIndex = 1;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 320);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // createTeamLink
            // 
            this.createTeamLink.AutoSize = true;
            this.createTeamLink.Location = new System.Drawing.Point(254, 284);
            this.createTeamLink.Name = "createTeamLink";
            this.createTeamLink.Size = new System.Drawing.Size(69, 13);
            this.createTeamLink.TabIndex = 7;
            this.createTeamLink.TabStop = true;
            this.createTeamLink.Text = "Create Team";
            // 
            // entriesLabel
            // 
            this.entriesLabel.AutoSize = true;
            this.entriesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entriesLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.entriesLabel.Location = new System.Drawing.Point(495, 74);
            this.entriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entriesLabel.Name = "entriesLabel";
            this.entriesLabel.Size = new System.Drawing.Size(96, 37);
            this.entriesLabel.TabIndex = 1;
            this.entriesLabel.Text = "Entries";
            this.entriesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // entriesBox
            // 
            this.entriesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entriesBox.FormattingEnabled = true;
            this.entriesBox.Location = new System.Drawing.Point(403, 127);
            this.entriesBox.MultiColumn = true;
            this.entriesBox.Name = "entriesBox";
            this.entriesBox.Size = new System.Drawing.Size(282, 171);
            this.entriesBox.TabIndex = 4;
            this.entriesBox.SelectedIndexChanged += new System.EventHandler(this.entriesBox_SelectedIndexChanged);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 524);
            this.Controls.Add(this.entriesBox);
            this.Controls.Add(this.entriesLabel);
            this.Controls.Add(this.createTeamLink);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel createTeamLink;
        private System.Windows.Forms.Label entriesLabel;
        private System.Windows.Forms.ListBox entriesBox;
    }
}

