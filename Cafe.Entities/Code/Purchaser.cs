using Cafe.DomainAbstractions.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafe.Entities.Code
{
    [Table("Purchasers")]
    public class Purchaser : DbEntity
    {
        public string FirstLastName { get; set; }
    }
}
