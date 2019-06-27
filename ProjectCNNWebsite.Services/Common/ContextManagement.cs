using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.Data;

namespace ProjectCNNWebsite.Services.Common
{
   public class ContextManagement
   {
      private static DatabaseContext _databaseContext;

      private ContextManagement()
      {

      }

      public static DatabaseContext GetContext()
      {
         if (_databaseContext == null)
            _databaseContext = new DatabaseContext();
         return _databaseContext;       
      }

      public static int Save()
      {
         if (_databaseContext == null)
            throw new ArgumentNullException("Önce Context Oluşturulmalı");
         return _databaseContext.SaveChanges();
      }

      public static void Disposing()
      {
         if (_databaseContext == null)
            throw new ArgumentNullException("Önce Context Oluşturulmalı");
         _databaseContext.Dispose();
         _databaseContext = null;
      }
   }
}
