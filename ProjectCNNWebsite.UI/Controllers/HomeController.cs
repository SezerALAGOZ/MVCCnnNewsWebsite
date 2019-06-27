using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectCNNWebsite.UI.Controllers
{
   public class HomeController : Controller
   {
      // GET: Home
      public ActionResult Index()
      {
         return View();
      }

      [HttpPost]
      [DisplayName("Index")]
      public ActionResult IndexPost()
      {
         return View();
      }
   }
}