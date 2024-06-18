using RugbyClubManagement.Data;
using System;
using System.Windows.Forms;

namespace RugbyClubManagement
{
    public partial class MainForm : Form
    {
        private DatabaseManager dbManager;

        public MainForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void btnImportPlayers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Import Players from CSV"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dbManager.ImportPlayersFromCSV(openFileDialog.FileName);
                MessageBox.Show("Players imported successfully!");
            }
        }

        private void btnImportTeams_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Import Teams from CSV"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dbManager.ImportTeamsFromCSV(openFileDialog.FileName);
                MessageBox.Show("Teams imported successfully!");
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            string playerName = Prompt.ShowDialog("Enter Player Name to Delete:", "Delete Player");
            if (dbManager.DeletePlayer(playerName))
            {
                MessageBox.Show("Player deleted successfully!");
            }
            else
            {
                MessageBox.Show("Player not found.");
            }
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            string teamName = Prompt.ShowDialog("Enter Team Name to Delete:", "Delete Team");
            if (dbManager.DeleteTeam(teamName))
            {
                MessageBox.Show("Team deleted successfully!");
            }
            else
            {
                MessageBox.Show("Team not found.");
            }
        }

        private void btnShowPlayers_Click(object sender, EventArgs e)
        {
            var players = dbManager.GetAllPlayers();
            MessageBox.Show(string.Join("\n", players), "All Players");
        }

        private void btnShowTeams_Click(object sender, EventArgs e)
        {
            var teams = dbManager.GetAllTeams();
            MessageBox.Show(string.Join("\n", teams), "All Teams");
        }
        // Obslužná rutina pro nové tlačítko
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.ShowDialog();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm();
            addTeamForm.ShowDialog();
        }
    }
}
