﻿using EasyConsole;
using System;

namespace WCFClient.Pages
{
    class DeleteFilm : Page
    {
        public DeleteFilm(Program program)
            : base("Delete Film", program)
        {
        }

        public override void Display()
        {
            base.Display();

            /*
             * Change output encoding to allow special 
             * characters output such as € 
             */
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                if (SessionManager.GetServiceClient().GetFilmList().Count != 0)
                {
                    /*
                     * Show the Admin the Film
                     */
                    Output.WriteLine("FILM LIST: ");
                    TablePrinter.Film(SessionManager.GetServiceClient().GetFilmList());

                    /* 
                     * Delete Film Form
                     * 
                     * Every Primary Key input must be valid.
                     */
                    Output.WriteLine("\n------ DELETE FILM ------- ");
                    string film_code = Input.ReadString("Insert the Code of the Film to delete: ");
                    int filmCode = Controls.CheckIntForeignKey(film_code, "Film");

                    /*
                     * Send data to Database
                     */
                    if (SessionManager.GetServiceClient().DeleteFilm(filmCode))
                        Output.WriteLine("\nFILM CANCELLATION SUCCESS!\n");
                    else Output.WriteLine("\nFILM CANCELLATION FAILED! Retry!\n");

                } else Console.WriteLine("There are no Film in the DataBase!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: {0}", ex.GetType());
                Console.WriteLine("Message: {0}", ex.Message);
            }
            
            /*
             * Navigate back
             */
            Input.ReadString("Press [Enter] to navigate back");
            Program.NavigateBack();
        }
    }
}