using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.Areas.Admin.Controllers
{
    [Area("Yonetim")]
  
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}
