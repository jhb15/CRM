using System;
using System.Reflection;
using System.Security.Cryptography;

namespace CRM.Models
{
    public class Vehicle
    {
        private int Id { get; set; } 
        private string Manufacturer { get; set; }
        private string Model { get; set; }
        private string RegistrationNumber { get; set; }
        private DateTime RegistrationDate { get; set; }
        private int EngineSize { get; set; }
        private Customer Owner { get; set; }

        public Vehicle(int id, string manufacturer, string model, string registrationNumber, DateTime registrationDate,
            int engineSize)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            RegistrationNumber = registrationNumber;
            RegistrationDate = registrationDate;
            EngineSize = engineSize;
            Owner = null;
        }

        public void AssignOwner(Customer owner)
        {
            Owner = owner;
        }
        
    }
}