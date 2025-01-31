using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class ProductController : Controller
    {
        //context object to the database
        private SportsProContext _context;

        public ProductController(SportsProContext context)
        {
            _context = context;
        }
        //Index method and current home page
        public IActionResult List()
        {
            ProductsList plm = new ProductsList();
            plm.ProductList = _context.Products.ToList<Product>();
            return View(plm);
        }

        // [HttpPost]
        // public IActionResult Edit(int productId)
        // {
        //     Product product = _context.Products.Find(productId)!;
        //     return View("ProductEdit", product);
        // }
        // [HttpGet]
        // public IActionResult ProductEdit(Product product)
        // {
        //     return View(product);
        // }
        public IActionResult Details(int? productId, decimal? price){
            var products = _context.Products.Where(p => p.YearlyPrice >= price);//linq
            ProductsList productsByPrice = new ProductsList();
            productsByPrice.ProductList = (List<Product>)products; 

            return View("List", productsByPrice);
        }



    }
}