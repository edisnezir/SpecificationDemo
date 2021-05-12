using System;
using System.Linq.Expressions;

namespace SpesificationDemo.Bll.Spesifications.Abstract
{
    public abstract class BaseSpecification<T>
    {

        public abstract Expression<Func<T, bool>> ToExpression();


        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }


        public BaseSpecification<T> And(BaseSpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }


        public BaseSpecification<T> Or(BaseSpecification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
    }
}
