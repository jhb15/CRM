using System;
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

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
                var cVehicles = vehicles.Where(v => v.CustomerId == customer.CustomerId);

                foreach (var cVehicle in cVehicles)
                {
                    var type = cVehicle.GetType();
                    var preamble = "";

                    if (type == typeof(Car)) { preamble = "__Car: "; }
                    if (type == typeof(Motorcycle)) { preamble = "__Motorcycle: "; }
                    
                    Console.WriteLine(preamble + cVehicle);
                }
                Console.WriteLine();
            }
            Console.WriteLine("#### End Report #####################################################");
        }

        public static void ReportCustomersByAge(DataStore ds, int minAge, int maxAge)
        {
            Console.WriteLine($"\n#### All Customers Between {minAge}years and {maxAge}years #####################");
            var customers = ds.GetCustomers().Where(c => c.GetAge() >= minAge).Where(c => c.GetAge() <= maxAge);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer + "\n");
            }
            Console.WriteLine("#### End Report #####################################################");
        }

        public static void ReportVehiclesRegisteredBefore(DataStore ds, DateTime beforeDate)
        {
            Console.WriteLine($"\n#### All Vehicles Registered Before {beforeDate:d} #####################");
            var vehicles = ds.GetVehicles().Where(v => v.RegistationDate <= beforeDate);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle + "\n");
            }
            Console.WriteLine("#### End Report #####################################################");
        }

        public static void ReportVehiclesByEngineSize(DataStore ds, int minSize)
        {
            Console.WriteLine($"\n#### All Vehicles with Engine Larger Than {minSize}cc ###################");
            var vehicles = ds.GetVehicles().Where(v => v.EngineSize >= minSize);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle + "\n");
            }
            Console.WriteLine("#### End Report #####################################################");
        }
    }
}