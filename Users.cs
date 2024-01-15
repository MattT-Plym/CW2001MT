using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2001MicroService
{
    public class User
    {
        public int UserID { get; set; }
        public int ActivityID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string AbtMe { get; set; }
        public int Hgt { get; set; }
        public int Wgt { get; set; }

        
        public Activity Activity { get; set; }
    }
}
