using Dental.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Business.Services.Base
{
    public interface IBaseService<TEntity> : IDisposable where TEntity : IEntity, new()
    {
        void Add(TEntity entity);
        void Add(IEnumerable<IEntity> entities);//birden fazla entity verirsen ben onların içinde dolaşıp hepsini kaydedirim
        void AddOrUpdate(TEntity entity);
        void AddOrUpdate(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity> entities);
        void Delete(Expression<Func<TEntity, bool>> filter);

        void EntityStateChange(Expression<Func<TEntity, bool>> filter, EntityState state);
        void EntityStateChange(TEntity entity, EntityState state);
        void EntityStateChange(IEnumerable<TEntity> entities, EntityState state);

        TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);//params birden fazla verinin parametre olarak yollandığı tiptir
        bool Exist(Expression<Func<TEntity, bool>> filter);

        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes);

        IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector,
            params Expression<Func<TEntity, object>>[] includes);
        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector,
            params Expression<Func<TEntity, object>>[] includes);

        void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);
        bool HasChanges();
        BindingList<TEntity> BindingList();//gridlerle anlık olarak çalışmasını sağlar
    }
}
