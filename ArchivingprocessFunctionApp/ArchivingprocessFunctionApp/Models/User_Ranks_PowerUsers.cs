using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class User_Ranks_PowerUsers
    {
        public int id { get; set; }
        public int? UserId { get; set; }
        public int? RankId { get; set; }
        public string rankName { get; set; }

       // public virtual Ranks_PowerUsers Rank { get; set; }
    }
}
