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
    }
}
