using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _maneger;

        public ProductController(IServiceManager maneger)
        {
            _maneger = maneger;
        }
     

        public IActionResult Index()
        {
            var model = _maneger.ProductService.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get([FromRoute(Name ="id")] int id)
        {
            var model = _maneger.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}