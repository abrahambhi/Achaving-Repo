using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class UserDetails_PowerBi_API
    {
        public long id { get; set; }
        public string FirstName { get; set; }
        public DateTime? LastVisitTime { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Href { get; set; }
        public string Login { get; set; }
        public string Rank { get; set; }
        public DateTime? RegistrationTime { get; set; }
        public long UserId { get; set; }
        public string ViewHref { get; set; }
        public string UserStatus { get; set; }
        public string Banned { get; set; }
        public string Deleted { get; set; }
        public string CID { get; set; }
        public string OID { get; set; }
        public string TID { get; set; }
        public string SSO_ID { get; set; }
        public int? RankId { get; set; }
    }
}
