﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDatabaseManager
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "ServiceFilm" nel codice e nel file di configurazione contemporaneamente.
    public class ServiceFilm : IServiceFilm
    {
        public void DoWork()
        {
        }

        public Film makeFilm()
        {
            Film f = new Film(1, "Avatar", 2010, "sd", 122, DateTime.Now, "fantasy");
            return f;
        }
    }
}