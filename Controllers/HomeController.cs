using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPTermProject.Business_Objects;
using ASPTermProject.Models;
using ASPTermProject.Repositories;
using ASPTermProject.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace ASPTermProject.Controllers
{
    public class HomeController : Controller
    {
        private IDogRepository DogRepo;
        private Utils util;
        public HomeController(IDogRepository dogRepo)
        {
            DogRepo = dogRepo;
            util = new Utils();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DogSearch(DogModel model)
        {
            List<Dog> dogs;
            if (model.Sex == "Both")
            {
                dogs = DogRepo.GetAllDogsByType(model.DogType);
            }
            else
            {
                dogs = DogRepo.GetAllDogsBySex(model.DogType, model.Sex);
            }
            List<DogModel> dogModels = util.ConvertToModel(dogs);
            return View(dogModels);
        }
        [HttpPost]
        public IActionResult BreederSearch(DogModel model)
        {
            return View();
        }
    }
}