﻿using System;
using System.Linq;
using System.Collections.Generic;
using WCFServer.ServiceReferenceUser;
using WCFServer.ServiceReferencePrenotation;
using WCFServer.ServiceReferenceFilm;
using WCFServer.ServiceReferenceEvent;
using WCFServer.ServiceReferenceHall;
using WCFServer.ServiceReferencePlace;
using Film = WCFServer.ServiceReferenceFilm.Film;
using Event = WCFServer.ServiceReferenceEvent.Event;

namespace WCFServer
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class Service1 : IService1
    {
        private ServiceUserClient serviceUser = new ServiceReferenceUser.ServiceUserClient();
        private ServicePrenotationClient servicePrenotation = new ServiceReferencePrenotation.ServicePrenotationClient();
        private ServiceFilmClient serviceFilm = new ServiceReferenceFilm.ServiceFilmClient();
        private ServiceEventClient serviceEvent = new ServiceReferenceEvent.ServiceEventClient();
        private ServiceHallClient serviceHall = new ServiceReferenceHall.ServiceHallClient();
        private ServicePlaceClient servicePlace = new ServiceReferencePlace.ServicePlaceClient();

        //User Service methods

        public bool Registration(bool isAdmin, string username, string password, string name, string surname) {
            try
            {
                return serviceUser.Registration(isAdmin, username, password, name, surname);
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public bool Login(bool isAdmin, string username, string password) {
            try
            {
                return serviceUser.Login(isAdmin, username, password);
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public bool DeleteUser(string username) {
            try
            {
                return serviceUser.DeleteUser(username);
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public bool EditUser(string oldUsername, string newUsername, string newPassword, string newName, string newSurname) {
            try
            {
                return serviceUser.EditUser(oldUsername, newUsername, newPassword, newName, newSurname);
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;

        }

        public User GetUser(bool isAdmin ,string username) {
            try
            {
                return serviceUser.GetUser(isAdmin, username);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }

        public List<User> GetUsersList() {
            try
            {
                return serviceUser.GetUsersList().ToList();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }

        public List<User> GetSubscribersList()
        {
            try
            {
                return serviceUser.GetSubscribersList().ToList();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }

        public bool CheckStringFK(string value, string valueType) {
            try
            {
                return serviceUser.CheckStringFK(value, valueType);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        //Film Service methods

        public bool AddFilm(string title, int year, string direction, int duration, DateTime releaseDate, string genre) {
            try
            {
                return serviceFilm.AddFilm(title, year, direction, duration, releaseDate, genre);
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public bool DeleteFilm(int filmCode) {
            try
            {
                return serviceFilm.DeleteFilm(filmCode);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public Film GetFilm(int filmCode) {
            try
            {
                return serviceFilm.GetFilm(filmCode);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }

        public List<Film> GetFilmList() {
            try
            {
                return serviceFilm.GetFilmList().ToList();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }

        //Event Service methods

        public bool AddEvent(string usernameAdmin, DateTime dateTime, int filmCode, int hallCode, decimal price) {
            try
            {
                return serviceEvent.AddEvent(usernameAdmin, dateTime, filmCode, hallCode, price);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public bool DeleteEvent(int eventCode) {
            try
            {
                return serviceEvent.DeleteEvent(eventCode);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public List<Event> GetEventsList() {
            try
            {
                return serviceEvent.GetEventsList().ToList();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }

        public List<Show> GetShowsList()
        {
            try
            {
                return serviceEvent.GetShowsList().ToList();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }

        //Prenotation Service methods

        public bool AddPrenotation(DateTime dateTime, string usernameUser, int eventCode, int placeNumber) {
            try
            {
                return servicePrenotation.AddPrenotation(dateTime, usernameUser, eventCode, placeNumber);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public bool DeletePrenotation(int prenotationCode) {
            try
            {
                return servicePrenotation.DeletePrenotation(prenotationCode);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public bool AddSubscription(string username)
        {
            try
            {
                return servicePrenotation.AddSubscription(username);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public bool DeleteSubscription(string username)
        {
            try
            {
                return servicePrenotation.DeleteSubscription(username);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public bool GetSubscription(string username)
        {
            try
            {
                return servicePrenotation.GetSubscription(username);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        public List<Prenotation> GetPrenotationsList()
        {
            try
            {
                return servicePrenotation.GetPrenotationsList().ToList();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }


        public List<Ticket> GetTicketsList(string username) {
            try
            {
                return servicePrenotation.GetTicketsList(username).ToList();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }

        //Hall Service methods

        public List<Hall> GetHallsList() {
            try
            {
                return serviceHall.GetHallsList().ToList();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
        }

        public string DrawHall(int eventCode) {
            try
            {
                return serviceHall.DrawHall(eventCode);
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return "Error!";
        }

        //Place Service methods

        public bool CheckIntFK(string value, string valueType) {
            try
            {
                return servicePlace.CheckIntFK(value, valueType);
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
            
        }

        public List<Place> GetAvailablePlacesList(int eventCode) {
            try
            {
                return servicePlace.GetAvailablePlacesList(eventCode).ToList();
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return null;
            
        }

        public bool CheckPlace(int eventCode, int placeNumber) {
            try {
                return servicePlace.CheckPlace(eventCode, placeNumber);
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Connection Error! Database Server Manager Unreacheable!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            return false;
        }

        //Check connection function

        public bool CheckConnection()
        {
            try  {
                serviceUser.CheckConnection();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}