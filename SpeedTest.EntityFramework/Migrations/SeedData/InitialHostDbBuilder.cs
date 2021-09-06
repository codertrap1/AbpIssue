using SpeedTest.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SpeedTest.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SpeedTestDbContext _context;

        public InitialHostDbBuilder(SpeedTestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
