using Microsoft.AspNetCore.Mvc;
using MyWeb.Service;
using ServerCount.Models;
using System.Diagnostics;

namespace ServerCount.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Http 통신을 이용하여 넘겨주는 방식 하지만 백그라운드 방식으로 작업을 진행해야 하기 때문에 주석처리 
        // private readonly IMyService _myService;

        public HomeController(ILogger<HomeController> logger, IMyService myService)
        {
            _logger = logger;

        // 위 내용과 동일
        //   _myService = myService;

        }

        public IActionResult Index()
        {
            // 위 내용과 동일
           // _myService.DoCounting();

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