using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceCalculatorPOC.Models
{
    public class FixedUnitField
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // Foreign Key to FixedUnit
        [ForeignKey("FixedUnit")]
        public int FixedUnitId { get; set; }
        public FixedUnit FixedUnit { get; set; }
    }


}
