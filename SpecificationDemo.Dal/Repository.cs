using Microsoft.EntityFrameworkCore;
using SpesificationDemo.Bll.Interfaces;
using SpesificationDemo.Bll.Models.Common;
using SpesificationDemo.Bll.Spesifications.Abstract;
using System.Collections.Generic;
using System.Linq;


namespace SpesificationDemo.Dal
{

    public abstract class Repository<TEntity>: IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> Find(BaseSpecification<TEntity> specification)
        {
                   return _context.Query<TEntity>()
                    .Where(specification.ToExpression());
        }

    }
}
