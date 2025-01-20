using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Entities;
using System.Collections.Generic;
using System.Linq;

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


        //root param
        public IActionResult Index1(int id = -1)
        {
            if (id == -1)
                return View(myFastFoodList);

            else
            {
                var data = myFastFoodList.FirstOrDefault(x => x.Id == id);
                return View(data);
            }
        }

        //root param
        public IActionResult Index2(int price = 0)
        {
            if (price == 0)
                return View(myFastFoodList);

            else
            {
                var data = myFastFoodList.FirstOrDefault(x => x.Price == price);
                return View(data);
            }
        }


        // query param
        public IActionResult Index3(string str, int id = -1)
        {
            if (id == -1)
            {
                var data = myFastFoodList.FirstOrDefault(x => x.Name.Contains(str));
                return View(data);
            }

            else
            {
                var data = myFastFoodList.FirstOrDefault(x => x.Id == id || x.Name.Contains(str));
                return View(data);
            }
        }


        //query param
        public IActionResult Index4(string str, int price = 0)
        {
            if (price == 0)
            {
                var data = myFastFoodList.FirstOrDefault(x => x.Name.Contains(str));
                return View(data);
            }

            else
            {
                var data = myFastFoodList.FirstOrDefault(x => x.Price == price || x.Name.Contains(str));
                return View(data);
            }
        }
    }
}
