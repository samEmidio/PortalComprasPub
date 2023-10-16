// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.



using Microsoft.EntityFrameworkCore;
using PortalComprasPub.Domain.Core.Entities;
using PortalComprasPub.Domain.Interfaces;
using PortalComprasPub.Infrastructure.Data.Context;

namespace PortalComprasPub.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly PortalContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(PortalContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }


        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            Db.AddRange(entities);
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual IQueryable<TEntity> GetAllDesc()
        {
            return DbSet.OrderByDescending(x => x.CreatedAt);
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
