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
            this.layoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 6;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.layoutMain.Controls.Add(this.listBoxMatchup, 1, 4);
            this.layoutMain.Controls.Add(this.labelTournament, 1, 1);
            this.layoutMain.Controls.Add(this.labelRound, 1, 2);
            this.layoutMain.Controls.Add(this.comboBoxRound, 2, 2);
            this.layoutMain.Controls.Add(this.checkBoxUnplayedOnly, 2, 3);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 6;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.846154F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.26923F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.Size = new System.Drawing.Size(584, 561);
            this.layoutMain.TabIndex = 0;
            // 
            // listBoxMatchup
            // 
            this.layoutMain.SetColumnSpan(this.listBoxMatchup, 2);
            this.listBoxMatchup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMatchup.FormattingEnabled = true;
            this.listBoxMatchup.Location = new System.Drawing.Point(23, 188);
            this.listBoxMatchup.Name = "listBoxMatchup";
            this.listBoxMatchup.Size = new System.Drawing.Size(264, 349);
            this.listBoxMatchup.TabIndex = 0;
            // 
            // labelTournament
            // 
            this.labelTournament.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTournament.AutoSize = true;
            this.layoutMain.SetColumnSpan(this.labelTournament, 4);
            this.labelTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournament.Location = new System.Drawing.Point(23, 47);
            this.labelTournament.Name = "labelTournament";
            this.labelTournament.Size = new System.Drawing.Size(534, 25);
            this.labelTournament.TabIndex = 1;
            this.labelTournament.Text = "Tournament: <Name>";
            // 
            // labelRound
            // 
            this.labelRound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRound.Location = new System.Drawing.Point(23, 115);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(49, 15);
            this.labelRound.TabIndex = 2;
            this.labelRound.Text = "Round";
            // 
            // comboBoxRound
            // 
            this.comboBoxRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRound.FormattingEnabled = true;
            this.comboBoxRound.Location = new System.Drawing.Point(158, 112);
            this.comboBoxRound.Name = "comboBoxRound";
            this.comboBoxRound.Size = new System.Drawing.Size(129, 21);
            this.comboBoxRound.TabIndex = 3;
            // 
            // checkBoxUnplayedOnly
            // 
            this.checkBoxUnplayedOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxUnplayedOnly.AutoSize = true;
            this.checkBoxUnplayedOnly.Location = new System.Drawing.Point(158, 157);
            this.checkBoxUnplayedOnly.Name = "checkBoxUnplayedOnly";
            this.checkBoxUnplayedOnly.Size = new System.Drawing.Size(95, 17);
            this.checkBoxUnplayedOnly.TabIndex = 4;
            this.checkBoxUnplayedOnly.Text = "Unplayed Only";
            this.checkBoxUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.layoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TournamentViewer";
            this.Text = "TournamentViewer";
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.ListBox listBoxMatchup;
        private System.Windows.Forms.Label labelTournament;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.ComboBox comboBoxRound;
        private System.Windows.Forms.CheckBox checkBoxUnplayedOnly;
    }
}