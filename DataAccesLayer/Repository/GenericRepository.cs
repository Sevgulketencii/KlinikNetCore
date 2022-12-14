using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repository
{
    public class GenericRepository<Table> : IGenericDal<Table> where Table : class
    {
        Context dbBaglan = new Context();

        public void Ekle(Table eklenen)
        {
            dbBaglan.Set<Table>().Add(eklenen);
            dbBaglan.SaveChanges();
        }

        public void Güncelle(Table güncellenen)
        {
            dbBaglan.Set<Table>().Update(güncellenen);
            dbBaglan.SaveChanges();
        }

        public Table IdGoreListele(int id)
        {
            return dbBaglan.Set<Table>().Find(id);
        }

        public List<Table> Listele()
        {
            return dbBaglan.Set<Table>().ToList();
        }

        public void Sil(Table silinen)
        {
            dbBaglan.Set<Table>().Remove(silinen);
            dbBaglan.SaveChanges();
        }
    }
}
