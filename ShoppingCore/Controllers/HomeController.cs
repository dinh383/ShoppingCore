using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCore.Data.IRepositories;

namespace ShoppingCore.Controllers
{
    public class HomeController : Controller
    {
        ICategoryRepository _categoryRepository;
        public HomeController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var model = _categoryRepository.FindAll().ToList();
            return View(model);
        }
    }
}