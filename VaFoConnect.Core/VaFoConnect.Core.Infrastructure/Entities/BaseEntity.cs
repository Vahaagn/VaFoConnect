using System;

namespace VaFoConnect.Core.Infrastructure.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}