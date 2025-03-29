using Microsoft.EntityFrameworkCore;
using PriceCalculatorPOC.Models;

namespace PriceCalculatorPOC
{
    public class PageService : IPageRepository
    {
        private readonly ApplicationDbContext _context;
        public PageService(ApplicationDbContext context )
        {
            _context = context;
        }
        public async Task<PriceCalculatorViewModel> GetPriceCalculatorViewModel()
        {
            List<Room> Rooms = await _context.Rooms?.Include(r => r.InteriorElements).ToListAsync() ?? new List<Room>();
            List<InteriorElement> InteriorElements  = await _context.InteriorElements?.Include(e => e.CustomizationFeatures).ToListAsync() ?? new List<InteriorElement>();
            List<CustomizationFeature> CustomizationFeatures= await _context.CustomizationFeatures?.Include(cf => cf.FeatureFields).ToListAsync() ?? new List<CustomizationFeature>();
            List<FeatureField> FeatureFields = await _context.FeatureFields?.ToListAsync() ?? new List<FeatureField>();
            List<FixedUnit> FixedUnits  = await _context.FixedUnits?.Include(fu => fu.FixedUnitFields).ToListAsync() ?? new List<FixedUnit>();
            List<FixedUnitField> FixedUnitFields = await _context.FixedUnitFields?.ToListAsync() ?? new List<FixedUnitField>();

            var viewModel = new PriceCalculatorViewModel
            {
                Rooms = Rooms,
                InteriorElements = InteriorElements,
                CustomizationFeatures = CustomizationFeatures,
                FeatureFields = FeatureFields,
                FixedUnits  = FixedUnits,
                FixedUnitFields = FixedUnitFields
            };
            return viewModel;
        }
    }
}
