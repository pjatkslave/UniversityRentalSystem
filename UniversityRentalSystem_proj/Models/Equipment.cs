using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRentalSystem_proj.Models
{
    public abstract class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; } = true;
        protected Equipment(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract string GetInfo();
    }
}
