using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.Domain;

namespace ProjectCNNWebsite.DAL.Contract
{
   public interface IUnitOfWork : IDisposable
   {
      IRepository<T> Repository<T>() where T : BaseEntity;

      INewscastRepository Newscast { get; }        

      void RollBack();

      int SaveChanges();
   }
}
