using Cafe.DomainAbstractions.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cafe.Entities.Code
{
    [Table("Composition")]
    public class Composition : DbEntity
    {
        public decimal Quantity { get; set; }

        public virtual Dish Dish { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }

    }
}
