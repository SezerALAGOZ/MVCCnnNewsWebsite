using System.Linq;
using System.Web.Mvc;
using ProjectCNNWebsite.Contract.ViewModels;
using ProjectCNNWebsite.Data;

namespace ProjectCNNWebsite.UI.Controllers
{
   public class LifeNewsController : Controller
   {
      // GET: LifeNews
      public ActionResult Index()
      {
         ViewBag.Title = "Yaşamdan Haberler";
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