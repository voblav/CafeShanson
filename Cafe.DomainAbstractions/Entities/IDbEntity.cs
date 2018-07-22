using System;
using System.ComponentModel.DataAnnotations;

namespace Cafe.DomainAbstractions.Entities
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
