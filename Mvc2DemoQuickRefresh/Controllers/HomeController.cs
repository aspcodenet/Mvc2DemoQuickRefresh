using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvc2DemoQuickRefresh.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Mvc2DemoQuickRefresh.Data;
using Mvc2DemoQuickRefresh.ViewModels;

namespace Mvc2DemoQuickRefresh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPlayerRepository _playerRepository;

        public HomeController(ILogger<HomeController> logger, IPlayerRepository playerRepository)
        {
            _logger = logger;
            _playerRepository = playerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Players()
        {
            var viewModel = new HomePlayersViewModel();
            viewModel.Items = _playerRepository.GetAll().Select(r => new HomePlayersViewModel.Item
            {
                Jersey = r.JerseyNumber,
                Name = r.Namn
            }).ToList();

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
