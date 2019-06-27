using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNNWebsite.Domain
{
   public class News : BaseEntity
   {
      public string NewsTitle { get; set; }

      public string NewsContent { get; set; }

      public string NewsPhotoPath { get; set; } 

      public int CategoryId { get; set; } 

      public Category NewsCategory { get; set; }   
   }
}
