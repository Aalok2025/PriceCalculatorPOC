using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceCalculatorPOC.Models;

namespace PriceCalculatorPOC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPageRepository _pageRepository;

        public HomeController(ILogger<HomeController> logger, IPageRepository pageRepository    )
        {
            _logger = logger;
            _pageRepository = pageRepository;
        }

        public async Task<IActionResult> Index()
        {
            var view_model= _pageRepository.GetPriceCalculatorViewModel();
            PriceCalculatorViewModel viewModel = await view_model;
            return View("~/Views/Pages/Index.cshtml", viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
