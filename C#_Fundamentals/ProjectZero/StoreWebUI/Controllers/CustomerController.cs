using Microsoft.AspNetCore.Http;
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
    public class CustomerController : Controller
    {
        private IStoreBL _storeBL;
        private RRProject0Context _context;
        public CustomerController(IStoreBL p_storeBL, RRProject0Context p_context)
        {
            _context = p_context;
            _storeBL = p_storeBL;
        }

        // GET: HomeController1
        public ActionResult Index()
        {

            return View(_storeBL.GetAllCustomers()
                .Select(cust => new CustomerVM(cust))
                .ToList());
        }
        public ActionResult Delete(int p_id)
        {
            return View(new CustomerVM(_storeBL.GetCustomerById(p_id)));
            //return View();
        }

        public ActionResult Search(string SearchString)
        {
            return View(_context.Customer.Where( x => x.Name == SearchString)
                .Select(cust => new CustomerVM(cust))
                .ToList());
            //return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int CustId, IFormCollection collection)
        {
            try
            {
                Customer toBeDeleted = _storeBL.GetCustomerById(CustId);
                _storeBL.DeleteCustomer(toBeDeleted);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CustomerVM custVM)
        {
            if (ModelState.IsValid)
            {
                _storeBL.AddCustomer(new Customer()
                {
                    Name = custVM.Name,
                    Address = custVM.Address,
                    Email = custVM.Email
                });

                return RedirectToAction(nameof(Index));
            }

            //Will return back to the create view if the user didn't specify the right input
            return View();
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
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
    }
}
