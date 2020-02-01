﻿using EasyConsole;
using System.Collections.Generic;
using WCFClient.ServiceReference1;

namespace WCFClient.Pages
{
    class ShowFilm : Page
    {
        public ShowFilm(Program program)
            : base("Show Film", program)
        {
        }

        public override void Display()
        {
            base.Display();

            /*
             * Get data from the Database
             */
            Output.WriteLine("FILM LIST: ");
            TablePrinter.Film(SessionManager.GetServiceClient().GetFilmList());

            /*
             * Navigate back
             */
            Input.ReadString("Press [Enter] to navigate back");
            Program.NavigateBack();
        }
    }
}