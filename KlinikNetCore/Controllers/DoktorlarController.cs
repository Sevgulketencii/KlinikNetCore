using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.Controllers
{
    public class DoktorlarController : Controller
    {
        [AllowAnonymous]
        public IActionResult Doktorlar()
        {
            return View();
        }
    }
}
