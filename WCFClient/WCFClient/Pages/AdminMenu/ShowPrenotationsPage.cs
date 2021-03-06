﻿using EasyConsole;
using System;
using System.Collections.Generic;
using WCFClient.ServiceReference1;

namespace WCFClient.Pages
{
    class ShowPrenotations : Page
    {
        public ShowPrenotations(Program program)
            : base("Show Prenotations", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Console.BackgroundColor = ConsoleColor.Blue;
            Output.WriteLine(ConsoleColor.White, "--------== {0} ==--------\n", base.Title);
            Console.BackgroundColor = ConsoleColor.Black;

            /*
             * Get data from the Database
             */
            try
            {
                Output.WriteLine("PRENOTATIONS LIST: ");
                TablePrinter.Prenotation(SessionManager.GetServiceClient().GetPrenotationsList());
            }
            catch {
                Console.WriteLine("Error! Retry later!");
            }

            /*
             * Navigate back
             */
            Input.ReadString("Press [Enter] to navigate back");
            Program.NavigateBack();
        }
    }
}