using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SpeedTest.EntityFramework;

namespace SpeedTest.Migrator
{
    [DependsOn(typeof(SpeedTestDataModule))]
    public class SpeedTestMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SpeedTestDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}