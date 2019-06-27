using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.DAL.Contract;
using ProjectCNNWebsite.Domain;

namespace ProjectCNNWebsite.DAL.Concrete
{
   public class UnitOfWorkRepository : IUnitOfWork
   {
      public INewscastRepository Newscast => throw new NotImplementedException();

      public void Dispose()
      {
         throw new NotImplementedException();
      }

      public IRepository<T> Repository<T>() where T : BaseEntity
      {
         throw new NotImplementedException();
      }

      public void RollBack()
      {
         throw new NotImplementedException();
      }

      public int SaveChanges()
      {
         throw new NotImplementedException();
      }
   }
}
