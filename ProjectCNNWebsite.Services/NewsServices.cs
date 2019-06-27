using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.Data;
using ProjectCNNWebsite.Domain;
using ProjectCNNWebsite.Services.Common;

namespace ProjectCNNWebsite.Services
{
   public class NewsServices
   {
      private DatabaseContext _databaseContext;

      public NewsServices()
      {
         _databaseContext = new DatabaseContext();
      }

      public void AddNews(News news)
      {
         if (news == null)
            throw new NullReferenceException(nameof(News));
         _databaseContext.News.Add(news);
      }

      public void EditNews(News news)
      { 
         if (news == null)
            throw new NullReferenceException(nameof(News));
         _databaseContext.Entry(news).State = System.Data.Entity.EntityState.Modified;
      }

      public void DeleteNews(int id)
      {
         if (id <= 0)
            throw new NullReferenceException("Id boş olamaz");
         var news = GetNews(id);
         _databaseContext.News.Remove(news);
      }

      public List<News> GetNewsAll()
      {
         var newsList = _databaseContext.News.ToList();
         return newsList;
      }

      public News GetNews(int id)
      {
         if (id <= 0)
            throw new System.NullReferenceException("id boş olamaz");
         var news = _databaseContext.News.FirstOrDefault(i => i.Id == id);
         return news;
      }

      public int SaveDb()
      {
         return ContextManagement.Save();
      }

   }
}
