using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class SolutionsInMessages
    {
        public string Title { get; set; }
        public string BoardUid { get; set; }
        public DateTime? SolinMsgEventTimeMs { get; set; }
        public DateTime? spvaEventTimeMs { get; set; }
        public long? Conversationuid { get; set; }
    }
}
