using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class User_UG_MPP
    {
        public DateTime? GeneratedDate { get; set; }
        public string GroupID { get; set; }
        public long? UserID { get; set; }
        public string Role { get; set; }
        public DateTime? JoinedDate { get; set; }

        public virtual UserDetails_PowerUsers User { get; set; }
    }
}
