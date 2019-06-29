using System;
using System.Collections.Generic;
using System.Linq;
using CRM.Models;

namespace CRM
{
    public static class ReportGenerator
    {
        public static void ReportAll(DataStore ds)
        {
            Console.WriteLine("\n#### All Customers and their Vehicles Report ########################");
            var customers = ds.GetCustomers().OrderBy(c => c.Surname).ThenBy(c => c.Forename);
            var vehicles = ds.GetVehicles().OrderBy(v => v.Manufacturer).ThenBy(v => v.Model);
            PrintCustomers(customers, vehicles);
            Console.WriteLine("\n#### End Report #####################################################");
        }

        public static void ReportCustomersByAge(DataStore ds, int minAge, int maxAge)
        {
            Console.WriteLine($"\n#### All Customers Between {minAge}years and {maxAge}years #####################");
            var customers = ds.GetCustomers().Where(c => c.GetAge() >= minAge).Where(c => c.GetAge() <= maxAge);
            PrintCustomers(customers);
            Console.WriteLine("\n#### End Report #####################################################");
        }

        public static void ReportVehiclesRegisteredBefore(DataStore ds, DateTime beforeDate)
        {
            Console.WriteLine($"\n#### All Vehicles Registered Before {beforeDate:d} #####################");
            var vehicles = ds.GetVehicles().Where(v => v.RegistationDate <= beforeDate);
            PrintVehicles(vehicles);
            Console.WriteLine("\n#### End Report #####################################################");
        }

        public static void ReportVehiclesByEngineSize(DataStore ds, int minSize)
        {
            Console.WriteLine($"\n#### All Vehicles with Engine Larger Than {minSize}cc ###################");
            var vehicles = ds.GetVehicles().Where(v => v.EngineSize >= minSize);
            PrintVehicles(vehicles);
            Console.WriteLine("\n#### End Report #####################################################");
        }

        private static void PrintCustomers(IEnumerable<Customer> customers, IEnumerable<Vehicle> vehicles = null)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
                
                if (vehicles == null) continue;
                
                var cVehicles = vehicles.Where(v => v.CustomerId == customer.CustomerId);

                foreach (var cVehicle in cVehicles)
                {
                    var type = cVehicle.GetType();
                    var preamble = "__Unknown: ";

                    if (type == typeof(Car)) { preamble = "__Car: "; }
                    if (type == typeof(Motorcycle)) { preamble = "__Motorcycle: "; }
                    
                    Console.WriteLine(preamble + cVehicle);
                }
                Console.WriteLine();
            }
        }

        private static void PrintVehicles(IEnumerable<Vehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}