using Microsoft.AspNetCore.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product{
                  Id = 1,
                  Name = "paltaryuyan",
                  Category = "ev eşyası",
                  Description = "Description",
                  Price = 599.99m,
                  DiscountPrice = 99.99m,
                  Color = "white"
                
                
                },
                    new Product{
                  Id = 2,
                  Name = "soyuducu",
                  Category = "ev eşyası",
                  Description = "Description",
                  Price = 1299.99m,
                  DiscountPrice = 399.99m,
                  Color = "black"


                }


            };



            return View(products);
        }


    }
}
