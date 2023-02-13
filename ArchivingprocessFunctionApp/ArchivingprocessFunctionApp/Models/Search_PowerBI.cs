using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class Search_PowerBI:ITable
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public string ActionKey { get; set; }
        public long? UserId { get; set; }
        public string BoardId { get; set; }
        public string BoardUid { get; set; }    
        public string ConversationId { get; set; }
        [Column("EventTimems")]
        public DateTime? EventTimeMs { get; set; }
        public string MessageId { get; set; }
        public string RequestDevice { get; set; }
        public string ResultsPresent { get; set; }
        public string RowId { get; set; }
        public string SearchFilters { get; set; }
        public string SearchHasResults { get; set; }
        public string SearchLocation { get; set; }
        public string SearchPageNumber { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string VisitId { get; set; }
        public string VisitorId { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public string Region { get; set; }
        public string SearchEntity { get; set; }
        public string SearchTerms { get; set; }
    }
}
