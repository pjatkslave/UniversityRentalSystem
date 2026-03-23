using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRentalSystem_proj.Models
{
    public class Laptop : Equipment
    {
        public string Laptop_Model {  get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public Laptop(int id, string name, string laptop_Model, string cpu, string ram) : base(id, name)
        {
            Laptop_Model = laptop_Model;
            CPU = cpu;
            RAM = ram;
        }
        public override string GetInfo()
        {
            return $"Laptop: {Name}, Model: {Laptop_Model}, CPU: {CPU}, RAM: {RAM}, Available: {IsAvailable}";
        }
    }
}
