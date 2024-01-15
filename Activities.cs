using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2001MicroService
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string ActivityName { get; set; }
        public ICollection<User> Users { get; set; }
    }
    
}
