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



    }
}