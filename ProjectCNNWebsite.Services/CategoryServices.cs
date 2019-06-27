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
   public class CategoryServices
   {
      private DatabaseContext database;

      public CategoryServices()
      {
         database = new DatabaseContext();
      }

      public void AddCategory(Category category)
      {
         if (category == null)
            throw new ArgumentNullException(nameof(Category));
         database.Category.Add(category);
      }

      public void EditCategory(Category category)
      {
         if (category == null)
            throw new NullReferenceException(nameof(Category));
         database.Entry(category).State = System.Data.Entity.EntityState.Modified;
      }

      public void DeleteCategory(int id)
      {
         if (id <= 0)
            throw new NullReferenceException("Id boş olamaz");
         var category = GetCategory(id);
         database.Category.Remove(category);
      }

      public List<Category> GetCategoryAll()
      {
         var categoryList = database.Category.ToList();
         return categoryList;
      }

      public Category GetCategory(int id)
      {
         if (id <= 0)
            throw new System.NullReferenceException("id boş olamaz");
         var category = database.Category.FirstOrDefault(i => i.Id == id);
         return category;
      }
      public int SaveDb()
      {
         return ContextManagement.Save();
      }
   }
}
