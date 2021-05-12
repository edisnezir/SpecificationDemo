using SpesificationDemo.Bll.Models.Enums;
using System;

namespace SpesificationDemo.Bll.Models.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DataStatus DataStatus{ get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
