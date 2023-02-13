using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class Kudos_PowerUsers
    {
        public long id { get; set; }
        public string BoardId { get; set; }
        public string BoardUid { get; set; }
        public string Category_id { get; set; }
        public string CommunityApp { get; set; }
        [Key]
        public long? ConversationUid { get; set; }
        public string deviceType { get; set; }
        public DateTime? Event_time_ms { get; set; }
        public string LongEventTime { get; set; }
        public string MessageType { get; set; }
        public long? MessageUid { get; set; }
        public string Subject { get; set; }
        public string TargetUserId { get; set; }
        public string TargetUserName { get; set; }
        public string UserName { get; set; }
        public long? UserId { get; set; }
        public string CategoryId { get; set; }
        public DateTime? EventTimeMs { get; set; }
        public string rowId { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
        public bool? DataMovedFlag { get; set; }
    }
}
