using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class User_UserRoles_PowerUsers
    {
        public int id { get; set; }
        public long UserId { get; set; }
        public long Role_id { get; set; }
        public string Deleted { get; set; }

        public virtual UserRoles_PowerUsers Role_ { get; set; }
        public virtual UserDetails_PowerUsers User { get; set; }
    }
}
