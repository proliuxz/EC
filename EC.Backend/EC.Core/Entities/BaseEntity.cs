using System;
using System.ComponentModel.DataAnnotations;

namespace EC.Core.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
