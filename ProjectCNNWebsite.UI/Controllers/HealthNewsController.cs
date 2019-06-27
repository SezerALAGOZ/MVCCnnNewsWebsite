using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectCNNWebsite.Contract.ViewModels;
using ProjectCNNWebsite.Data;

namespace ProjectCNNWebsite.UI.Controllers
{
    public class HealthNewsController : Controller
    {
      // GET: HealthNews
      public ActionResult Index()
      {
         ViewBag.Title = "Sağlık Haberleri";
         using (var databaseContext = new DatabaseContext())
         {
            var model = new NewsViewModel
            {
               NewsList = databaseContext.News.ToList(),
               Categories = databaseContext.Category.ToList()
            };
            return View(model);
         }
      }
   }
}