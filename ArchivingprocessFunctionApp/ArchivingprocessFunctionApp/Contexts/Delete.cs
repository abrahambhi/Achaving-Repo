using ArchivingprocessFunctionApp.Envvar;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchivingprocessFunctionApp.Contexts
{
    public class Delete
    {
        public void Deletedata(List<string> tableNames, CommunityAccessDetails environmentalVariables, ILogger log)
        {          
            using (SqlConnection sqlConn = new SqlConnection(environmentalVariables.DtrDatabaseConn))
            {
                sqlConn.Open();
                try
                {
                    foreach (var tableName in tableNames)
                    {
                        string deleteQuery = $"Delete from {environmentalVariables.StrDatabaseConn} where EventTimeMs = " + tableName;
                        var sqlCommand1 = new SqlCommand(deleteQuery, sqlConn);
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    log.LogInformation("Exception has occured\n" + ex, ex);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }
    }
}
