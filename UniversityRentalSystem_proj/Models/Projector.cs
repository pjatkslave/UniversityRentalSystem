using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRentalSystem_proj.Models
{
    public class Projector : Equipment
    {
        public string  Resolution { get; set; }
        public int WorkHours { get; set; }

        public Projector(int id, string name, string resolution, int workHours) : base(id, name)
        {
            Resolution = resolution;
            WorkHours = workHours;
        }
        public override string GetInfo()
        {
            return $"Projector: {Name}, Resolution: {Resolution}, Lamp Hours: {WorkHours}, Available: {IsAvailable}";
        }
    }
}
