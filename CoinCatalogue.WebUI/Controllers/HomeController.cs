using CoinCatalogue.WebUI.Models;
using CoinCatalogue.WebUI.Models.Core;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using CoinCatalogue.WebUI.Models.ViewModels;

namespace CoinCatalogue.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public HomeController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            var path = _hostingEnvironment.WebRootPath;
            var viewModel = new HomeViewModel
            {
                Path = path
            };
            using (var db = new CoinCatalogueDbContext())
            {
                //var coin1 = new Coin { Name = "United States quarter", Value = 0.25m, Year = 1965 };
                //var coin2 = new Coin { Name = "British pound", Value = 1.0m, Year = 1983 };
                //var coin3 = new Coin { Name = "Canadian loonie", Value = 1.0m, Year = 1987 };
                //var coin4 = new Coin { Name = "Mexican peso", Value = 1.0m, Year = 1910 };
                //var coin5 = new Coin { Name = "Japanese yen", Value = 100.0m, Year = 2000 };
                //var coin6 = new Coin { Name = "Australian dollar", Value = 1.0m, Year = 1995 };
                //var coin7 = new Coin { Name = "Swiss franc", Value = 5.0m, Year = 2010 };
                //var coin8 = new Coin { Name = "South African rand", Value = 1.0m, Year = 1994 };
                //var coin9 = new Coin { Name = "French franc", Value = 10.0m, Year = 1989 };
                //var coin10 = new Coin { Name = "Chinese yuan", Value = 10.0m, Year = 2015 };
                //db.Coin.Add(coin);
                //db.SaveChanges();
            }
            return View(viewModel);
        }

        public IActionResult Privacy()
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