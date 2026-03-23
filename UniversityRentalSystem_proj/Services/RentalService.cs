using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityRentalSystem_proj.Models;

namespace UniversityRentalSystem.Services
{
    public class RentalService
    {
        private readonly List<Equipment> _equipmentList = new List<Equipment>();
        private readonly List<User> _users = new List<User>();
        private readonly List<Rental> _rentals = new List<Rental>();
        private const decimal DailyPenaltyRate = 100m;
        public void AddUser(User user) => _users.Add(user);

        public void AddEquipment(Equipment item) => _equipmentList.Add(item);

        public List<Equipment> GetAllEquipment() => _equipmentList;

        public List<Equipment> GetAvailableEquipment() => _equipmentList.Where(e => e.IsAvailable).ToList();

        public void Rent(int userId, int equipmentId, int days)
        {
            User selectedUser = null;
            foreach (User u in _users)
            {
                if (u.Id == userId) { selectedUser = u; break; }
            }
            if (selectedUser == null) throw new Exception("User not found");

            Equipment selectedEquip = null;
            foreach (Equipment e in _equipmentList)
            {
                if (e.Id == equipmentId) { selectedEquip = e; break; }
            }
            if (selectedEquip == null) throw new Exception("Equipment not found");

            if (selectedEquip.IsAvailable == false) throw new Exception("Equipment unavailable");

            int activeCount = 0;
            foreach (Rental r in _rentals)
            {
                if (r.Renter.Id == userId && r.ReturnDate == null)
                {
                    activeCount++;
                }
            }

            if (activeCount >= selectedUser.Renal_Limit) throw new Exception("Limit exceeded");

            int newId = _rentals.Count + 1;
            Rental newRental = new Rental(newId, selectedUser, selectedEquip, days);
            _rentals.Add(newRental);

            selectedEquip.IsAvailable = false;
        }
        public decimal Return(int equipmentId)
        {
            Rental activeRental = null;
            foreach (Rental r in _rentals)
            {
                if (r.RentedEquipment.Id == equipmentId && r.ReturnDate == null)
                {
                    activeRental = r;
                    break;
                }
            }

            if (activeRental == null) throw new Exception("Active rental not found");

            activeRental.ReturnDate = DateTime.Now;
            activeRental.RentedEquipment.IsAvailable = true;

            if (activeRental.ReturnDate > activeRental.ReturnDate)
            {
                TimeSpan diff = activeRental.ReturnDate.Value - activeRental.RentalDate;
                int delayDays = diff.Days;
                activeRental.Penalty = delayDays * DailyPenaltyRate;
            }

            return activeRental.Penalty;
        }
        public void SetUnavailable(int id)
        {
            foreach (Equipment e in _equipmentList)
            {
                if (e.Id == id)
                {
                    e.IsAvailable = false;
                    break;
                }
            }
        }
    }
}
