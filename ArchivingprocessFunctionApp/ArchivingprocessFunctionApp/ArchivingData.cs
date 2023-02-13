using ArchivingprocessFunctionApp.Envvar;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ArchivingprocessFunctionApp
{

    public class Archive
    {
        public void ArchivingProcess(CommunityAccessDetails environmentalVariables, ILogger log)
        {
            List<string> tableNames = new List<string>();
            tableNames = environmentalVariables.TableNamesList.Split(',').ToList();
            try
            {
                foreach (var tableName in tableNames)
                {
                    Type Calculate = typeof(CalculateDays<>);
                    Type[] typeArgs = { Type.GetType("ArchivingprocessFunctionApp.Models." + tableName) };
                    Type repositoryType = Calculate.MakeGenericType(typeArgs);
                    object repository = Activator.CreateInstance(repositoryType);
                    MethodInfo genericMethod = repositoryType.GetMethod("CopyTable");
                    genericMethod.Invoke(repository, new object[] {tableName,log });
                    log.LogInformation("Table is completed: " + tableName);
                }
            }
            catch (Exception e)
            {
                log.LogInformation("Exception has occured\n" + e, e);
            }

        }

    }


}
