using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceCalculatorPOC.Models
{
    public class CustomizationFeature
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("InteriorElement")]
        [Required]
        public int InteriorElementId { get; set; }
        public InteriorElement InteriorElement { get; set; }

        public List<FeatureField> FeatureFields { get; set; } = new();


    }
}
