using System;

namespace CRM.Models
{
    public class Motorcycle: Vehicle
    {
        public bool HasHelmetStorage { get; set; }

        public Motorcycle(int id, string manufacturer, string model, string registrationNumber,
            DateTime registrationDate,
            int engineSize, bool hasHelmetStorage) : base(id, manufacturer, model, registrationNumber, registrationDate,
            engineSize)
        {
            
        }
    }
}