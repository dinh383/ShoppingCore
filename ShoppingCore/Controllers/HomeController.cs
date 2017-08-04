using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCore.Data.IRepositories;
using ShoppingCore.Infrastructure.Interfaces;

namespace ShoppingCore.Controllers
{
    public class HomeController : Controller
    {
        ICategoryRepository _categoryRepository;
        IUnitOfWork _unitOfWork;
        public HomeController(ICategoryRepository categoryRepository ,IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var model = _categoryRepository.FindAll().ToList();
            return View(model);
        }
    }
}