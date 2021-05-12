using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpesificationDemo.Bll.Interfaces;
using SpesificationDemo.Bll.Models;
using SpesificationDemo.Bll.Spesifications.Concrete.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpesificationDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Request
        [HttpGet]
        public ActionResult<IEnumerable<Request>> GetUsers()
        {
            var combined = new InActiveRequestSpesification().Or(new TimeOutRequestSpesification());
            return _unitOfWork.Repository<Request>().Find(combined).ToList();
        }
    }
}
