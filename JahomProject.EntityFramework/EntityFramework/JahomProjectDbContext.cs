using System.Data.Common;
using Abp.Zero.EntityFramework;
using JahomProject.Authorization.Roles;
using JahomProject.Authorization.Users;
using JahomProject.MultiTenancy;

namespace JahomProject.EntityFramework
{
    public class JahomProjectDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public JahomProjectDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in JahomProjectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of JahomProjectDbContext since ABP automatically handles it.
         */
        public JahomProjectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public JahomProjectDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public JahomProjectDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
