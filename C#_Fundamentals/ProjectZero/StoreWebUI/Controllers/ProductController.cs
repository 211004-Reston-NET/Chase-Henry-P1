﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;
using SBL;
using StoreWebUI.Models;
using StoreDL;

namespace StoreWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IStoreBL _storeBL;
        public ProductController(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        // GET: HomeController1
        public ActionResult Index(int p_id)
        {
            try
            {
                return View(_storeBL.GetAllProductByStoreId(p_id)
                    .Select(store => new QuantityVM(store))
                    .ToList());
            }
            catch
            {
                return View();
            }

        }

        public ActionResult ReplenishInventory(int p_id)
        {
            try
            {
                return View(_storeBL.GetAllLineItemsById(p_id)
                    .Select(li => new LineItemVM(li))
                    .ToList());
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddInventory(int p_id)
        {
            try
            {
                _storeBL.AddInvent(p_id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }

        public ActionResult Replenish()
        {
            return View();
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
