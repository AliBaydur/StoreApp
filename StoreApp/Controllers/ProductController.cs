using Entities.Models;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _maneger;

        public ProductController(IServiceManager maneger)
        {
            _maneger = maneger;
        }
     

        public IActionResult Index(ProductRequestParameters p)
        {
            var products = _maneger.ProductService.GetAllProductsWithDetails(p);
            var pagination = new Pagination()
            {
                CurrenPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _maneger.ProductService.GetAllProducts(false).Count()
            };
            return View(new ProductListViewModel()
            {
                Products = products,
                Pagination = pagination
            });
        }

        public IActionResult Get([FromRoute(Name ="id")] int id)
        {
            var model = _maneger.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}