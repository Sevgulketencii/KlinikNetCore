using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.Controllers
{
    public class HakkimizdaController : Controller
    {
        [AllowAnonymous]
        public IActionResult Hakkimizda()
        {
            return View();
        }
    }
}
