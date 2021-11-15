﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SBL;
using StoreWebUI.Models;
using StoreDL;

namespace StoreWebUI.Controllers
{
    public class LineItemController : Controller
    {
        private IStoreBL _storeBL;
        private RRProject0Context _context;
        public LineItemController(IStoreBL p_storeBL, RRProject0Context p_context)
        {
            _context = p_context;
            _storeBL = p_storeBL;
        }

        // GET: HomeController1
        public ActionResult Index()
        {
            return View(_storeBL.GetAllLineItems()
                .Select(li => new LineItemVM(li))
                .ToList());
        }

        public ActionResult AddInventory(int p_id)
        {

            _storeBL.AddInvent(p_id);
            return RedirectToAction(nameof(Index));

            //return View(_storeBL.AddInvent(p_id));
            //return View(_storeBL.AddInventory(p_id)
            //    .Select(li => new LineItemVM(li))
            //    .ToList());
        }

        public ActionResult ReplenishInventory(int p_id)
        {
            return View(_storeBL.GetAllLineItemsById(p_id)
                .Select(li => new LineItemVM(li))
                .ToList());
        }

        // GET: LineItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LineItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineItemController/Create
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

        // GET: LineItemController/Edit/5
        public ActionResult Edit(int p_id)
        {
            return View(_storeBL.GetLineItemById(p_id));
        }

        // POST: LineItemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int p_id, IFormCollection collection)
        {
            try
            {
                var inventory = _storeBL.GetLineItemById(p_id);
                inventory.Quantity = int.Parse(collection["Quantity"]);
                _context.Update(inventory);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(_storeBL.GetLineItemById(p_id));
            }
        }

        // GET: LineItemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LineItemController/Delete/5
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
