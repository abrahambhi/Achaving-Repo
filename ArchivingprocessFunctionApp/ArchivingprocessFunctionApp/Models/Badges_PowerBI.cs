using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class Badges_PowerBI
    {
        public int Id { get; set; }
        public int BadgeId { get; set; }
        public string Title { get; set; }
        public DateTime? Activation_Date { get; set; }
        public int? Awarded { get; set; }
        public string Description { get; set; }
        public string Href { get; set; }
        public string Icon_url { get; set; }
        public DateTime? deleted { get; set; }
    }
}
