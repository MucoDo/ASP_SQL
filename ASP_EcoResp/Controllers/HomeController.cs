using ASP_EcoResp.Models;
using BLL_EcoResp.Entities;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System.Diagnostics;

namespace ASP_EcoResp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProduitRepository<Produit> _produitRepository;

        public HomeController(ILogger<HomeController> logger, IProduitRepository<Produit> produitRepository)
        {
            _logger = logger;
            _produitRepository = produitRepository;
        }

        public IActionResult Index()
        {
            return View();
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