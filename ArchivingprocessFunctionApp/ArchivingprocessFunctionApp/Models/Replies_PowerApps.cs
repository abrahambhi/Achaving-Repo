using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class Replies_PowerApps:ITable
    {
        public long Id { get; set; }
        public string ActionKey { get; set; }
        public string Board_uid { get; set; }
        public string BoardId { get; set; }
        public string CommunityApp { get; set; }
        public string DeviceType { get; set; }
        public DateTime? EventTimeMs { get; set; }
        public string LongEventTime { get; set; }
        public long? MessageUid { get; set; }
        public string MessageType { get; set; }
        public long? Mid { get; set; }
        public long? ReplyDuration { get; set; }
        public string ReplySubject { get; set; }
        public long ReplyId { get; set; }
        public string ActionSpanSeconds { get; set; }
        public string TargetUserId { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string BoardUid { get; set; }
        public string rowId { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
        public bool? DataMovedFlag { get; set; }
    }
}
