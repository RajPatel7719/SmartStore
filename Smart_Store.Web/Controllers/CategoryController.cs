using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smart_Store.Entities;
using Smart_Store.Services;

namespace Smart_Store.Web.Controllers
{
    public class CategoryController : Controller
    {

        CategoriesService CategoryService = new CategoriesService();

        [HttpGet]
        public ActionResult Index()
        {
            var categories = CategoryService.GetCategories();

            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            CategoryService.SaveCategory(category);


            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int  ID)
        {
            var category = CategoryService.GetCategoy(ID);

            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            CategoryService.UpdateCategory(category);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = CategoryService.GetCategoy(ID);

            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            
            CategoryService.DeleteCategory(category.ID);

            return RedirectToAction("Index");
        }
    }
}