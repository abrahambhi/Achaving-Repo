using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class Messages_Spam_Ham_AC:ITable
    {
        public string ActionKey { get; set; }
        public DateTime? EventTimeMs { get; set; }
        public long MessageUid { get; set; }
        [Key]
        public long ConversationUid { get; set; }
        public string rowId { get; set; }
        public long UserId { get; set; }

        public virtual UserDetails_PowerBi User { get; set; }
    }
}
