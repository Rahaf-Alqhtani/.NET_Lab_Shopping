using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        private List<ProductModel> _product = new List<ProductModel>( )
        {


         new ProductModel { id = 1, name = "Book", price = 55.75f,Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZwLjehVb-iRM_D95NHkAgBFuTLRDrEl5EYw&usqp=CAU" },
         new ProductModel { id = 2, name = "Book", price = 52.75f ,Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvC2WyxVQWvTLjQ_37kYGy7jjszxjRtS7M3Q&usqp=CAU" },
         new ProductModel { id = 3, name = "Book", price = 51.75f,Image = "https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8MTZ8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=500&q=60 "},

        };


    public IActionResult Index( string color)
        {

            ViewData["ProductModels"] = _product;
            ViewData["Color"] = color;
      
            return View();
        }
   
        public IActionResult Details(int id, string color = "white")
        {

            var product = _product.Find(model => model.id == id);
            if (product != null)
            {
                ViewData["Product"] = product;
                ViewData["Color"] = color;
                return View("Details");
            }
            else
            {
                return Content(" Sorry,This product not found");
            }
        }
    }
   
}
