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
            //TODO 
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

        public void RunProgram()
        {
            MenuOption option;

            do
            {
                PrintMenu();
                option = (MenuOption) GetChar();

                switch (option)
                {
                    case MenuOption.Report1:
                        //TODO Run Report 1
                        Console.WriteLine("\nOption Not Available " + option);
                        break;
                    case MenuOption.Report2:
                        //TODO Run Report 2
                        Console.WriteLine("\nOption Not Available " + option);
                        break;
                    case MenuOption.Report3:
                        //TODO Run Report 3
                        Console.WriteLine("\nOption Not Available " + option);
                        break;
                    case MenuOption.Report4:
                        //TODO Run Report 4
                        Console.WriteLine("\nOption Not Available " + option);
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