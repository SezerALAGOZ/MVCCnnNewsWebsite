using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.Domain;

namespace ProjectCNNWebsite.DAL.Contract
{
   public interface IRepository<T>
      where T:BaseEntity
   {
      T GetById(object id);

      T GetFirst(Expression<Func<T, bool>> expression);

      IEnumerable<T> GetAll();

      IEnumerable<T> GetAllActive();

      IEnumerable<T> Where(Expression<Func<T, bool>> expression);

      T Insert(T t);

      IEnumerable<T> InsertRange(IEnumerable<T> tList);

      T Remove(T t);

      IEnumerable<T> RemoveRange(IEnumerable<T> tList);
      //void RemoveRange(IEnumerable<T> tList);
      //bool RemoveRange(IEnumerable<T> tList);

      void Update(T t);

      void Change(T tOld, T tNew);

      void SafeDelete(T t);

      bool IsExists(object id);
   }
}

