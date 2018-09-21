using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Abstract;

namespace Tatilcim.Core.Repository
{
    public abstract class AbstractBaseRepository<T> : IDisposable where T : class, IBaseEntity
    {
        internal TatilcimContext context = null;

        public AbstractBaseRepository()
        {
            context = new TatilcimContext();
        }

        public DbSet<T> Entity
        {
            get { return context.Set<T>(); }
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

        public IQueryable<E> Query<E>() where E : class
        {
            return context.Set<E>();
        }

        public virtual bool Add(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            Entity.Add(entity);

            return context.SaveChanges() > 0;
        }


        public virtual T Find(int Id)
        {
            return Entity.FirstOrDefault(x => x.Id == Id);
        }

        public virtual bool DeleteAt(T entity)
        {
            if (entity != null)
            {
                var record = Find(entity.Id);
                if (record == null)
                {
                    throw new NullReferenceException(nameof(entity.Id));
                }

                record.DeletedAt = DateTime.Now;
                return context.SaveChanges() > 0;
            }

            throw new ArgumentOutOfRangeException(nameof(entity.Id));
        }

        public virtual bool Delete(T entity)
        {
            if (entity != null && entity.Id != default(int))
            {
                var record = Find(entity.Id);
                if (record == null)
                {
                    throw new NullReferenceException(nameof(entity.Id));
                }

                Entity.Remove(entity);
                return context.SaveChanges() > 0;
            }
            throw new ArgumentOutOfRangeException(nameof(entity.Id));
        }

        public virtual bool Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentOutOfRangeException(nameof(entity.Id));
            }

            var record = Find(entity.Id);
            if (record == null)
            {
                throw new NullReferenceException(nameof(entity.Id));
            }

            record = entity;

            return context.SaveChanges() > 0;
        }

    }
    public class BaseRepository<T> : AbstractBaseRepository<T>
        where T : class, IBaseEntity
    {
    }
}
