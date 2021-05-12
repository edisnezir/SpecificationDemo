using SpesificationDemo.Bll.Spesifications.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SpesificationDemo.Bll.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Find(BaseSpecification<TEntity> specification = null);
    }

}
