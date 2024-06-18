using RugbyClubManagement.Data;
using RugbyClubManagement.Models;
using System;
using System.Windows.Forms;

namespace RugbyClubManagement
{
    public partial class AddPlayerForm : Form
    {
        private DatabaseManager dbManager;

        public AddPlayerForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player player = new Player
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                IsActive = chkIsActive.Checked
            };

            dbManager.InsertPlayer(player);
            MessageBox.Show("Player added successfully!");
            this.Close();
        }
    }
}
