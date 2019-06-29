using System;
using System.Reflection;
using System.Security.Cryptography;
using CsvHelper.Configuration;

namespace CRM.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; } 
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime RegistationDate { get; set; }
        public int EngineSize { get; set; }
        public int CustomerId { get; set; }

        public override string ToString()
        {
            return $"VehicleId: {VehicleId}" 
                                 + $", Manufacturer: {Manufacturer}" 
                                 + $", Model: {Model}" 
                                 + $", RegistrationNumber: {RegistrationNumber}" 
                                 + $", RegistationDate: {RegistationDate:d}" 
                                 + $", EngineSize: {EngineSize}" 
                                 + $", CustomerId: {CustomerId}";
        }
    }

    /*public class VehicleMap : ClassMap<Vehicle>
    {
        
    }*/
}