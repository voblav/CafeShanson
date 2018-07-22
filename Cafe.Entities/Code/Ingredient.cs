using Cafe.DomainAbstractions.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafe.Entities.Code
{
    [Table("Ingredients")]
    public class Ingredient : DbEntity
    {
        public string Name { get; set; }
        public decimal Costprice { get; set; }
        public string Units { get; set; }
        public List<Supple> Supplies { get; set; }
    }
}
