

namespace PriceCalculatorPOC.Models
{
    public class PriceCalculatorViewModel
    {

        public List<Room> Rooms { get;  set; }
        public List<InteriorElement> InteriorElements { get;  set; }
        public List<CustomizationFeature> CustomizationFeatures { get;  set; }
        public List<FeatureField> FeatureFields { get;  set; }
        public List<FixedUnit> FixedUnits { get;  set; }
        public List<FixedUnitField> FixedUnitFields { get;  set; }
    }
}
