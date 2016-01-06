using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAEQ_DB
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int MachineID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int RentalPrice { get; set; }

        public virtual Machine Machine { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
