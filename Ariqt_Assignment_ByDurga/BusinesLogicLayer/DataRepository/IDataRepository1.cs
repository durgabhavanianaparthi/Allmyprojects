﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogicLayer.DataRepository
{
    public  interface IDataRepository1<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);

        public  void Add(TEntity entity); 
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);

      
    }
}
