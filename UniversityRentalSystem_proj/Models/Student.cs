using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRentalSystem_proj.Models
{
    public class Student : User
    {
        public override int Renal_Limit => 2;
        public Student(int id, string first_Name, string last_Name) : base(id, first_Name, last_Name, 2){}
    }
}
