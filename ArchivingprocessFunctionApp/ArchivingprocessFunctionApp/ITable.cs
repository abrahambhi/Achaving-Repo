using System;
using System.Collections.Generic;
using System.Text;

namespace ArchivingprocessFunctionApp
{
    public interface ITable
    {
        public DateTime? EventTimeMs { get; set; }
      
    }
}
