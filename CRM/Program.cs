using System;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            var menContr = new MenuController();
            
            //TODO Load CSV
            menContr.RunProgram();
        }

    }
}