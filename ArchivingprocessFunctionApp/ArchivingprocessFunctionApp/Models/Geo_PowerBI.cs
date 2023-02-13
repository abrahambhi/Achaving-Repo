using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class Geo_PowerBI :ITable
    {
        public long Id { get; set; }
        public string ActionKey { get; set; }
        public string BoardId { get; set; }
        public string BoardUid { get; set; }
        public string CommunityApp { get; set; }
        public string DeviceType { get; set; }
        public DateTime? EventTimeMs { get; set; }
        public string LongEventTime { get; set; }
        public string RequestGeoCountry { get; set; }
        public string RequestGeoCountryCode { get; set; }
        public string RequestGeoHash { get; set; }
        public string RequestGeoLatitude { get; set; }
        public string RequestGeoLongitude { get; set; }
        public string RequestGeoPostal { get; set; }
        public string RequestGeoTimezone { get; set; }
        public string RequestHeadersUserAgent { get; set; }
        public string RequestUrlHost { get; set; }
        public string RowId { get; set; }
        public long? TargetUserId { get; set; }
        public string TargetUserName { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string VisitId { get; set; }
        public string VisitorId { get; set; }
        public string Community_app { get; set; }
        public string RequestDevice { get; set; }
        public string ActionDuration { get; set; }
        public string ActionIsModeratorAction { get; set; }
        public string ActionIsSolutionView { get; set; }
        public string ActionSpanSeconds { get; set; }
        public string ActionWeight { get; set; }
        public string BadgeActivationDate { get; set; }
        public string BadgeIsRetroactive { get; set; }
        public string BadgeTitle { get; set; }
        public string BadgeUid { get; set; }
        public string BoardTitle { get; set; }
        public string ConversationTitle { get; set; }
        [Key]
        public string ConversationUid { get; set; }
        public string MessageIsTopic { get; set; }
        public string MessageSubject { get; set; }
        public string MessageType { get; set; }
        public long? MessageUid { get; set; }
        public string NodeAncestorPath { get; set; }
        public string RequestHeadersReferrerHost { get; set; }
        public string RequestHeadersReferrerUrl { get; set; }
        public string ResultsPresent { get; set; }
        public string SearchEntityType { get; set; }
        public string SearchFilters { get; set; }
        public string SearchHasResults { get; set; }
        public string SearchLocation { get; set; }
        public string SearchPageNumber { get; set; }
        public string SearchTerms { get; set; }
        public string SurveyId { get; set; }
        public string SurveyResponse { get; set; }
        public string SurveyType { get; set; }
        public string Tags { get; set; }
        public string TargetUserCommunityRankName { get; set; }
        public string TargetUserCommunityRoleName { get; set; }
        public string TargetUserRegistrationStatus { get; set; }
        public string UserCommunityRankName { get; set; }
        public string UserCommunityRoleName { get; set; }
        public string UserSsoId { get; set; }
        public string labels { get; set; }
        public string RequestGeoCity { get; set; }
        public string RequestGeoRegion { get; set; }
    }
}
