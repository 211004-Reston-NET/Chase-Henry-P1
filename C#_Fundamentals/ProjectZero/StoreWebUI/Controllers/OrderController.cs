using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;
using SBL;
using StoreWebUI.Models;

namespace StoreWebUI.Controllers
{
    public class OrderController : Controller
    {
        private IStoreBL _storeBL;
        public OrderController(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        // GET: OrderController
        public ActionResult Index()
        {
            return View(_storeBL.GetAllOrders()
                .Select(ord => new OrderVM(ord))
                .ToList());
        }

        public ActionResult StoreOrders(int p_id)
        {
            return View(_storeBL.GetAllStoreOrdersById(p_id)
                .Select(ord => new OrderVM(ord))
                .ToList());
        }

        public ActionResult CustomerOrders(int p_id)
        {
            return View(_storeBL.GetAllCustomerOrdersById(p_id)
                .Select(ord => new OrderVM(ord))
                .ToList());
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrderVM ordVM)
        {
            if (ModelState.IsValid)
            {
                _storeBL.PlaceOrders(new Orders()
                {
                    CustId = ordVM.CustId,
                    StoreId = ordVM.StoreId,
                    prodId = ordVM.prodId,
                    Total = ordVM.Total
                });

                return RedirectToAction(nameof(Index));
            }

            //Will return back to the create view if the user didn't specify the right input
            return View();
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
