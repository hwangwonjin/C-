using BboardWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BboardWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        [HttpPost]
        public IActionResult Test(string x, string y) 
        {

            ViewData["x"] = x;
            ViewBag.y = y;

            List<TestModel> list = new List<TestModel>();
            list.Add(new TestModel() { X = 1, Y = "a" });
            list.Add(new TestModel() { X = 2, Y = "b" });
            list.Add(new TestModel() { X = 3, Y = "c" });
            list.Add(new TestModel() { X = 4, Y = "d" });

            //ViewData["list"] = list;

			return View(list);

            //return PartialView();    해당 cshtml에 있는 내용만 출력
            //return File("d:weare.xls", "application/ovctet-stream", "one.xls");  시스템내부의 파일을 저장
            //return Content("abcdef", "text/html");    해당 내용의 형식을 지정
            //var model = new TestModel();
            //model.X = 1;
            //model.Y = "y";

            //return Json(model);   



        }


    }
}