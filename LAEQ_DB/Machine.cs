using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAEQ_DB
{
    public class Machine
    {
        public int MachineID { get; set; }
        public string SerialNumber { get; set; }
        public string MachineNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public System.DateTime Year { get; set; }
        public int Capacity { get; set; }
        public enum Status { 
            Available ,
            InternalUse,
            Rented
        }
        public enum Calibration {
            None , 
            Internal ,
            External
        }
        public System.DateTime CalibrationDate { get ; set;}
        public enum PM {
            Yes,
            No
        }

        public System.DateTime PMDate { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
        
        }
    }
      
    

