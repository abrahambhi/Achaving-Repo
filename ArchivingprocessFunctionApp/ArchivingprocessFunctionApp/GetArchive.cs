using System;
using System.Globalization;
using ArchivingprocessFunctionApp.Contexts;
using ArchivingprocessFunctionApp.Envvar;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ArchivingprocessFunctionApp
{
    public class GetArchive
    {
        private static PropertiesUtils propertiesUtils;
        private static CommunityAccessDetails environmentVariables;
        [FunctionName("Function1")]
        public  void Run([TimerTrigger("%Time%", RunOnStartup =true)]TimerInfo myTimer, ILogger log)
        {
            try
            {
                CultureInfo cultures = new CultureInfo("en-US");
                DateTime toDate = DateTime.UtcNow;
                var currentTime = toDate.ToString("HH:mm", cultures);
                propertiesUtils = new PropertiesUtils();
                environmentVariables = propertiesUtils.SetupEnvVariable();
                //var archive = new Archive();
                //archive.ArchivingProcess(environmentVariables, log);
                log.LogInformation("Current time " + currentTime);
                log.LogInformation("Schedule time " + environmentVariables.ScheduleTime);
                DateTime scheduledtime = DateTime.ParseExact(environmentVariables.ScheduleTime, "HH:mm", cultures);
                TimeSpan diff = toDate - scheduledtime;
                var min = Math.Abs((int)diff.TotalMinutes);
                if (min <= environmentVariables.timeDiff)
                {
                    DateTime startDate;
                    DateTime endDate;
                    if (null != myTimer)
                    {
                        startDate = DateTime.Now;
                        var archive = new Archive();
                        archive.ArchivingProcess(environmentVariables, log);
                        endDate = DateTime.Now;
                    }
                }
                else
                {
                    log.LogInformation("Current time not matched with schedule time...So that We stopped the FA running");
                }
            }
            catch (Exception e)
            {
                log.LogInformation("Exception has occured\n" + e, e);
            }          
        }
       
    }
}
