using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.Domain;

namespace ProjectCNNWebsite.Contract.ViewModels
{
   public class AdminIndexViewModel
   {
      public News News { get; set; }   

      public List<News> NewsList { get; set; }

      public Category Category { get; set; }

      public List<Category> Categories { get; set; }     
   }
}
