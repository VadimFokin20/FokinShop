using FokinShop.Web.Models;
using FokinShop.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FokinShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShopViewModelService _shopViewModelService;

        public HomeController(ILogger<HomeController> logger,
                              IShopViewModelService shopViewModelService)
        {
            _logger = logger;
            _shopViewModelService = shopViewModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public async Task<IActionResult> Shop(int? page, int? brand, int? type, int? size)
        {
            var svm = await _shopViewModelService.GetShopViewModel(page ?? 1, brand, type, size);

            return View(svm);
        }

        [ActionName("shop-single")]
        public IActionResult Product()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
