using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SBL;
using StoreWebUI.Models;

namespace StoreWebUI.Controllers
{
    public class StoreFrontController : Controller
    {
        private IStoreBL _storeBL;
        public StoreFrontController(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        // GET: HomeController1
        public ActionResult Index()
        {
            return View(_storeBL.GetAllStoreFronts()
                .Select(store => new StoreFrontVM(store))
                .ToList());
        }

        // GET: StoreFrontController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreFrontController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreFrontController/Create
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

        // GET: StoreFrontController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreFrontController/Edit/5
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

        // GET: StoreFrontController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreFrontController/Delete/5
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
