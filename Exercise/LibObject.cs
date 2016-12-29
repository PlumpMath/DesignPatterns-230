using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
   public abstract class LibObject
   {
       public int ItemId { get; set; }
       public int AvailableAmount { get; set; }
       public abstract LibObject GetRegistrationInfo();

   }
}
