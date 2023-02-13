using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArchivingprocessFunctionApp.Contexts
{
    class DynamicContext<T> where T:class
    {
        public void OnModelCreating(ModelBuilder modelBuilder,string tableName)
        {
            modelBuilder.Entity<T>(entity =>
            {
                entity.ToTable(tableName);
               
            });
        }
    }
    
}
