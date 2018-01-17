using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GeneralRepository<T> where T:class
    {
        public MyContext db = new MyContext();
        public List<T> GetAll()
        {
            return db.Set<T>().ToList();

        }
        public T Find(Predicate<int> Condition)
        {
            return db.Set<T>().Find(Condition);
        }
        public void Insert(T newRecord)
        {
            db.Set<T>().Add(newRecord);
            db.SaveChanges();
        }
        public void Update(T update)
        {
            db.SaveChanges();
        }
        public void Delete(T trash)
        {
            db.Set<T>().Remove(trash);
            db.SaveChanges();
        }
        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }
    }
}
