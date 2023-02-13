using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Models
{
    public partial class UserRoles_PowerBi
    {
        public long Id { get; set; }
        public string Href { get; set; }
        public string Name { get; set; }
        public long Role_id { get; set; }
        public string NodeType { get; set; }
        public long? userId { get; set; }
        public string node_type { get; set; }
        public string Deleted { get; set; }
    }
}
