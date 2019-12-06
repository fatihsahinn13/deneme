using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FCP.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FCP.WebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index(int? id)
        {
            List<Entities.Concrete.Product> result;
            if (id == null)
                result = _productService.GetAll();
            else
                result = _productService.GetByCategory((int)id);
            return View(result);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _productService.GetByID(id);
            var catlist = _categoryService.GetAll();
            ViewBag.CategoryID = new SelectList(catlist, "ID", "Name");

            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Entities.Concrete.Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Entities.Concrete.Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = _productService.GetByID(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Entities.Concrete.Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Delete(model);
                return RedirectToAction("Index");
            }
            else
                return View(model);
        }
    }
}