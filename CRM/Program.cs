using System;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            var menContr = new MenuController();
            
            var dataStore = new DataStore("res/CustomerInformation.csv"); //Loads Data From CSV
            dataStore.DisplayData();
            
            menContr.RunProgram(dataStore);
        }

    }
}