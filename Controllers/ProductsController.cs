using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Service _allProducts;
        private readonly IPersonService _allPeople;

        public ProductsController(Service iAllProducts, IPersonService iAllPeople)
        {
            _allProducts = iAllProducts;
            _allPeople = iAllPeople;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с задачами";
            ProductsListViewModel obj = new ProductsListViewModel();
            obj.AllProducts = _allProducts.Products;
            obj.CurrPerson = "все люди";
            return View(obj);
        }
    }
}
