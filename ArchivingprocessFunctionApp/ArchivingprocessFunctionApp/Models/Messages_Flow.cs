using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class Messages_Flow :ITable
    {
        public long Mid { get; set; }
        public string ActionWeight { get; set; }
        public string ActionKey { get; set; }
        public string BoardUid { get; set; }
        public string BoardId { get; set; }
        public string CommunityApp { get; set; }
        public string DeviceType { get; set; }
        public DateTime? EventTimeMs { get; set; }
        public string LabelId { get; set; }
        public string LabelName { get; set; }
        public string LongEventTime { get; set; }
        [Key]
        public long ConversationId { get; set; }
        public string MessageIsTopic { get; set; }
        public string MessageSubject { get; set; }
        public string MessageType { get; set; }
        public string TagId { get; set; }
        public string TagName { get; set; }
        public string TargetUserId { get; set; }
        public string UserName { get; set; }
        public string UserCommunityRoleName { get; set; }
        public long? UserId { get; set; }
        public string rowId { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
    }
}
