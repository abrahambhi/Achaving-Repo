using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class Survey_PowerBi:ITable
    {
        public long Id { get; set; }
        public string ActionKey { get; set; }
        public string SurveyId { get; set; }
        public string SurveyResponse { get; set; }
        public long? UserId { get; set; }
        public string VisitorId { get; set; }
        public string boardId { get; set; }
        public string boardUid { get; set; }
        public string documentId { get; set; }
        [Column("eventTimems")]
        public DateTime? EventTimeMs { get; set; }
        public string requestDevice { get; set; }
        public string surveyType { get; set; }
        public string visitId { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
    }
}
