using EntityLayer.Concrete;
using KlinikNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _user;
        private readonly SignInManager<AppUser> _sign;

        public LoginController(UserManager<AppUser> user, SignInManager<AppUser> sign)
        {
            _user = user;
            _sign = sign;
        }

        public IActionResult KayitOl()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> KayitOl(Kullanici yeni)
        {
            AppUser kisi = new AppUser()
            {
                Adi = yeni.KullaniciAd,
                Soyadi=yeni.KullaniciSoyad,
                Email=yeni.KullaniciMail,
                UserName=yeni.UserName
            };
            if (yeni.Sifre == yeni.Sifre2)
            {
                var result = await _user.CreateAsync(kisi, yeni.Sifre);
                if (result.Succeeded)
                {
                    return RedirectToAction("Giris", "Login");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Giris(UserSign oturum)
        {
            var result = await _sign.PasswordSignInAsync(oturum.username, oturum.password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Admin", "Admin",new { area="Admin" });
            }
            return View();
        }
    }
}
