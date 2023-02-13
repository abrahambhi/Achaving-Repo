using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class UserDetails_PowerBi
    {
        public UserDetails_PowerBi()
        {
            Messages_Spam_Ham_AC = new HashSet<Messages_Spam_Ham_AC>();
            Messages_Spam_Ham_Flow = new HashSet<Messages_Spam_Ham_Flow>();
            Messages_Spam_Ham_PVA = new HashSet<Messages_Spam_Ham_PVA>();
            Messages_Spam_Ham_PowerApps = new HashSet<Messages_Spam_Ham_PowerApps>();
            Messages_Spam_Ham_PowerBI = new HashSet<Messages_Spam_Ham_PowerBI>();
            Messages_Spam_Ham_PowerUsers = new HashSet<Messages_Spam_Ham_PowerUsers>();
            User_UserRoles = new HashSet<User_UserRoles>();
        }

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

        public virtual ICollection<Messages_Spam_Ham_AC> Messages_Spam_Ham_AC { get; set; }
        public virtual ICollection<Messages_Spam_Ham_Flow> Messages_Spam_Ham_Flow { get; set; }
        public virtual ICollection<Messages_Spam_Ham_PVA> Messages_Spam_Ham_PVA { get; set; }
        public virtual ICollection<Messages_Spam_Ham_PowerApps> Messages_Spam_Ham_PowerApps { get; set; }
        public virtual ICollection<Messages_Spam_Ham_PowerBI> Messages_Spam_Ham_PowerBI { get; set; }
        public virtual ICollection<Messages_Spam_Ham_PowerUsers> Messages_Spam_Ham_PowerUsers { get; set; }
        public virtual ICollection<User_UserRoles> User_UserRoles { get; set; }
    }
}
