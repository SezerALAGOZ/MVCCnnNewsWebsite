using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.DAL.Contract;
using ProjectCNNWebsite.Domain;

namespace ProjectCNNWebsite.DAL.Concrete
{
   public class Repository<T> : IRepository<T> where T : BaseEntity
   {
      public void Change(T tOld, T tNew)
      {
         throw new NotImplementedException();
      }

      public IEnumerable<T> GetAll()
      {
         throw new NotImplementedException();
      }

      public IEnumerable<T> GetAllActive()
      {
         throw new NotImplementedException();
      }

      public T GetById(object id)
      {
         throw new NotImplementedException();
      }

      public T GetFirst(System.Linq.Expressions.Expression<Func<T, bool>> expression)
      {
         throw new NotImplementedException();
      }

      public T Insert(T t)
      {
         throw new NotImplementedException();
      }

      public IEnumerable<T> InsertRange(IEnumerable<T> tList)
      {
         throw new NotImplementedException();
      }

      public bool IsExists(object id)
      {
         throw new NotImplementedException();
      }

      public T Remove(T t)
      {
         throw new NotImplementedException();
      }

      public IEnumerable<T> RemoveRange(IEnumerable<T> tList)
      {
         throw new NotImplementedException();
      }

      public void SafeDelete(T t)
      {
         throw new NotImplementedException();
      }

      public void Update(T t)
      {
         throw new NotImplementedException();
      }

      public IEnumerable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> expression)
      {
         throw new NotImplementedException();
      }
   }
}
