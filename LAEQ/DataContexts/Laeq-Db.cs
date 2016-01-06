using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LAEQ_DB;

namespace LAEQ.DataContexts
{
    public class Laeq_Db :DbContext
    {
         public Laeq_Db()
        : base  ("DefaultConnection")
        {}

         public DbSet<Machine> Machines { get; set; }
         public DbSet <Customer> Customers { get; set; }
         public DbSet <Transaction> Transactions { get; set; }

    }
}