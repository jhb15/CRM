using System.Data;
using CRM.Models;

namespace CRM
{
    public class DataStore
    {
        private Customer[] _customers;
        private Vehicle[] _vehicles;

        public DataStore(string csvFile)
        {
            
        }

        public DataStore(Customer[] customers, Vehicle[] vehicles)
        {
            _customers = customers;
            _vehicles = vehicles;
        }

        private void InitFromCsv(string csvFile)
        {
            var csvData = GetDataTabletFromCSVFile(csvFile);
        }

        private DataTable GetDataTabletFromCSVFile(string file_path)
        {
            var csvData = new DataTable();
            //TODO Implement
            return csvData;
        }
    }
}