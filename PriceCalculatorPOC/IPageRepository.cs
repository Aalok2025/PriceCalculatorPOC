using PriceCalculatorPOC.Models;

namespace PriceCalculatorPOC
{
    public interface IPageRepository
    {
        public Task<PriceCalculatorViewModel> GetPriceCalculatorViewModel();
    }
}
