﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registration", ReplyAction="http://tempuri.org/IService1/registrationResponse")]
        bool registration(bool isAdmin, string username, string password, string name, string surname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registration", ReplyAction="http://tempuri.org/IService1/registrationResponse")]
        System.Threading.Tasks.Task<bool> registrationAsync(bool isAdmin, string username, string password, string name, string surname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        bool login(bool isAdmin, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        System.Threading.Tasks.Task<bool> loginAsync(bool isAdmin, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addFilm", ReplyAction="http://tempuri.org/IService1/addFilmResponse")]
        bool addFilm(string titolo, int anno, string regia, int durata, System.DateTime datauscita, string genere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addFilm", ReplyAction="http://tempuri.org/IService1/addFilmResponse")]
        System.Threading.Tasks.Task<bool> addFilmAsync(string titolo, int anno, string regia, int durata, System.DateTime datauscita, string genere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancellazioneFilm", ReplyAction="http://tempuri.org/IService1/CancellazioneFilmResponse")]
        string CancellazioneFilm(int codicefilm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancellazioneFilm", ReplyAction="http://tempuri.org/IService1/CancellazioneFilmResponse")]
        System.Threading.Tasks.Task<string> CancellazioneFilmAsync(int codicefilm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InserimentoEvento", ReplyAction="http://tempuri.org/IService1/InserimentoEventoResponse")]
        string InserimentoEvento(string usernameadmin, System.DateTime data_e_ora, int codice_film, int codice_sala, decimal prezzo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InserimentoEvento", ReplyAction="http://tempuri.org/IService1/InserimentoEventoResponse")]
        System.Threading.Tasks.Task<string> InserimentoEventoAsync(string usernameadmin, System.DateTime data_e_ora, int codice_film, int codice_sala, decimal prezzo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancellazioneEvento", ReplyAction="http://tempuri.org/IService1/CancellazioneEventoResponse")]
        string CancellazioneEvento(int codiceevento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancellazioneEvento", ReplyAction="http://tempuri.org/IService1/CancellazioneEventoResponse")]
        System.Threading.Tasks.Task<string> CancellazioneEventoAsync(int codiceevento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Visualizzazione_elenco_film", ReplyAction="http://tempuri.org/IService1/Visualizzazione_elenco_filmResponse")]
        string Visualizzazione_elenco_film();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Visualizzazione_elenco_film", ReplyAction="http://tempuri.org/IService1/Visualizzazione_elenco_filmResponse")]
        System.Threading.Tasks.Task<string> Visualizzazione_elenco_filmAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Visualizzazione_elenco_eventi", ReplyAction="http://tempuri.org/IService1/Visualizzazione_elenco_eventiResponse")]
        string Visualizzazione_elenco_eventi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Visualizzazione_elenco_eventi", ReplyAction="http://tempuri.org/IService1/Visualizzazione_elenco_eventiResponse")]
        System.Threading.Tasks.Task<string> Visualizzazione_elenco_eventiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VisualizzazioneSale", ReplyAction="http://tempuri.org/IService1/VisualizzazioneSaleResponse")]
        string VisualizzazioneSale();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VisualizzazioneSale", ReplyAction="http://tempuri.org/IService1/VisualizzazioneSaleResponse")]
        System.Threading.Tasks.Task<string> VisualizzazioneSaleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ControlloFK", ReplyAction="http://tempuri.org/IService1/ControlloFKResponse")]
        string ControlloFK(int valore, string value_type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ControlloFK", ReplyAction="http://tempuri.org/IService1/ControlloFKResponse")]
        System.Threading.Tasks.Task<string> ControlloFKAsync(int valore, string value_type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Visualizzazione_elenco_UtentiFree", ReplyAction="http://tempuri.org/IService1/Visualizzazione_elenco_UtentiFreeResponse")]
        string Visualizzazione_elenco_UtentiFree();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Visualizzazione_elenco_UtentiFree", ReplyAction="http://tempuri.org/IService1/Visualizzazione_elenco_UtentiFreeResponse")]
        System.Threading.Tasks.Task<string> Visualizzazione_elenco_UtentiFreeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Visualizzazione_elenco_Prenotazioni", ReplyAction="http://tempuri.org/IService1/Visualizzazione_elenco_PrenotazioniResponse")]
        string Visualizzazione_elenco_Prenotazioni(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Visualizzazione_elenco_Prenotazioni", ReplyAction="http://tempuri.org/IService1/Visualizzazione_elenco_PrenotazioniResponse")]
        System.Threading.Tasks.Task<string> Visualizzazione_elenco_PrenotazioniAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VisualizzazionePostiDisponibili", ReplyAction="http://tempuri.org/IService1/VisualizzazionePostiDisponibiliResponse")]
        string VisualizzazionePostiDisponibili(int codice_evento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VisualizzazionePostiDisponibili", ReplyAction="http://tempuri.org/IService1/VisualizzazionePostiDisponibiliResponse")]
        System.Threading.Tasks.Task<string> VisualizzazionePostiDisponibiliAsync(int codice_evento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InserimentoPrenotazione", ReplyAction="http://tempuri.org/IService1/InserimentoPrenotazioneResponse")]
        string InserimentoPrenotazione(System.DateTime dataora, string username_utentefree, int codice_evento, int numero_posto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InserimentoPrenotazione", ReplyAction="http://tempuri.org/IService1/InserimentoPrenotazioneResponse")]
        System.Threading.Tasks.Task<string> InserimentoPrenotazioneAsync(System.DateTime dataora, string username_utentefree, int codice_evento, int numero_posto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RappresentaSale", ReplyAction="http://tempuri.org/IService1/RappresentaSaleResponse")]
        string RappresentaSale(int codice_evento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RappresentaSale", ReplyAction="http://tempuri.org/IService1/RappresentaSaleResponse")]
        System.Threading.Tasks.Task<string> RappresentaSaleAsync(int codice_evento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerificaPosto", ReplyAction="http://tempuri.org/IService1/VerificaPostoResponse")]
        string VerificaPosto(int codice_evento, int numero_posto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerificaPosto", ReplyAction="http://tempuri.org/IService1/VerificaPostoResponse")]
        System.Threading.Tasks.Task<string> VerificaPostoAsync(int codice_evento, int numero_posto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCFClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCFClient.ServiceReference1.IService1>, WCFClient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool registration(bool isAdmin, string username, string password, string name, string surname) {
            return base.Channel.registration(isAdmin, username, password, name, surname);
        }
        
        public System.Threading.Tasks.Task<bool> registrationAsync(bool isAdmin, string username, string password, string name, string surname) {
            return base.Channel.registrationAsync(isAdmin, username, password, name, surname);
        }
        
        public bool login(bool isAdmin, string username, string password) {
            return base.Channel.login(isAdmin, username, password);
        }
        
        public System.Threading.Tasks.Task<bool> loginAsync(bool isAdmin, string username, string password) {
            return base.Channel.loginAsync(isAdmin, username, password);
        }
        
        public bool addFilm(string titolo, int anno, string regia, int durata, System.DateTime datauscita, string genere) {
            return base.Channel.addFilm(titolo, anno, regia, durata, datauscita, genere);
        }
        
        public System.Threading.Tasks.Task<bool> addFilmAsync(string titolo, int anno, string regia, int durata, System.DateTime datauscita, string genere) {
            return base.Channel.addFilmAsync(titolo, anno, regia, durata, datauscita, genere);
        }
        
        public string CancellazioneFilm(int codicefilm) {
            return base.Channel.CancellazioneFilm(codicefilm);
        }
        
        public System.Threading.Tasks.Task<string> CancellazioneFilmAsync(int codicefilm) {
            return base.Channel.CancellazioneFilmAsync(codicefilm);
        }
        
        public string InserimentoEvento(string usernameadmin, System.DateTime data_e_ora, int codice_film, int codice_sala, decimal prezzo) {
            return base.Channel.InserimentoEvento(usernameadmin, data_e_ora, codice_film, codice_sala, prezzo);
        }
        
        public System.Threading.Tasks.Task<string> InserimentoEventoAsync(string usernameadmin, System.DateTime data_e_ora, int codice_film, int codice_sala, decimal prezzo) {
            return base.Channel.InserimentoEventoAsync(usernameadmin, data_e_ora, codice_film, codice_sala, prezzo);
        }
        
        public string CancellazioneEvento(int codiceevento) {
            return base.Channel.CancellazioneEvento(codiceevento);
        }
        
        public System.Threading.Tasks.Task<string> CancellazioneEventoAsync(int codiceevento) {
            return base.Channel.CancellazioneEventoAsync(codiceevento);
        }
        
        public string Visualizzazione_elenco_film() {
            return base.Channel.Visualizzazione_elenco_film();
        }
        
        public System.Threading.Tasks.Task<string> Visualizzazione_elenco_filmAsync() {
            return base.Channel.Visualizzazione_elenco_filmAsync();
        }
        
        public string Visualizzazione_elenco_eventi() {
            return base.Channel.Visualizzazione_elenco_eventi();
        }
        
        public System.Threading.Tasks.Task<string> Visualizzazione_elenco_eventiAsync() {
            return base.Channel.Visualizzazione_elenco_eventiAsync();
        }
        
        public string VisualizzazioneSale() {
            return base.Channel.VisualizzazioneSale();
        }
        
        public System.Threading.Tasks.Task<string> VisualizzazioneSaleAsync() {
            return base.Channel.VisualizzazioneSaleAsync();
        }
        
        public string ControlloFK(int valore, string value_type) {
            return base.Channel.ControlloFK(valore, value_type);
        }
        
        public System.Threading.Tasks.Task<string> ControlloFKAsync(int valore, string value_type) {
            return base.Channel.ControlloFKAsync(valore, value_type);
        }
        
        public string Visualizzazione_elenco_UtentiFree() {
            return base.Channel.Visualizzazione_elenco_UtentiFree();
        }
        
        public System.Threading.Tasks.Task<string> Visualizzazione_elenco_UtentiFreeAsync() {
            return base.Channel.Visualizzazione_elenco_UtentiFreeAsync();
        }
        
        public string Visualizzazione_elenco_Prenotazioni(string user) {
            return base.Channel.Visualizzazione_elenco_Prenotazioni(user);
        }
        
        public System.Threading.Tasks.Task<string> Visualizzazione_elenco_PrenotazioniAsync(string user) {
            return base.Channel.Visualizzazione_elenco_PrenotazioniAsync(user);
        }
        
        public string VisualizzazionePostiDisponibili(int codice_evento) {
            return base.Channel.VisualizzazionePostiDisponibili(codice_evento);
        }
        
        public System.Threading.Tasks.Task<string> VisualizzazionePostiDisponibiliAsync(int codice_evento) {
            return base.Channel.VisualizzazionePostiDisponibiliAsync(codice_evento);
        }
        
        public string InserimentoPrenotazione(System.DateTime dataora, string username_utentefree, int codice_evento, int numero_posto) {
            return base.Channel.InserimentoPrenotazione(dataora, username_utentefree, codice_evento, numero_posto);
        }
        
        public System.Threading.Tasks.Task<string> InserimentoPrenotazioneAsync(System.DateTime dataora, string username_utentefree, int codice_evento, int numero_posto) {
            return base.Channel.InserimentoPrenotazioneAsync(dataora, username_utentefree, codice_evento, numero_posto);
        }
        
        public string RappresentaSale(int codice_evento) {
            return base.Channel.RappresentaSale(codice_evento);
        }
        
        public System.Threading.Tasks.Task<string> RappresentaSaleAsync(int codice_evento) {
            return base.Channel.RappresentaSaleAsync(codice_evento);
        }
        
        public string VerificaPosto(int codice_evento, int numero_posto) {
            return base.Channel.VerificaPosto(codice_evento, numero_posto);
        }
        
        public System.Threading.Tasks.Task<string> VerificaPostoAsync(int codice_evento, int numero_posto) {
            return base.Channel.VerificaPostoAsync(codice_evento, numero_posto);
        }
    }
}
