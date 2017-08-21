using System.Linq;
using JahomProject.EntityFramework;
using JahomProject.MultiTenancy;

namespace JahomProject.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly JahomProjectDbContext _context;

        public DefaultTenantCreator(JahomProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
