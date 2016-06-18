using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppSecurity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public void ReadLog(string fileName)
        {
            //var path = @"c:\Users\gzuri\git\demo_webapp_security\AppSecurity\App_Data\" + fileName;
            var path = ControllerContext.HttpContext.Server.MapPath("~/App_Data/") + fileName;
            var lines = System.IO.File.ReadAllText(path);

            Response.Write(lines);
        }
    }
}