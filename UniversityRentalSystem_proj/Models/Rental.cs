using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRentalSystem_proj.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public User Renter { get; set; }
        public Equipment RentedEquipment { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal Penalty { get; set; }
        public Rental(int id, User renter, Equipment rentedEquipment, int rentalDays)
        {
            Id = id;
            Renter = renter;
            RentedEquipment = rentedEquipment;
            ReturnDate = RentalDate.AddDays(rentalDays);
        }
    }
}
