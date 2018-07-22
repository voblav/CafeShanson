using Cafe.DomainAbstractions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Entities.Code
{
    [Table("Dishes")]
    public class Dish : DbEntity
    {
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Price { get; set; }
        public string Preparation { get; set; }

        public virtual OrderFromMenu OrderFromMenu { get; set; }
        public virtual Composition Composition { get; set; }
    }
}
