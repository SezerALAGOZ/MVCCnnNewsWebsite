using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectCNNWebsite.Contract.ViewModels;
using ProjectCNNWebsite.Data;
using ProjectCNNWebsite.Domain;
using ProjectCNNWebsite.Services;

namespace ProjectCNNWebsite.UI.Controllers
{
   public class AdminController : Controller
   {
      // GET: Admin
      public ActionResult Index()
      {
         ViewBag.Title = "Admin Homepage";
         using (DatabaseContext databaseContext = new DatabaseContext())
         {
            var model = new AdminIndexViewModel()
            {
               NewsList = databaseContext.News.ToList(),
               Categories = databaseContext.Category.ToList()
            };
            return View(model);
         }         
      }

      public ActionResult Insert()
      {
         ViewBag.Title = "Insert News";
         return View();
      }

      public ActionResult InsertNews(News news)
      {
         using (var databaseContext = new DatabaseContext())
         {
            databaseContext.News.Add(news);
            databaseContext.SaveChanges();
         }
         return RedirectToAction("Index");
      }

   
      public ActionResult CategoryInsert(Category category)    
      {
         using (var databaseContext = new DatabaseContext())
         {
            databaseContext.Category.Add(category);
            databaseContext.SaveChanges();
         }
         return RedirectToAction("Index");
      }

      public ActionResult Delete()
      {
         ViewBag.Title = "Delete News";
         return View();
      }

      public ActionResult DeleteNews()
      {
         int id = Convert.ToInt32(Request.Form["News.Id"]);
         using (var databaseContext = new DatabaseContext())
         {
            if (id <= 0)
               throw new System.NullReferenceException("id boş olamaz");
            News news = databaseContext.News.FirstOrDefault(i => i.Id == id);
            databaseContext.News.Remove(news);
            databaseContext.SaveChanges();
         }
         return RedirectToAction("Index");
      }

      public ActionResult DeleteCategory()    
      {
         int id = Convert.ToInt32(Request.Form["Category.Id"]);
         using (var databaseContext = new DatabaseContext())
         {
            if (id <= 0)
               throw new System.NullReferenceException("id boş olamaz");
            Category category = databaseContext.Category.FirstOrDefault(i => i.Id == id);
            databaseContext.Category.Remove(category);
            databaseContext.SaveChanges();
         }
         return RedirectToAction("Index");
      }

      public ActionResult SignIn()
      {
         return View();
      }

      public ActionResult CheckIfAdminExists(string adminNickName, string adminPassword)
      {
         var databaseContext = new DatabaseContext();
         var adminList = databaseContext.Admin.ToList();
         Admin admin = new Admin
         {
            AdminNickName = adminNickName,
            AdminPassword = adminPassword
         };
         foreach (var item in adminList)
         {
            if ((item.AdminNickName == admin.AdminNickName) && (item.AdminPassword == admin.AdminPassword))
               return RedirectToAction("Index");
         }
         return View("SignIn");
         
      }

      public ActionResult InsertAdmin(Admin admin)   
      {
         using (var databaseContext = new DatabaseContext())
         {
            databaseContext.Admin.Add(admin);
            databaseContext.SaveChanges();
         }
         return View("SignIn");
      }
   }

}
