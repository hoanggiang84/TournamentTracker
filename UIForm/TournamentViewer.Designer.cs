namespace UIForm
{
    partial class TournamentViewer
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
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxMatchup = new System.Windows.Forms.ListBox();
            this.labelTournament = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.comboBoxRound = new System.Windows.Forms.ComboBox();
            this.checkBoxUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.panelMatchUp = new System.Windows.Forms.Panel();
            this.buttonScore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTwoScore = new System.Windows.Forms.TextBox();
            this.textBoxTeamOneScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTeam2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTeam1 = new System.Windows.Forms.Label();
            this.layoutMain.SuspendLayout();
            this.panelMatchUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 6;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.layoutMain.Controls.Add(this.listBoxMatchup, 1, 4);
            this.layoutMain.Controls.Add(this.labelTournament, 1, 1);
            this.layoutMain.Controls.Add(this.labelRound, 1, 2);
            this.layoutMain.Controls.Add(this.comboBoxRound, 2, 2);
            this.layoutMain.Controls.Add(this.checkBoxUnplayedOnly, 2, 3);
            this.layoutMain.Controls.Add(this.panelMatchUp, 3, 4);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(4);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 6;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.846154F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.26923F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layoutMain.Size = new System.Drawing.Size(779, 690);
            this.layoutMain.TabIndex = 0;
            // 
            // listBoxMatchup
            // 
            this.layoutMain.SetColumnSpan(this.listBoxMatchup, 2);
            this.listBoxMatchup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMatchup.FormattingEnabled = true;
            this.listBoxMatchup.ItemHeight = 16;
            this.listBoxMatchup.Location = new System.Drawing.Point(31, 231);
            this.listBoxMatchup.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMatchup.Name = "listBoxMatchup";
            this.listBoxMatchup.Size = new System.Drawing.Size(350, 428);
            this.listBoxMatchup.TabIndex = 0;
            // 
            // labelTournament
            // 
            this.labelTournament.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTournament.AutoSize = true;
            this.layoutMain.SetColumnSpan(this.labelTournament, 4);
            this.labelTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournament.Location = new System.Drawing.Point(31, 58);
            this.labelTournament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTournament.Name = "labelTournament";
            this.labelTournament.Size = new System.Drawing.Size(708, 31);
            this.labelTournament.TabIndex = 1;
            this.labelTournament.Text = "Tournament: <Name>";
            // 
            // labelRound
            // 
            this.labelRound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRound.Location = new System.Drawing.Point(31, 139);
            this.labelRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(72, 24);
            this.labelRound.TabIndex = 2;
            this.labelRound.Text = "Round";
            // 
            // comboBoxRound
            // 
            this.comboBoxRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRound.FormattingEnabled = true;
            this.comboBoxRound.Location = new System.Drawing.Point(210, 138);
            this.comboBoxRound.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRound.Name = "comboBoxRound";
            this.comboBoxRound.Size = new System.Drawing.Size(171, 24);
            this.comboBoxRound.TabIndex = 3;
            // 
            // checkBoxUnplayedOnly
            // 
            this.checkBoxUnplayedOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxUnplayedOnly.AutoSize = true;
            this.checkBoxUnplayedOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnplayedOnly.Location = new System.Drawing.Point(210, 189);
            this.checkBoxUnplayedOnly.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUnplayedOnly.Name = "checkBoxUnplayedOnly";
            this.checkBoxUnplayedOnly.Size = new System.Drawing.Size(156, 28);
            this.checkBoxUnplayedOnly.TabIndex = 4;
            this.checkBoxUnplayedOnly.Text = "Unplayed Only";
            this.checkBoxUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // panelMatchUp
            // 
            this.layoutMain.SetColumnSpan(this.panelMatchUp, 2);
            this.panelMatchUp.Controls.Add(this.buttonScore);
            this.panelMatchUp.Controls.Add(this.label2);
            this.panelMatchUp.Controls.Add(this.textBoxTwoScore);
            this.panelMatchUp.Controls.Add(this.textBoxTeamOneScore);
            this.panelMatchUp.Controls.Add(this.label1);
            this.panelMatchUp.Controls.Add(this.labelTeam2);
            this.panelMatchUp.Controls.Add(this.label3);
            this.panelMatchUp.Controls.Add(this.labelTeam1);
            this.panelMatchUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMatchUp.Location = new System.Drawing.Point(388, 230);
            this.panelMatchUp.Name = "panelMatchUp";
            this.panelMatchUp.Size = new System.Drawing.Size(352, 430);
            this.panelMatchUp.TabIndex = 5;
            // 
            // buttonScore
            // 
            this.buttonScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScore.Location = new System.Drawing.Point(236, 175);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(90, 40);
            this.buttonScore.TabIndex = 8;
            this.buttonScore.Text = "Score";
            this.buttonScore.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "VS";
            // 
            // textBoxTwoScore
            // 
            this.textBoxTwoScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTwoScore.Location = new System.Drawing.Point(95, 265);
            this.textBoxTwoScore.Name = "textBoxTwoScore";
            this.textBoxTwoScore.Size = new System.Drawing.Size(130, 34);
            this.textBoxTwoScore.TabIndex = 6;
            // 
            // textBoxTeamOneScore
            // 
            this.textBoxTeamOneScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamOneScore.Location = new System.Drawing.Point(95, 111);
            this.textBoxTeamOneScore.Name = "textBoxTeamOneScore";
            this.textBoxTeamOneScore.Size = new System.Drawing.Size(130, 34);
            this.textBoxTeamOneScore.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score";
            // 
            // labelTeam2
            // 
            this.labelTeam2.AutoSize = true;
            this.labelTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam2.Location = new System.Drawing.Point(29, 236);
            this.labelTeam2.Name = "labelTeam2";
            this.labelTeam2.Size = new System.Drawing.Size(143, 24);
            this.labelTeam2.TabIndex = 3;
            this.labelTeam2.Text = "Sample Team 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score";
            // 
            // labelTeam1
            // 
            this.labelTeam1.AutoSize = true;
            this.labelTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam1.Location = new System.Drawing.Point(29, 82);
            this.labelTeam1.Name = "labelTeam1";
            this.labelTeam1.Size = new System.Drawing.Size(143, 24);
            this.labelTeam1.TabIndex = 0;
            this.labelTeam1.Text = "Sample Team 1";
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.Controls.Add(this.layoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TournamentViewer";
            this.Text = "TournamentViewer";
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            this.panelMatchUp.ResumeLayout(false);
            this.panelMatchUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.ListBox listBoxMatchup;
        private System.Windows.Forms.Label labelTournament;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.ComboBox comboBoxRound;
        private System.Windows.Forms.CheckBox checkBoxUnplayedOnly;
        private System.Windows.Forms.Panel panelMatchUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTwoScore;
        private System.Windows.Forms.TextBox textBoxTeamOneScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTeam2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTeam1;
        private System.Windows.Forms.Button buttonScore;
    }
}