using SpesificationDemo.Bll.Models.Common;
using System;

namespace SpesificationDemo.Bll.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        int Complete();
    }
}
