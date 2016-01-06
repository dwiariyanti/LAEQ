using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAEQ_DB
{
   public class Customer
    {
        public int CustomerID { get; set; }
        public string NamePT { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
      
    }

    
}
