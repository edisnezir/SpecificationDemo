using SpesificationDemo.Bll.Models.Common;
using System.Collections.Generic;

namespace SpesificationDemo.Bll.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Request> Requests { get; set; }
    }
}
