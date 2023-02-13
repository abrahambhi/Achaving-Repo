using System;
using System.Collections.Generic;
using System.Text;

namespace ArchivingprocessFunctionApp.Envvar
{
    public  class CommunityAccessDetails
    {
        public string StrDatabaseConn { get; set; }
     
        public string DtrDatabaseConn { get; set; }
        public string TableNamesList { get; set; }
        public string ScheduleTime { get; set; }
        public int timeDiff { get; set; }
    }
}
