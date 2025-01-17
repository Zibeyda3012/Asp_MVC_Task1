using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Entities;
using System.Collections.Generic;

namespace MVC_Task1.Controllers
{
    public class FastFoodController : Controller
    {
        public List<FastFood> myFastFoodList = new()
        {
            new FastFood { Name = "Burger", Id = 1, Price = 5.99 },
            new FastFood { Name = "Pizza", Id = 2, Price = 8.99 },
            new FastFood { Name = "Fries", Id = 3, Price = 2.49 },
            new FastFood { Name = "Hot Dog", Id = 4, Price = 3.99 },
            new FastFood { Name = "Nuggets", Id = 5, Price = 4.99 }
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
