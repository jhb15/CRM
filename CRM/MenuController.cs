using System;

namespace CRM
{
    enum MenuOption
    {
        Report1 = '1',
        Report2 = '2',
        Report3 = '3',
        Report4 = '4',
        Quit = 'Q'
    }
    
    public class MenuController
    {
        private void PrintMenu()
        {
            Console.WriteLine("\nWelcome to the CRM, here are all the possible actions:\n" +
                              "1. Report all known customers and there vehicles.\n" +
                              "2. Report all customers between the age of 20 and 30.\n" +
                              "3. Report all vehicles registered before the '1st January 2001'.\n" +
                              "4. Report all vehicles with an engine larger than 1100cc.\n" +
                              "Q. Quit CRM.");
        }

        private void PrintMenuErr(MenuOption opt)
        {
            var possibleOptions = string.Join(",", Enum.GetValues(typeof(MenuOption)));
            Console.WriteLine($"\nOption selected not recognised, Got: {(char)opt} Possible Options: {possibleOptions}");
        }
        
        private char GetChar()
        {
            int input = Console.ReadKey().KeyChar;
            try
            {
                return char.ToUpper(Convert.ToChar(input));
            }
            catch (OverflowException e)
            {
                Console.WriteLine("{0} Value read = {1}.", e.Message, input);
                return char.MinValue;
            }
        }

        public void RunProgram(DataStore dataStore)
        {
            MenuOption option;

            do
            {
                PrintMenu();
                option = (MenuOption) GetChar();

                switch (option)
                {
                    case MenuOption.Report1:
                        ReportGenerator.ReportAll(dataStore);
                        break;
                    case MenuOption.Report2:
                        ReportGenerator.ReportCustomersByAge(dataStore, 20, 30);
                        break;
                    case MenuOption.Report3:
                        ReportGenerator.ReportVehiclesRegisteredBefore(dataStore, DateTime.Parse("01/01/2010"));
                        break;
                    case MenuOption.Report4:
                        ReportGenerator.ReportVehiclesByEngineSize(dataStore, 1100);
                        break;
                    case MenuOption.Quit:
                        break;
                    default:
                        PrintMenuErr(option);
                        break;
                }

            } while (option != MenuOption.Quit);
            
            Console.WriteLine("\nCRM Exiting!");
        }
    }
}