using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restauranter.Models;

namespace Restauranter.Controllers
{
    public class HomeController : Controller
    {
        private RContext _context;

        public HomeController(RContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Process")]
        public IActionResult Process(RReview r)
        {
            if (ModelState.IsValid)
            {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("Review");
            }
            return View("Index");

        }

        [HttpGet]
        [Route("Review")]
        public IActionResult Review()
        {
            List<RReview> AllReviews = _context.reviews.OrderBy(RReview => RReview.VisitedDate).ToList();
            AllReviews.Reverse();
            ViewBag.AllReviews = AllReviews;
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
