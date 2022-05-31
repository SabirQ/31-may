using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class DetailsController:Controller
    {
        public ActionResult product(int? Id)
        {
            if (Id==null)
            {
                return NotFound();
            }

            return View();
        }
    }
}
