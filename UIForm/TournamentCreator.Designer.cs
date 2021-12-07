namespace UIForm
{
    partial class TournamentCreator
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
            this.labelCreateTournament = new System.Windows.Forms.Label();
            this.layoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTournamentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEntryFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.comboBoxSelectTeam = new System.Windows.Forms.ComboBox();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonCreatePrize = new System.Windows.Forms.Button();
            this.layoutRight = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRemoveTeam = new System.Windows.Forms.Button();
            this.buttonRemovePrize = new System.Windows.Forms.Button();
            this.listBoxTournamentTeams = new System.Windows.Forms.ListBox();
            this.listBoxPrizes = new System.Windows.Forms.ListBox();
            this.buttonCreateTournament = new System.Windows.Forms.Button();
            this.layoutMain.SuspendLayout();
            this.layoutLeft.SuspendLayout();
            this.layoutRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 4;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.30875F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.69125F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.layoutMain.Controls.Add(this.labelCreateTournament, 1, 1);
            this.layoutMain.Controls.Add(this.layoutLeft, 1, 2);
            this.layoutMain.Controls.Add(this.layoutRight, 2, 2);
            this.layoutMain.Controls.Add(this.buttonCreateTournament, 1, 3);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(4);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 5;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layoutMain.Size = new System.Drawing.Size(841, 623);
            this.layoutMain.TabIndex = 0;
            // 
            // labelCreateTournament
            // 
            this.labelCreateTournament.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCreateTournament.AutoSize = true;
            this.labelCreateTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateTournament.Location = new System.Drawing.Point(31, 40);
            this.labelCreateTournament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreateTournament.Name = "labelCreateTournament";
            this.labelCreateTournament.Size = new System.Drawing.Size(266, 31);
            this.labelCreateTournament.TabIndex = 0;
            this.labelCreateTournament.Text = "Create Tournament";
            // 
            // layoutLeft
            // 
            this.layoutLeft.ColumnCount = 2;
            this.layoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.96507F));
            this.layoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.03493F));
            this.layoutLeft.Controls.Add(this.label1, 0, 0);
            this.layoutLeft.Controls.Add(this.textBoxTournamentName, 0, 1);
            this.layoutLeft.Controls.Add(this.label2, 0, 2);
            this.layoutLeft.Controls.Add(this.textBoxEntryFee, 1, 2);
            this.layoutLeft.Controls.Add(this.label3, 0, 3);
            this.layoutLeft.Controls.Add(this.linkLabelCreateNewTeam, 1, 3);
            this.layoutLeft.Controls.Add(this.comboBoxSelectTeam, 0, 4);
            this.layoutLeft.Controls.Add(this.buttonAddTeam, 0, 5);
            this.layoutLeft.Controls.Add(this.buttonCreatePrize, 0, 6);
            this.layoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutLeft.Location = new System.Drawing.Point(31, 91);
            this.layoutLeft.Margin = new System.Windows.Forms.Padding(4);
            this.layoutLeft.Name = "layoutLeft";
            this.layoutLeft.RowCount = 7;
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutLeft.Size = new System.Drawing.Size(306, 453);
            this.layoutLeft.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.layoutLeft.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament Name";
            // 
            // textBoxTournamentName
            // 
            this.textBoxTournamentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutLeft.SetColumnSpan(this.textBoxTournamentName, 2);
            this.textBoxTournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTournamentName.Location = new System.Drawing.Point(4, 47);
            this.textBoxTournamentName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTournamentName.Name = "textBoxTournamentName";
            this.textBoxTournamentName.Size = new System.Drawing.Size(298, 28);
            this.textBoxTournamentName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entry Fee";
            // 
            // textBoxEntryFee
            // 
            this.textBoxEntryFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEntryFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEntryFee.Location = new System.Drawing.Point(163, 96);
            this.textBoxEntryFee.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEntryFee.Name = "textBoxEntryFee";
            this.textBoxEntryFee.Size = new System.Drawing.Size(139, 28);
            this.textBoxEntryFee.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Team";
            // 
            // linkLabelCreateNewTeam
            // 
            this.linkLabelCreateNewTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelCreateNewTeam.AutoSize = true;
            this.linkLabelCreateNewTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateNewTeam.Location = new System.Drawing.Point(163, 200);
            this.linkLabelCreateNewTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelCreateNewTeam.Name = "linkLabelCreateNewTeam";
            this.linkLabelCreateNewTeam.Size = new System.Drawing.Size(103, 24);
            this.linkLabelCreateNewTeam.TabIndex = 5;
            this.linkLabelCreateNewTeam.TabStop = true;
            this.linkLabelCreateNewTeam.Text = "create new";
            this.linkLabelCreateNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateNewTeam_LinkClicked);
            // 
            // comboBoxSelectTeam
            // 
            this.comboBoxSelectTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutLeft.SetColumnSpan(this.comboBoxSelectTeam, 2);
            this.comboBoxSelectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectTeam.FormattingEnabled = true;
            this.comboBoxSelectTeam.Location = new System.Drawing.Point(4, 232);
            this.comboBoxSelectTeam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSelectTeam.Name = "comboBoxSelectTeam";
            this.comboBoxSelectTeam.Size = new System.Drawing.Size(298, 30);
            this.comboBoxSelectTeam.TabIndex = 6;
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.layoutLeft.SetColumnSpan(this.buttonAddTeam, 2);
            this.buttonAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeam.Location = new System.Drawing.Point(78, 277);
            this.buttonAddTeam.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(150, 40);
            this.buttonAddTeam.TabIndex = 7;
            this.buttonAddTeam.Text = "Add Team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonCreatePrize
            // 
            this.buttonCreatePrize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.layoutLeft.SetColumnSpan(this.buttonCreatePrize, 2);
            this.buttonCreatePrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreatePrize.Location = new System.Drawing.Point(78, 409);
            this.buttonCreatePrize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreatePrize.Name = "buttonCreatePrize";
            this.buttonCreatePrize.Size = new System.Drawing.Size(150, 40);
            this.buttonCreatePrize.TabIndex = 8;
            this.buttonCreatePrize.Text = "Create Prize";
            this.buttonCreatePrize.UseVisualStyleBackColor = true;
            this.buttonCreatePrize.Click += new System.EventHandler(this.buttonCreatePrize_Click);
            // 
            // layoutRight
            // 
            this.layoutRight.ColumnCount = 2;
            this.layoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.layoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutRight.Controls.Add(this.label4, 0, 0);
            this.layoutRight.Controls.Add(this.label5, 0, 2);
            this.layoutRight.Controls.Add(this.buttonRemoveTeam, 1, 1);
            this.layoutRight.Controls.Add(this.buttonRemovePrize, 1, 3);
            this.layoutRight.Controls.Add(this.listBoxTournamentTeams, 0, 1);
            this.layoutRight.Controls.Add(this.listBoxPrizes, 0, 3);
            this.layoutRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRight.Location = new System.Drawing.Point(345, 91);
            this.layoutRight.Margin = new System.Windows.Forms.Padding(4);
            this.layoutRight.Name = "layoutRight";
            this.layoutRight.RowCount = 4;
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight.Size = new System.Drawing.Size(458, 453);
            this.layoutRight.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teams / Players";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prizes";
            // 
            // buttonRemoveTeam
            // 
            this.buttonRemoveTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveTeam.Location = new System.Drawing.Point(324, 41);
            this.buttonRemoveTeam.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveTeam.Name = "buttonRemoveTeam";
            this.buttonRemoveTeam.Size = new System.Drawing.Size(130, 62);
            this.buttonRemoveTeam.TabIndex = 2;
            this.buttonRemoveTeam.Text = "Remove Selected";
            this.buttonRemoveTeam.UseVisualStyleBackColor = true;
            this.buttonRemoveTeam.Click += new System.EventHandler(this.buttonRemoveSelectedTeam_Click);
            // 
            // buttonRemovePrize
            // 
            this.buttonRemovePrize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemovePrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemovePrize.Location = new System.Drawing.Point(324, 267);
            this.buttonRemovePrize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemovePrize.Name = "buttonRemovePrize";
            this.buttonRemovePrize.Size = new System.Drawing.Size(130, 62);
            this.buttonRemovePrize.TabIndex = 3;
            this.buttonRemovePrize.Text = "Remove Selected";
            this.buttonRemovePrize.UseVisualStyleBackColor = true;
            this.buttonRemovePrize.Click += new System.EventHandler(this.buttonRemovePrize_Click);
            // 
            // listBoxTournamentTeams
            // 
            this.listBoxTournamentTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTournamentTeams.FormattingEnabled = true;
            this.listBoxTournamentTeams.ItemHeight = 16;
            this.listBoxTournamentTeams.Location = new System.Drawing.Point(4, 41);
            this.listBoxTournamentTeams.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTournamentTeams.Name = "listBoxTournamentTeams";
            this.listBoxTournamentTeams.ScrollAlwaysVisible = true;
            this.listBoxTournamentTeams.Size = new System.Drawing.Size(312, 181);
            this.listBoxTournamentTeams.TabIndex = 4;
            // 
            // listBoxPrizes
            // 
            this.listBoxPrizes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPrizes.FormattingEnabled = true;
            this.listBoxPrizes.ItemHeight = 16;
            this.listBoxPrizes.Location = new System.Drawing.Point(4, 267);
            this.listBoxPrizes.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPrizes.Name = "listBoxPrizes";
            this.listBoxPrizes.ScrollAlwaysVisible = true;
            this.listBoxPrizes.Size = new System.Drawing.Size(312, 182);
            this.listBoxPrizes.TabIndex = 5;
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutMain.SetColumnSpan(this.buttonCreateTournament, 2);
            this.buttonCreateTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTournament.Location = new System.Drawing.Point(317, 553);
            this.buttonCreateTournament.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(200, 40);
            this.buttonCreateTournament.TabIndex = 3;
            this.buttonCreateTournament.Text = "Create Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = true;
            this.buttonCreateTournament.Click += new System.EventHandler(this.buttonCreateTournament_Click);
            // 
            // TournamentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 623);
            this.Controls.Add(this.layoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TournamentCreator";
            this.Text = "Tournament Creator";
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            this.layoutLeft.ResumeLayout(false);
            this.layoutLeft.PerformLayout();
            this.layoutRight.ResumeLayout(false);
            this.layoutRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Label labelCreateTournament;
        private System.Windows.Forms.TableLayoutPanel layoutLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTournamentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEntryFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelCreateNewTeam;
        private System.Windows.Forms.ComboBox comboBoxSelectTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonCreatePrize;
        private System.Windows.Forms.TableLayoutPanel layoutRight;
        private System.Windows.Forms.Button buttonCreateTournament;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRemoveTeam;
        private System.Windows.Forms.Button buttonRemovePrize;
        private System.Windows.Forms.ListBox listBoxTournamentTeams;
        private System.Windows.Forms.ListBox listBoxPrizes;
    }
}