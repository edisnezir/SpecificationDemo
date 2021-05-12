using SpesificationDemo.Bll.Models;
using SpesificationDemo.Bll.Models.Enums;
using SpesificationDemo.Bll.Spesifications.Abstract;
using System;
using System.Linq.Expressions;

namespace SpesificationDemo.Bll.Spesifications.Concrete.Requests
{
    public class InActiveRequestSpesification : BaseSpecification<Request>
    {
        // Random rules
        public override Expression<Func<Request, bool>> ToExpression()
        {
            return request => request.ResponsibleUserId != null
                            && request.RequestStatus == RequestStatus.Approved
                            && string.IsNullOrEmpty(request.Result);
        }
    }
}
