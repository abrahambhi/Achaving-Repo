using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class User_UserRoles_PowerBi
    {
        public long id { get; set; }
        public long? Role_id { get; set; }
        public string deleted { get; set; }
        public long? UserId { get; set; }
    }
}
