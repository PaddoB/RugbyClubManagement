namespace RugbyClubManagement
{
    partial class AddTeamForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.DateTimePicker dtpFoundedDate;
        private System.Windows.Forms.Button btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.dtpFoundedDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(30, 30);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(200, 22);
            this.txtTeamName.TabIndex = 0;
            // 
            // txtCoachName
            // 
            this.txtCoachName.Location = new System.Drawing.Point(30, 70);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(200, 22);
            this.txtCoachName.TabIndex = 1;
            // 
            // dtpFoundedDate
            // 
            this.dtpFoundedDate.Location = new System.Drawing.Point(30, 110);
            this.dtpFoundedDate.Name = "dtpFoundedDate";
            this.dtpFoundedDate.Size = new System.Drawing.Size(200, 22);
            this.dtpFoundedDate.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Team";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddPlayerForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpFoundedDate);
            this.Controls.Add(this.txtCoachName);
            this.Controls.Add(this.txtTeamName);
            this.Name = "AddTeamForm";
            this.Text = "Add Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

