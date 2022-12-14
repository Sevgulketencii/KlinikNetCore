using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkinda
    {
        [Key]
        public int HakkindaId { get; set; }
        public string HakkindaBaslik { get; set; }
        public string HakkindaAciklama{ get; set; }
        public bool Statu { get; set; }

    }
}
