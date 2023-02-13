using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace ArchivingprocessFunctionApp.Envvar
{
    public class PropertiesUtils
    {
        public  CommunityAccessDetails SetupEnvVariable()
        {
            CultureInfo cultures = new CultureInfo("en-US");
            CommunityAccessDetails environmentVariables = null;
            try
            {

                environmentVariables = new CommunityAccessDetails
                {
                    //Fetching values from properties file
                    StrDatabaseConn = System.Environment.GetEnvironmentVariable("DatabaseConnection", EnvironmentVariableTarget.Process),
                    DtrDatabaseConn = System.Environment.GetEnvironmentVariable("DestinationConnection", EnvironmentVariableTarget.Process),
                    TableNamesList = System.Environment.GetEnvironmentVariable("tableNamesList", EnvironmentVariableTarget.Process),
                    ScheduleTime = System.Environment.GetEnvironmentVariable("ScheduleTime", EnvironmentVariableTarget.Process),
                    timeDiff = Convert.ToInt32(System.Environment.GetEnvironmentVariable("TimeDiff", EnvironmentVariableTarget.Process), cultures),
                };
            }
            catch
            {
                throw;
            }
            return environmentVariables;
        }
    }
}
