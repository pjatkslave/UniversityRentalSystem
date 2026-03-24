using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityRentalSystem.Services;
using UniversityRentalSystem_proj.Models;

namespace UniversityRentalSystem_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalService service = new RentalService();

            Student student = new Student(1, "Alex", "Pjatkslave");
            Emploee employee = new Emploee(2, "Fishman", "Pjatkslayer");
            service.AddUser(student);
            service.AddUser(employee);

            Laptop laptop = new Laptop(1, "Brrrr", "Lenovo", "Core i67", "67GB");
            Projector projector = new Projector(2, "Mercedes Benz", "67", 2000);
            Camera camera = new Camera(3, "Sony playstatin", "Full", "67K");
            service.AddEquipment(laptop);
            service.AddEquipment(projector);
            service.AddEquipment(camera);

            try
            {
                service.Rent(student.Id, laptop.Id, 5);
                Console.WriteLine("Laptop rented.");
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }

            try
            {
                service.Rent(student.Id, projector.Id, 2);
                Console.WriteLine("Projector rented");

                service.Rent(student.Id, camera.Id, 2);
                Console.WriteLine("Camera rented");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Expected Error: " + ex.Message);
            }

            try
            {
                decimal penalty1 = service.Return(projector.Id);
                Console.WriteLine("Projector returned. Penalty: " + penalty1);
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }

            List<Rental> activeRentals = service.GetUserRentals(student.Id);
            foreach (Rental r in activeRentals)
            {
                if (r.RentedEquipment.Id == laptop.Id)
                {
                    r.DueDate = DateTime.Now.AddDays(-3);
                }
            }

            try
            {
                decimal penalty2 = service.Return(laptop.Id);
                Console.WriteLine("Laptop returned, Penalty: " + penalty2);
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }

            Console.ReadLine();
        }
    }
}