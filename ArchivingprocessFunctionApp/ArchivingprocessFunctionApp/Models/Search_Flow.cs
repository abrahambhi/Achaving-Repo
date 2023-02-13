using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class Search_Flow:ITable
    {
        public long id { get; set; }
        public string ActionKey { get; set; }
        public string search_entity_type { get; set; }
        public string search_filters { get; set; }
        public string search_has_results { get; set; }
        public string search_location { get; set; }
        public string search_page_number { get; set; }
        public long? userId { get; set; }
        [Key]
        public string ConversationId { get; set; }
        [Column("EventTimems")]
        public DateTime? EventTimeMs { get; set; }
        public string MessageId { get; set; }
        public string RequestDevice { get; set; }
        public string ResultsPresent { get; set; }
        public string RowId { get; set; }
        public string SearchEntity { get; set; }
        public string SearchFilters { get; set; }
        public string SearchHasResults { get; set; }
        public string SearchLocation { get; set; }
        public string SearchPageNumber { get; set; }
        public string SearchTerms { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string VisitId { get; set; }
        public string VisitorId { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
        public string action_key { get; set; }
    }
}
