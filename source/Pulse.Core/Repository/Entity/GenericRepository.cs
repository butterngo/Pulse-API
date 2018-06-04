namespace Pulse.Core.Repository.Entity
{
    using Connection.Entity;
    using Domain;
    using System.Data.Entity;

    public sealed class GenericRepository<TEntity, TContext> : Repository<TEntity, TContext>, IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        public GenericRepository(TContext context) : base(context) { }

    }
}
