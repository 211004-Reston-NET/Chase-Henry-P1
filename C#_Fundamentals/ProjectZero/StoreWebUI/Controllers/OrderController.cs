using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;
using SBL;
using StoreWebUI.Models;
using Serilog;
using Serilog.Formatting.Json;

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
            try
            {
                return View(_storeBL.GetAllOrders()
                    .Select(ord => new OrderVM(ord))
                    .ToList());
            }
            catch
            {
                return View();
            }
        }

        public ActionResult StoreOrders(int p_id)
        {
            try
            {
                return View(_storeBL.GetAllStoreOrdersById(p_id)
                    .Select(ord => new OrderVM(ord))
                    .ToList());
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CustomerOrders(int p_id)
        {
            try
            {
                return View(_storeBL.GetAllCustomerOrdersById(p_id)
                    .Select(ord => new OrderVM(ord))
                    .ToList());
            }
            catch
            {
                return View();
            }
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

        public IActionResult SortOrder()
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.File(new JsonFormatter(),"Logs/orderlog.json")
                .CreateLogger();
            try
            {
                Log.Information("Sorting Order");
                return View(_storeBL.GetSortOrder()
                    .Select(ord => new OrderVM(ord))
                    .ToList());
            }
            catch
            {
                Log.Fatal("Sorting order Failed");
                return View();
            }
            finally
            {
                Log.CloseAndFlush();
            }
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
