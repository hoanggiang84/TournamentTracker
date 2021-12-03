namespace UIForm
{
    partial class TeamCreator
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateMember = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedPlayer = new System.Windows.Forms.Button();
            this.buttonCreateTeam = new System.Windows.Forms.Button();
            this.listBoxTournamentPlayers = new System.Windows.Forms.ListBox();
            this.layoutCreateTeam = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.comboBoxTeamMember = new System.Windows.Forms.ComboBox();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNewMemberPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNewMemberFirstName = new System.Windows.Forms.TextBox();
            this.textBoxNewMemberEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNewMemberLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.layoutMain.SuspendLayout();
            this.layoutCreateTeam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 4;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutMain.Controls.Add(this.label1, 1, 1);
            this.layoutMain.Controls.Add(this.buttonCreateMember, 1, 3);
            this.layoutMain.Controls.Add(this.buttonRemoveSelectedPlayer, 2, 3);
            this.layoutMain.Controls.Add(this.buttonCreateTeam, 1, 4);
            this.layoutMain.Controls.Add(this.listBoxTournamentPlayers, 2, 2);
            this.layoutMain.Controls.Add(this.layoutCreateTeam, 1, 2);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(4);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 6;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.layoutMain.Size = new System.Drawing.Size(645, 594);
            this.layoutMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Team";
            // 
            // buttonCreateMember
            // 
            this.buttonCreateMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateMember.Location = new System.Drawing.Point(94, 486);
            this.buttonCreateMember.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateMember.Name = "buttonCreateMember";
            this.buttonCreateMember.Size = new System.Drawing.Size(160, 35);
            this.buttonCreateMember.TabIndex = 7;
            this.buttonCreateMember.Text = "Create Member";
            this.buttonCreateMember.UseVisualStyleBackColor = true;
            this.buttonCreateMember.Click += new System.EventHandler(this.buttonCreateMember_Click);
            // 
            // buttonRemoveSelectedPlayer
            // 
            this.buttonRemoveSelectedPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemoveSelectedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSelectedPlayer.Location = new System.Drawing.Point(389, 486);
            this.buttonRemoveSelectedPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveSelectedPlayer.Name = "buttonRemoveSelectedPlayer";
            this.buttonRemoveSelectedPlayer.Size = new System.Drawing.Size(160, 35);
            this.buttonRemoveSelectedPlayer.TabIndex = 2;
            this.buttonRemoveSelectedPlayer.Text = "Remove Selected";
            this.buttonRemoveSelectedPlayer.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedPlayer.Click += new System.EventHandler(this.buttonRemoveSelectedPlayer_Click);
            // 
            // buttonCreateTeam
            // 
            this.buttonCreateTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutMain.SetColumnSpan(this.buttonCreateTeam, 2);
            this.buttonCreateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTeam.Location = new System.Drawing.Point(242, 534);
            this.buttonCreateTeam.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateTeam.Name = "buttonCreateTeam";
            this.buttonCreateTeam.Size = new System.Drawing.Size(160, 35);
            this.buttonCreateTeam.TabIndex = 8;
            this.buttonCreateTeam.Text = "Create Team";
            this.buttonCreateTeam.UseVisualStyleBackColor = true;
            this.buttonCreateTeam.Click += new System.EventHandler(this.buttonCreateTeam_Click);
            // 
            // listBoxTournamentPlayers
            // 
            this.listBoxTournamentPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTournamentPlayers.FormattingEnabled = true;
            this.listBoxTournamentPlayers.ItemHeight = 16;
            this.listBoxTournamentPlayers.Location = new System.Drawing.Point(326, 78);
            this.listBoxTournamentPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTournamentPlayers.Name = "listBoxTournamentPlayers";
            this.listBoxTournamentPlayers.Size = new System.Drawing.Size(287, 398);
            this.listBoxTournamentPlayers.TabIndex = 4;
            // 
            // layoutCreateTeam
            // 
            this.layoutCreateTeam.ColumnCount = 2;
            this.layoutCreateTeam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.08362F));
            this.layoutCreateTeam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.91638F));
            this.layoutCreateTeam.Controls.Add(this.label2, 0, 0);
            this.layoutCreateTeam.Controls.Add(this.label3, 0, 2);
            this.layoutCreateTeam.Controls.Add(this.textBoxTeamName, 0, 1);
            this.layoutCreateTeam.Controls.Add(this.comboBoxTeamMember, 0, 3);
            this.layoutCreateTeam.Controls.Add(this.buttonAddMember, 0, 4);
            this.layoutCreateTeam.Controls.Add(this.groupBox1, 0, 5);
            this.layoutCreateTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCreateTeam.Location = new System.Drawing.Point(31, 78);
            this.layoutCreateTeam.Margin = new System.Windows.Forms.Padding(4);
            this.layoutCreateTeam.Name = "layoutCreateTeam";
            this.layoutCreateTeam.RowCount = 6;
            this.layoutCreateTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutCreateTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutCreateTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutCreateTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutCreateTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layoutCreateTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCreateTeam.Size = new System.Drawing.Size(287, 398);
            this.layoutCreateTeam.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team Name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.layoutCreateTeam.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Team Member";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutCreateTeam.SetColumnSpan(this.textBoxTeamName, 2);
            this.textBoxTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamName.Location = new System.Drawing.Point(4, 36);
            this.textBoxTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(279, 27);
            this.textBoxTeamName.TabIndex = 1;
            // 
            // comboBoxTeamMember
            // 
            this.comboBoxTeamMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutCreateTeam.SetColumnSpan(this.comboBoxTeamMember, 2);
            this.comboBoxTeamMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeamMember.FormattingEnabled = true;
            this.comboBoxTeamMember.Location = new System.Drawing.Point(4, 106);
            this.comboBoxTeamMember.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTeamMember.Name = "comboBoxTeamMember";
            this.comboBoxTeamMember.Size = new System.Drawing.Size(279, 28);
            this.comboBoxTeamMember.TabIndex = 2;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layoutCreateTeam.SetColumnSpan(this.buttonAddMember, 2);
            this.buttonAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMember.Location = new System.Drawing.Point(63, 144);
            this.buttonAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(160, 37);
            this.buttonAddMember.TabIndex = 13;
            this.buttonAddMember.Text = "Add Member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // groupBox1
            // 
            this.layoutCreateTeam.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 189);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(279, 205);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Member";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2549F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.7451F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNewMemberPhoneNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNewMemberFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNewMemberEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNewMemberLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 21);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 180);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "First Name";
            // 
            // textBoxNewMemberPhoneNumber
            // 
            this.textBoxNewMemberPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewMemberPhoneNumber.Location = new System.Drawing.Point(104, 145);
            this.textBoxNewMemberPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewMemberPhoneNumber.Name = "textBoxNewMemberPhoneNumber";
            this.textBoxNewMemberPhoneNumber.Size = new System.Drawing.Size(163, 24);
            this.textBoxNewMemberPhoneNumber.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Phone";
            // 
            // textBoxNewMemberFirstName
            // 
            this.textBoxNewMemberFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewMemberFirstName.Location = new System.Drawing.Point(104, 10);
            this.textBoxNewMemberFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewMemberFirstName.Name = "textBoxNewMemberFirstName";
            this.textBoxNewMemberFirstName.Size = new System.Drawing.Size(163, 24);
            this.textBoxNewMemberFirstName.TabIndex = 3;
            // 
            // textBoxNewMemberEmail
            // 
            this.textBoxNewMemberEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewMemberEmail.Location = new System.Drawing.Point(104, 100);
            this.textBoxNewMemberEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewMemberEmail.Name = "textBoxNewMemberEmail";
            this.textBoxNewMemberEmail.Size = new System.Drawing.Size(163, 24);
            this.textBoxNewMemberEmail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Last Name";
            // 
            // textBoxNewMemberLastName
            // 
            this.textBoxNewMemberLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewMemberLastName.Location = new System.Drawing.Point(104, 55);
            this.textBoxNewMemberLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewMemberLastName.Name = "textBoxNewMemberLastName";
            this.textBoxNewMemberLastName.Size = new System.Drawing.Size(163, 24);
            this.textBoxNewMemberLastName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // TeamCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 594);
            this.Controls.Add(this.layoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamCreator";
            this.Text = "TeamCreator";
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            this.layoutCreateTeam.ResumeLayout(false);
            this.layoutCreateTeam.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateMember;
        private System.Windows.Forms.Button buttonRemoveSelectedPlayer;
        private System.Windows.Forms.Button buttonCreateTeam;
        private System.Windows.Forms.ListBox listBoxTournamentPlayers;
        private System.Windows.Forms.TableLayoutPanel layoutCreateTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.TextBox textBoxNewMemberFirstName;
        private System.Windows.Forms.TextBox textBoxNewMemberLastName;
        private System.Windows.Forms.TextBox textBoxNewMemberPhoneNumber;
        private System.Windows.Forms.TextBox textBoxNewMemberEmail;
        private System.Windows.Forms.ComboBox comboBoxTeamMember;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}