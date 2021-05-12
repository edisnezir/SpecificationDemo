using SpesificationDemo.Bll.Models;
using SpesificationDemo.Bll.Models.Enums;
using SpesificationDemo.Bll.Spesifications.Abstract;
using System;
using System.Linq.Expressions;


namespace SpesificationDemo.Bll.Spesifications.Concrete.Requests
{
    public class TimeOutRequestSpesification : BaseSpecification<Request>
    {
        // Random rules
        public override Expression<Func<Request, bool>> ToExpression()
        {
            return request => request.RequestStatus != RequestStatus.Rejected
                            && (DateTime.Now - request.CreatedAt).TotalDays > 29;
        }
    }

}
