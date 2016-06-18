using AppSecurity.Models;
using AppSecurity.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppSecurity.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        ApplicationDbContext context = ApplicationDbContext.Create();

        // GET: Transactions
        public ActionResult Index()
        {
            var user = User.Identity.Name;
            
            var orders = context.Orders.
                Where(x => x.User.UserName == user)
                .ToList();
            

            return View(orders);
        }

        public ActionResult Details(int id)
        {
            var order = context.Orders.First(x => x.OrderId == id);

            return View(order);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Order order)
        {
            var userName = User.Identity.Name;
            var user = context.Users.First(x => x.UserName == userName);

            order.UserId = user.Id;
            order.DateCreated = DateTime.Now;

            context.Orders.Add(order);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}