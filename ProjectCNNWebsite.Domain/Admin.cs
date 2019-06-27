using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNNWebsite.Domain
{
   public class Admin : BaseEntity
   {      
      public string AdminFirstName { get; set; }

      public string AdminLastName { get; set; }

      public DateTime? AdminDateOfBirth { get; set; }

      public string AdminEmailAddress { get; set; }   

      public string AdminNickName { get; set; }

      public string AdminPassword { get; set; }
   }
}
