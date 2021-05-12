using SpesificationDemo.Bll.Models.Common;
using SpesificationDemo.Bll.Models.Enums;
using System;

namespace SpesificationDemo.Bll.Models
{
    public class Request: BaseEntity
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Result { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public Guid RequesterUserId { get; set; }
        public Guid? ResponsibleUserId { get; set; }


        public User RequesterUser { get; set; }
        public User ResponsibleUser { get; set; }
    }
}
