using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.Data;
using ProjectCNNWebsite.Domain;

namespace ProjectCNNWebsite.Services
{
   public class NewsManagementWithDb
   {
      private DatabaseContext databaseContext;

      public NewsManagementWithDb()
      {
         databaseContext = new DatabaseContext();
      }

      //public Newscast AddNewscast(Newscast newscast)
      //{
      //   if (newscast == null)
      //      throw new ArgumentNullException(nameof(Newscast));
      //   newscast = databaseContext.Newscast.Add(newscast);
      //   return newscast;
      //}

      public News AddNews(News news)   
      {
         using (DatabaseContext db = new DatabaseContext())
         {
            db.News.Add(news);
            db.SaveChanges();
            return news;
         }
      }

      public int Save()
      {
         return databaseContext.SaveChanges();
      }
   }
}
