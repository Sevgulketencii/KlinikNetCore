using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Doktorlar
    {
        [Key]
        public int DoktorId { get; set; }
        public string DoktorAd { get; set; }
        public string DoktorSoyad { get; set; }
        public string DoktorAlan { get; set; }
        public string DoktorTwLink { get; set; }
        public string DoktorFcLink { get; set; }
        public string DoktorİmgUrl { get; set; }
    }
}
