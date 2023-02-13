using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ArchivingprocessFunctionApp.Models;
using ArchivingprocessFunctionApp.Envvar;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace ArchivingprocessFunctionApp.Contexts
{
    public partial class SourceContext : DbContext
    {
        private CommunityAccessDetails environmentVariables;

        public SourceContext()
        {
            var propertiesUtils = new PropertiesUtils();
            environmentVariables = propertiesUtils.SetupEnvVariable();
        }

        public SourceContext(DbContextOptions<SourceContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(environmentVariables.StrDatabaseConn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            List<string> tableNames = environmentVariables.TableNamesList.Split(',').ToList();
            foreach (var tableName in tableNames)
            {
                Type Calculate = typeof(DynamicContext<>);
                Type[] typeArgs = { Type.GetType("ArchivingprocessFunctionApp.Models." + tableName) };
                Type repositoryType = Calculate.MakeGenericType(typeArgs);
                object repository = Activator.CreateInstance(repositoryType);
                MethodInfo genericMethod = repositoryType.GetMethod("OnModelCreating");
                genericMethod.Invoke(repository, new object[] { modelBuilder, tableName });
            }
           
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
