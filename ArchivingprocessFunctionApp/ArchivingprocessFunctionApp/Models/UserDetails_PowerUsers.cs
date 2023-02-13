using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class UserDetails_PowerUsers
    {
        public UserDetails_PowerUsers()
        {
            Kudos_MPP = new HashSet<Kudos_MPP>();
            Kudos_Stream = new HashSet<Kudos_Stream>();
            Messages_Spam_Ham_MPP = new HashSet<Messages_Spam_Ham_MPP>();
            Messages_Stream = new HashSet<Messages_Stream>();
            Replies_Stream = new HashSet<Replies_Stream>();
            Solutions_MPP = new HashSet<Solutions_MPP>();
            Solutions_Stream = new HashSet<Solutions_Stream>();
            User_UserRoles_PowerUsers = new HashSet<User_UserRoles_PowerUsers>();
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
        public string OID { get; set; }
        public string CID { get; set; }
        public string TID { get; set; }
        public string SSO_ID { get; set; }
        public int? RankId { get; set; }

        public virtual ICollection<Kudos_MPP> Kudos_MPP { get; set; }
        public virtual ICollection<Kudos_Stream> Kudos_Stream { get; set; }
        public virtual ICollection<Messages_Spam_Ham_MPP> Messages_Spam_Ham_MPP { get; set; }
        public virtual ICollection<Messages_Stream> Messages_Stream { get; set; }
        public virtual ICollection<Replies_Stream> Replies_Stream { get; set; }
        public virtual ICollection<Solutions_MPP> Solutions_MPP { get; set; }
        public virtual ICollection<Solutions_Stream> Solutions_Stream { get; set; }
        public virtual ICollection<User_UserRoles_PowerUsers> User_UserRoles_PowerUsers { get; set; }
    }
}
