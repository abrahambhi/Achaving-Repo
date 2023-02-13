using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class UserActivity_PowerUsers:ITable
    {
        public long id { get; set; }
        public string ActionDuration { get; set; }
        public string ActionKey { get; set; }
        public string ActionWeight { get; set; }
        public string Activity { get; set; }
        public string BoardId { get; set; }
        public string BoardUid { get; set; }
        public string CategoryUrl { get; set; }
        public string Community_app { get; set; }
        public string DeviceType { get; set; }
        public DateTime? EventTimeMs { get; set; }
        public string LongEventTime { get; set; }
        public string RequestHeaderReferrelUrl { get; set; }
        public string TargetUserId { get; set; }
        public string TargetUserName { get; set; }
        public long? UserId { get; set; }
        public string VisitId { get; set; }
        public string VisitorId { get; set; }
        public string CommunityApp { get; set; }
        public string rowId { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
        public bool? DataMovedFlag { get; set; }
    }
}
