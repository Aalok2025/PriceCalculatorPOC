using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceCalculatorPOC.Models
{
    public class FeatureField
    {   [Key]
        public int Id{ get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        public decimal Price { get; set; } // Price of the customization feature
        [Required]
        public int Quantity {  get; set; }

        [ForeignKey("CustomizationFeature")]
        public int CustomizationFeatureId { get; set; }
        public CustomizationFeature CustomizationFeature { get; set; }
    }
}
