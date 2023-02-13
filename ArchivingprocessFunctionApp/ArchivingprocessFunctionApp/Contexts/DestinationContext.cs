using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ArchivingprocessFunctionApp.Models;
using ArchivingprocessFunctionApp.Envvar;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ArchivingprocessFunctionApp.Contexts
{
    public partial class DestinationContext : DbContext
    {
        private CommunityAccessDetails environmentVariables;

        public DestinationContext()
        {
            var propertiesUtils = new PropertiesUtils();
            environmentVariables = propertiesUtils.SetupEnvVariable();
        }

        public DestinationContext(DbContextOptions<DestinationContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(environmentVariables.DtrDatabaseConn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var monthName = "_" + DateTime.Now.AddDays(-210).ToString("MMM");

            List<string> tableNames = environmentVariables.TableNamesList.Split(',').ToList();

            foreach (var tableName in tableNames)
            {
                Type Calculate = typeof(DynamicContext<>);
                Type[] typeArgs = { Type.GetType("ArchivingprocessFunctionApp.Models." + tableName) };
                Type repositoryType = Calculate.MakeGenericType(typeArgs);
                object repository = Activator.CreateInstance(repositoryType);
                MethodInfo genericMethod = repositoryType.GetMethod("OnModelCreating");
                genericMethod.Invoke(repository, new object[] { modelBuilder, tableName+ monthName });
            }
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
