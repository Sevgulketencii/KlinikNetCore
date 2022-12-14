using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yorum
    {
        [Key]
        public int YorumId { get; set; }
        public string YorumAdi { get; set; }
        public string YorumSoyadi { get; set; }
        public string YorumMail { get; set; }
        public string YorumMetin { get; set; }
        public int BlogId { get; set; }
        public Blog blog {get; set;}
    }
}
