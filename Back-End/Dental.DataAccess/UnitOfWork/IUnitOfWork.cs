using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.DataAccess.Interface.Base;
using Dental.Entities.Interface;

namespace Dental.DataAccess.UnitOfWork
{
    //Disposable kullanılmadığında ramden atılmasını sağlar
    //Commit yapılan en son değişiklik veritabanına kaydeder
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Dal<TEntity>() where TEntity : class, IEntity, new();
        bool HasChanges();
        void DetectChange();
        bool Commit();
    }
}
