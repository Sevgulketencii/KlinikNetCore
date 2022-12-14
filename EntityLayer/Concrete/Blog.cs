using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogBaslik { get; set; }
        public string BlogImgUrl { get; set; }
        public string BlogKisaAciklama { get; set; }
        public string BlogAciklama { get; set; }
        public string BlogEtiket { get; set; }
        public DateTime BlogTarih { get; set; }
        public List<Yorum> yorums { get; set; }
    }
}
