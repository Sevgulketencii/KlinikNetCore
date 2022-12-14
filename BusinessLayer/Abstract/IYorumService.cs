﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IYorumService:IGenericService<Yorum>
    {
        public List<Yorum> BlogYorum(int id);
    }
}
