using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<Table> where Table:class
    {
        public void ekle(Table eklenen);
        public void sil(Table silinen);
        public void güncelle(Table güncellenen);
        public List<Table> Listele();
        public Table IdyeGoreListele(int id);

    }
}
