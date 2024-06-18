using System;

namespace RugbyClubManagement.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string CoachName { get; set; }
        public DateTime FoundedDate { get; set; }
    }
}
