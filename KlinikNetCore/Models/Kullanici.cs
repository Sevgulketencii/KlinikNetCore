using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikNetCore.Models
{
    public class Kullanici
    {
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public string UserName { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciTel { get; set; }
        public string Sifre { get; set; }
        [Compare("Sifre")]
        public string Sifre2 { get; set; }
    }
}
