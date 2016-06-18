using AppSecurity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppSecurity.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        // GET: Transactions
        public ActionResult Index()
        {
            using (ApplicationDbContext context = ApplicationDbContext.Create())
            {

            }

            return View();
        }
    }
}