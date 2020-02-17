using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChocolateShop.entity;
using ChocolateShop.repository;

namespace ChocolateShop.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Index
        ChocolateRepository chocolateRepository;
        public DefaultController()
        {
            chocolateRepository = new ChocolateRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<Chocolate> chocolate = chocolateRepository.GetChocolateDetails();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Chocolate chocolate)
        {
            chocolateRepository.AddChocolate(chocolate);
            TempData["Message"] = "Chocolate added successfully!";
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string Name)
        {
            chocolateRepository.DeleteChocolate(Name);
            TempData["Message"] = "Chocolate deleted suuccessfully";
            return RedirectToAction("Index");
        }
    }
}