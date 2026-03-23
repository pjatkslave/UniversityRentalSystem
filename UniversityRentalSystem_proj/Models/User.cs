using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRentalSystem_proj.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public abstract int Renal_Limit { get; }
    protected User(int id, string first_Name, string last_Name, int renal_Limit)
        {
            Id = id;
            First_Name = first_Name;
            Last_Name = last_Name;
        }
    }
}
