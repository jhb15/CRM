using System;

namespace CRM
{
    class Program
    {
        private static string _dataSrcFilePath = "res/CustomerInformation.csv";

        private static void TryToGetFilepath()
        {
            try
            {
                var filePath = System.Environment.GetEnvironmentVariable("CRM_DATA_SRC_FILEPATH");
                if (filePath != null) _dataSrcFilePath = filePath;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        static void Main(string[] args)
        {
            var menContr = new MenuController();
            
            TryToGetFilepath(); //Tries to retrieve an environment var specified filepath.
            
            var dataStore = new DataStore(_dataSrcFilePath); //Loads Data From CSV
            dataStore.DisplayData();
            
            menContr.RunProgram(dataStore);
        }

    }
}