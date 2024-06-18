namespace RugbyClubManagement
{
    partial class MainForm
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
            this.btnImportPlayers = new System.Windows.Forms.Button();
            this.btnImportTeams = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnShowPlayers = new System.Windows.Forms.Button();
            this.btnShowTeams = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportPlayers
            // 
            this.btnImportPlayers.Location = new System.Drawing.Point(12, 12);
            this.btnImportPlayers.Name = "btnImportPlayers";
            this.btnImportPlayers.Size = new System.Drawing.Size(120, 30);
            this.btnImportPlayers.TabIndex = 0;
            this.btnImportPlayers.Text = "Import Players";
            this.btnImportPlayers.UseVisualStyleBackColor = true;
            this.btnImportPlayers.Click += new System.EventHandler(this.btnImportPlayers_Click);
            // 
            // btnImportTeams
            // 
            this.btnImportTeams.Location = new System.Drawing.Point(12, 48);
            this.btnImportTeams.Name = "btnImportTeams";
            this.btnImportTeams.Size = new System.Drawing.Size(120, 30);
            this.btnImportTeams.TabIndex = 1;
            this.btnImportTeams.Text = "Import Teams";
            this.btnImportTeams.UseVisualStyleBackColor = true;
            this.btnImportTeams.Click += new System.EventHandler(this.btnImportTeams_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(12, 84);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(120, 30);
            this.btnDeletePlayer.TabIndex = 2;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(12, 120);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteTeam.TabIndex = 3;
            this.btnDeleteTeam.Text = "Delete Team";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // btnShowPlayers
            // 
            this.btnShowPlayers.Location = new System.Drawing.Point(12, 156);
            this.btnShowPlayers.Name = "btnShowPlayers";
            this.btnShowPlayers.Size = new System.Drawing.Size(120, 30);
            this.btnShowPlayers.TabIndex = 4;
            this.btnShowPlayers.Text = "Show Players";
            this.btnShowPlayers.UseVisualStyleBackColor = true;
            this.btnShowPlayers.Click += new System.EventHandler(this.btnShowPlayers_Click);
            // 
            // btnShowTeams
            // 
            this.btnShowTeams.Location = new System.Drawing.Point(12, 192);
            this.btnShowTeams.Name = "btnShowTeams";
            this.btnShowTeams.Size = new System.Drawing.Size(120, 30);
            this.btnShowTeams.TabIndex = 5;
            this.btnShowTeams.Text = "Show Teams";
            this.btnShowTeams.UseVisualStyleBackColor = true;
            this.btnShowTeams.Click += new System.EventHandler(this.btnShowTeams_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(12, 228);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(120, 30);
            this.btnAddPlayer.TabIndex = 6;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(12, 264);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(120, 30);
            this.btnAddTeam.TabIndex = 6;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.btnShowTeams);
            this.Controls.Add(this.btnShowPlayers);
            this.Controls.Add(this.btnDeleteTeam);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnImportTeams);
            this.Controls.Add(this.btnImportPlayers);
            this.Name = "MainForm";
            this.Text = "Rugby Club Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportPlayers;
        private System.Windows.Forms.Button btnImportTeams;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.Button btnShowPlayers;
        private System.Windows.Forms.Button btnShowTeams;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnAddTeam;// Přidáno nové tlačítko
    }
}
