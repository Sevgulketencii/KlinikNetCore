using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Anasayfa
    {
        [Key]
        public int AnasayfaId { get; set; }
        public string AnasayfaBaslik{ get; set; }
        public string AnasayfaAciklama{ get; set; }
        public string AnasayfaDetails1{ get; set; }
        public string AnasayfaDetails2{ get; set; }
        public string AnasayfaDetails3{ get; set; }
        
    }
}
