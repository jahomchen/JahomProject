using JahomProject.EntityFramework;
using EntityFramework.DynamicFilters;

namespace JahomProject.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly JahomProjectDbContext _context;

        public InitialHostDbBuilder(JahomProjectDbContext context)
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
