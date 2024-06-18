using System;

namespace RugbyClubManagement.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        public int PlayerID { get; set; }
        public int TeamID { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}

