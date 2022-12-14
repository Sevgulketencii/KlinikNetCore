using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Randevu
    {
        [Key]
        public int RandevuId { get; set; }
        public string RandevuAd{ get; set; }
        public string RandevuSoyad{ get; set; }
        public string RandevuMail { get; set; }
        public DateTime RandevuTarih{ get; set; }
        public string RandevuTel { get; set; }
        public string RandevuDepartman { get; set; }
        public string RandevuAciklama { get; set; }

    }
}
