using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SpeedTest.EntityFramework;

namespace SpeedTest
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SpeedTestCoreModule))]
    public class SpeedTestDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SpeedTestDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
