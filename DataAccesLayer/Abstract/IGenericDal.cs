using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IGenericDal<Table> where Table:class
    {
        public void Ekle(Table eklenen);
        public void Sil(Table silinen);
        public void Güncelle(Table güncellenen);
        public List<Table> Listele();
        public Table IdGoreListele(int id);
    }
}
