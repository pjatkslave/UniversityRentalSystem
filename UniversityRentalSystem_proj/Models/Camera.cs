using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRentalSystem_proj.Models
{
    public class Camera : Equipment
    {
        public string Resolution { get; set; }
        public string SensorSize { get; set; }
        public Camera(int id, string name, string resolution, string sensorSize) : base(id, name)
        {
            Resolution = resolution;
            SensorSize = sensorSize;
        }
        public override string GetInfo()
        {
            return $"Camera: {Name}, Resolution: {Resolution}, Sensor Size: {SensorSize}, Available: {IsAvailable}";
        }
    }

}
