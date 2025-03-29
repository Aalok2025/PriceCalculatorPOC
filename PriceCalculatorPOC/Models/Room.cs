using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PriceCalculatorPOC.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<InteriorElement> InteriorElements { get; set; } = new();

    }
}
