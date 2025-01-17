using MVC_Task1.Interfaces;
using System.Collections.Generic;

namespace MVC_Task1.Entities
{
    public class FastFood : IFoodAndDrink
    {
   
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
