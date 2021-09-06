using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SpeedTest.EntityFramework.Repositories
{
    public abstract class SpeedTestRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SpeedTestDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SpeedTestRepositoryBase(IDbContextProvider<SpeedTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SpeedTestRepositoryBase<TEntity> : SpeedTestRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SpeedTestRepositoryBase(IDbContextProvider<SpeedTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
