﻿
using DataAccesLayer.Abstract;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntitiyFramework
{
    public class EfIletisimDal:GenericRepository<Iletisim>,IIletisimDal
    {
    }
}
