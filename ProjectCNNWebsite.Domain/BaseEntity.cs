using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNNWebsite.Domain
{
   public class BaseEntity
   {
      [Key]
      public int Id { get; set; }

      public bool IsActive { get; set; }

      public DateTime? TimeOfCreation { get; set; }

      public DateTime? TimeOfModification { get; set; }

   }
}
