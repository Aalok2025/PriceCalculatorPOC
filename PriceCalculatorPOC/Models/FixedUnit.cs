using System.ComponentModel.DataAnnotations;

namespace PriceCalculatorPOC.Models
{
    public class FixedUnit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public List<FixedUnitField> FixedUnitFields { get; set; } = new();

    }
}
