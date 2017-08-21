using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace JahomProject.EntityFramework.Repositories
{
    public abstract class JahomProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<JahomProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected JahomProjectRepositoryBase(IDbContextProvider<JahomProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class JahomProjectRepositoryBase<TEntity> : JahomProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected JahomProjectRepositoryBase(IDbContextProvider<JahomProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
