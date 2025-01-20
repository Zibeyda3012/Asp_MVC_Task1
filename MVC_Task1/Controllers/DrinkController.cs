using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Entities;
using System.Collections.Generic;
using System.Linq;

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

        //root param
        public IActionResult Index1(int id = -1)
        {
           if(id==-1)
                return View(myDrinkList);

           else
            {
                var data = myDrinkList.FirstOrDefault(x => x.Id == id); 
                return View(data);
            }
        }

        //root param
        public IActionResult Index2(int price = 0)
        {
            if (price == 0)
                return View(myDrinkList);

            else
            {
                var data = myDrinkList.FirstOrDefault(x => x.Price == price);
                return View(data);
            }
        }


        // query param
        public IActionResult Index3(string str,int id = -1)
        {
            if(id ==-1)
            {
                var data = myDrinkList.FirstOrDefault(x => x.Name.Contains(str));
                return View(data);  
            }

            else
            {
                var data = myDrinkList.FirstOrDefault(x => x.Id==id || x.Name.Contains(str));
                return View(data);
            }
        }


        //query param
        public IActionResult Index4(string str, int price = 0)
        {
            if (price == 0)
            {
                var data = myDrinkList.FirstOrDefault(x => x.Name.Contains(str));
                return View(data);
            }

            else
            {
                var data = myDrinkList.FirstOrDefault(x => x.Price == price || x.Name.Contains(str));
                return View(data);
            }
        }
    }
}
