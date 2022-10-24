using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : iGenericDal<T> where T : class, new()
    {
        public void Delete(T t)
        {
            using var contex = new AgricultureContext();
            contex.Remove(t);
            contex.SaveChanges();   
        }

        public List<T> GetAll()
        {
            using var contex = new AgricultureContext();
            return contex.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            using var contex = new AgricultureContext();
            return contex.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            using var contex = new AgricultureContext();
            contex.Add(t);
            contex.SaveChanges();
        }

        public void Update(T t)
        {
            using var contex = new AgricultureContext();
            contex.Update(t);
            contex.SaveChanges();
        }
    }
}
