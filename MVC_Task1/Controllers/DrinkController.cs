using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Entities;
using System.Collections.Generic;

namespace MVC_Task1.Controllers
{
    public class DrinkController : Controller
    {
        public List<Drink> myDrinkList = new()
        {
            new Drink { Name = "Coke", Id = 1, Price = 1.99 },
            new Drink { Name = "Pepsi", Id = 2, Price = 1.89 },
            new Drink { Name = "Sprite", Id = 3, Price = 1.79 },
            new Drink { Name = "Lemonade", Id = 4, Price = 2.49 },
            new Drink { Name = "Water", Id = 5, Price = 0.99 }
        };

        public IActionResult Index()
        {
            return View();
        }

        //root param
        public IActionResult Index1(string name)
        {
           
        }


        // query param
        public IActionResult Index2()
        {

        }
    }
}
