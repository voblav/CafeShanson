using Cafe.DomainAbstractions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Entities.Code
{
    [Table("Stewards")]
    public class Steward : DbEntity
    {
        public string FirstLastName { get; set; }

        public virtual Order Order { get; set; }
    }
}
