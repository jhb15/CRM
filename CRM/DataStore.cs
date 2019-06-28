using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using CRM.Models;
using CsvHelper;

namespace CRM
{
    public class DataStore
    {
        private List<Customer> _customers;
        private List<Vehicle> _vehicles;

        public DataStore(string csvFile)
        {
            _customers = new List<Customer>();
            _vehicles = new List<Vehicle>();
            InitFromCsv(csvFile);
        }

        public DataStore(List<Customer> customers, List<Vehicle> vehicles)
        {
            _customers = customers;
            _vehicles = vehicles;
        }

        
        private void InitFromCsv(string csvFile)
        {
            try
            {
                using (var reader = new StreamReader(csvFile))
                using (var csvReader = new CsvReader(reader))
                {
                    csvReader.Read();
                    csvReader.ReadHeader();
                    while (csvReader.Read())
                    {
                        var customer = new Customer();
                        customer.CustomerId = csvReader.GetField<int>("CustomerId");
                        customer.Forename = csvReader.GetField("Forename");
                        customer.Surname = csvReader.GetField("Surname");
                        customer.DateOfBirth = csvReader.GetField<DateTime>("DateOfBirth");
                        
                        if (_customers.All(c => c.CustomerId != customer.CustomerId))
                        {
                            _customers.Add(customer);
                        }

                        var vehicleType = csvReader.GetField("VehicleType");

                        switch (vehicleType)
                        {
                            case "Car":
                                var car = new Car();
                                BuildVehicle(car, csvReader);
                                car.InteriorColour = csvReader.GetField("InteriorColour");
                                _vehicles.Add(car);
                                break;
                            case "Motorcycle":
                                var motorcycle = new Motorcycle();
                                BuildVehicle(motorcycle, csvReader);
                                motorcycle.HasHelmetStorage = BoolFromStr(csvReader.GetField("HasHelmetStorage"));
                                _vehicles.Add(motorcycle);
                                break;
                            default:
                                Console.WriteLine("Vehicle Not Recognised!");
                                break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void BuildVehicle(Vehicle vehicle, CsvReader csvReader)
        {
            vehicle.VehicleId = csvReader.GetField<int>("VehicleId");
            vehicle.Manufacturer = csvReader.GetField("Manufacturer");
            vehicle.Model = csvReader.GetField("Model");
            vehicle.RegistrationNumber = csvReader.GetField("RegistrationNumber");
            vehicle.RegistationDate = csvReader.GetField<DateTime>("RegistationDate");
            vehicle.EngineSize = csvReader.GetField<int>("EngineSize");
            vehicle.RegistrationNumber = csvReader.GetField("RegistrationNumber");
            vehicle.CustomerId = csvReader.GetField<int>("CustomerId");
        }

        private bool BoolFromStr(string input)
        {
            if (input.ToUpper() == "YES") return true;
            if (input.ToUpper() == "NO") return false;
            
            throw new DataException("Error CSV Bool Value not Yes or No!");
        }

        public void DisplayData()
        {
            //TODO Implement Displaying all Data
            Console.WriteLine("#### Customers #########################");
            foreach (var customer in _customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("#### Vehicles ##########################");
            foreach (var vehicle in _vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}