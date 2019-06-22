using System;

namespace CRM.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int EngineSize { get; set; }
        public Customer Owner { get; set; }
        
    }
}