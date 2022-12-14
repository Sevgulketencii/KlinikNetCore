using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        public string IletisimAdi { get; set; }
        public string IletisimSoyad { get; set; }
        public string IletisimMail { get; set; }
        public string IletisimBaslik{ get; set; }
        public string IletisimAciklama{ get; set; }
    }
}
