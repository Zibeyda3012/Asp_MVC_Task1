using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Entities;
using System.Collections.Generic;
using System.Linq;

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


        //root param
        public IActionResult Index1(int id = -1)
        {
            if (id == -1)
                return View(myHotMealList);

            else
            {
                var data = myHotMealList.FirstOrDefault(x => x.Id == id);
                return View(data);
            }
        }

        //root param
        public IActionResult Index2(int price = 0)
        {
            if (price == 0)
                return View(myHotMealList);

            else
            {
                var data = myHotMealList.FirstOrDefault(x => x.Price == price);
                return View(data);
            }
        }


        // query param
        public IActionResult Index3(string str, int id = -1)
        {
            if (id == -1)
            {
                var data = myHotMealList.FirstOrDefault(x => x.Name.Contains(str));
                return View(data);
            }

            else
            {
                var data = myHotMealList.FirstOrDefault(x => x.Id == id || x.Name.Contains(str));
                return View(data);
            }
        }


        //query param
        public IActionResult Index4(string str, int price = 0)
        {
            if (price == 0)
            {
                var data = myHotMealList.FirstOrDefault(x => x.Name.Contains(str));
                return View(data);
            }

            else
            {
                var data = myHotMealList.FirstOrDefault(x => x.Price == price || x.Name.Contains(str));
                return View(data);
            }
        }
    }
}
