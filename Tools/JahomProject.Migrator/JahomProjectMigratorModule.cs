using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using JahomProject.EntityFramework;

namespace JahomProject.Migrator
{
    [DependsOn(typeof(JahomProjectDataModule))]
    public class JahomProjectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<JahomProjectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}