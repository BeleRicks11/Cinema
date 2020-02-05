﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using WCFServer.ServiceReferenceUser;
using WCFServer.ServiceReferencePrenotation;
using WCFServer.ServiceReferenceFilm;
using WCFServer.ServiceReferenceEvent;
using WCFServer.ServiceReferenceHall;
using WCFServer.ServiceReferencePlace;
using System.Configuration;

namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                ServiceHost svcHost = new ServiceHost(typeof(Service1));
                
                svcHost.Open();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine(ConfigurationManager.AppSettings["logo"]);
                
                Console.WriteLine("Servizio WCF Server online, premere un tasto per interrompere...");
                Console.ReadLine();
                svcHost.Close();
                Console.WriteLine("Servizio WCF Server interrotto");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex.ToString());
            }
        }
    }
}