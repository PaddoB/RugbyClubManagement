using RugbyClubManagement.Data;
using RugbyClubManagement.Models;
using System;
using System.Windows.Forms;

namespace RugbyClubManagement
{
    public partial class AddTeamForm : Form
    {
        private DatabaseManager dbManager;

        public AddTeamForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Team team = new Team
            {
                TeamName = txtTeamName.Text,
                CoachName = txtCoachName.Text,
                FoundedDate = dtpFoundedDate.Value
             
            };

            dbManager.InsertTeam(team);
            MessageBox.Show("Team added successfully!");
            this.Close();
        }
    }
}
