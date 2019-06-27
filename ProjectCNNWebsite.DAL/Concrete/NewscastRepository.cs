using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.DAL.Contract;
using ProjectCNNWebsite.Domain;

namespace ProjectCNNWebsite.DAL.Concrete
{
   public class NewscastRepository : Repository<News>, INewscastRepository
   {
   }
}
