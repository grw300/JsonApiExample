using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JsonApiClient.Services;

namespace JsonApiClient.Controllers
{
    public class HomeController : Controller
    {
        IJsonApiService jsonApiService;

        public HomeController(IJsonApiService jsonApiService)
        {
            this.jsonApiService = jsonApiService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await jsonApiService.GetPeople());
        }

        public async Task<IActionResult> PostRandomPerson()
        {
            await jsonApiService.PostPersonAsync();
            return View("Index", await jsonApiService.GetPeople());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
