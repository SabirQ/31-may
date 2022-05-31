using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "HomePage";
            return view;
        }
        public ViewResult About()
        {
            return new ViewResult { ViewName = "About" };
        }
        public ActionResult shop()
        {

            return View();
        }
    }
}
