using System;

namespace CRM.Models
{
    public class Car: Vehicle
    {
        private string InteriorColour { get; set; }

        public Car(int id, string manufacturer, string model, string registrationNumber, DateTime registrationDate,
            int engineSize, string interiorColour) : base(id, manufacturer, model, registrationNumber, registrationDate, 
            engineSize)
        {
            InteriorColour = interiorColour;
        }
    }
}