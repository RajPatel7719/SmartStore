﻿using Smart_Store.Entities;
using Smart_Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart_Store.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = productsService.GetProducts();

            if (string.IsNullOrEmpty(search) == false)
            {
                products = products.Where(P => P.Name != null && P.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            
            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsService.SaveProduct(product);


            return RedirectToAction("ProductTable");
        }
    }
}