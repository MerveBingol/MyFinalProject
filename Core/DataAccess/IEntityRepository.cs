using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Generic Constraint - Generic kısıt
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new (): new'lenebilir olmalı interfaceler(IEntity ) newlenemez
   public  interface IEntityRepository<T>where T: class , IEntity,new() // sadece kendi vt nesnenelerimizin tiplerini kullanmak için
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);// istediğimiz bir şeye göre filtrelemek için // filter =null demek filter vermeyedebilirsin
        T Get(Expression<Func<T, bool>> filter);// detaya gitmek
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        


    }
}
