using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Entities;
using System.Collections.Generic;

namespace MVC_Task1.Controllers
{
    public class HotMealController : Controller
    {

        public List<HotMeal> myHotMealList = new List<HotMeal>
        {
            new HotMeal { Name = "Spaghetti", Id = 1, Price = 7.99 },
            new HotMeal { Name = "Steak", Id = 2, Price = 12.99 },
            new HotMeal { Name = "Chicken Curry", Id = 3, Price = 9.49 },
            new HotMeal { Name = "Lasagna", Id = 4, Price = 8.99 },
            new HotMeal { Name = "Fried Rice", Id = 5, Price = 6.49 }
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
