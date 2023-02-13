using ArchivingprocessFunctionApp.Contexts;
using ArchivingprocessFunctionApp.Envvar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchivingprocessFunctionApp
{
    public class CalculateDays<T> where T : class, ITable
    {
        [Obsolete]
        public void CopyTable(string TableName, ILogger log)
        {
            var monthName = "_" + DateTime.Now.AddDays(-210).ToString("MMM");
            TableName = TableName + monthName;
            try
            {
                using (SourceContext sourceEftestContext = new SourceContext())
                {
                    T[] Data = null;
                    var DateTimezone = DateTime.UtcNow.Date;
                    var EventTime = DateTimezone.AddDays(-210);
                    Data = sourceEftestContext.Set<T>().Where(x => x.EventTimeMs.Value.Date == EventTime.Date).ToArray();
                    var count = Data.Count();
                    log.LogInformation("TableName is :" + TableName);
                    log.LogInformation("count is :" + count);
                    using (DestinationContext destinationContext = new DestinationContext())
                    {                       

                        destinationContext.Database.OpenConnection();
                        try
                        {
                          destinationContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT " + TableName + " ON");
                        }
                        catch
                        {

                        }                     
                        destinationContext.Set<T>().AddRange(Data);
                        destinationContext.SaveChanges();
                        try
                        {
                            destinationContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT " + TableName + " OFF");
                        }
                        catch
                        {

                        }
                      
                        destinationContext.Database.CloseConnection();                       
                    }
                }
            }
            catch (Exception e)
            {
                log.LogInformation("Exception has occured\n" + e, e);
            }            
        }
    }

}
