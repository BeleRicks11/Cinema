﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServer.ServiceReferencePrenotation {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Prenotation", Namespace="http://schemas.datacontract.org/2004/07/WCFDatabaseManager")]
    [System.SerializableAttribute()]
    public partial class Prenotation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EventCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PrenotationCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameUserField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTime {
            get {
                return this.DateTimeField;
            }
            set {
                if ((this.DateTimeField.Equals(value) != true)) {
                    this.DateTimeField = value;
                    this.RaisePropertyChanged("DateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EventCode {
            get {
                return this.EventCodeField;
            }
            set {
                if ((this.EventCodeField.Equals(value) != true)) {
                    this.EventCodeField = value;
                    this.RaisePropertyChanged("EventCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PrenotationCode {
            get {
                return this.PrenotationCodeField;
            }
            set {
                if ((this.PrenotationCodeField.Equals(value) != true)) {
                    this.PrenotationCodeField = value;
                    this.RaisePropertyChanged("PrenotationCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsernameUser {
            get {
                return this.UsernameUserField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameUserField, value) != true)) {
                    this.UsernameUserField = value;
                    this.RaisePropertyChanged("UsernameUser");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ticket", Namespace="http://schemas.datacontract.org/2004/07/WCFDatabaseManager")]
    [System.SerializableAttribute()]
    public partial struct Ticket : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFServer.ServiceReferencePrenotation.Event EventField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFServer.ServiceReferencePrenotation.Film FilmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFServer.ServiceReferencePrenotation.Prenotation PrenotationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFServer.ServiceReferencePrenotation.Reservation ReservationField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFServer.ServiceReferencePrenotation.Event Event {
            get {
                return this.EventField;
            }
            set {
                if ((object.ReferenceEquals(this.EventField, value) != true)) {
                    this.EventField = value;
                    this.RaisePropertyChanged("Event");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFServer.ServiceReferencePrenotation.Film Film {
            get {
                return this.FilmField;
            }
            set {
                if ((object.ReferenceEquals(this.FilmField, value) != true)) {
                    this.FilmField = value;
                    this.RaisePropertyChanged("Film");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFServer.ServiceReferencePrenotation.Prenotation Prenotation {
            get {
                return this.PrenotationField;
            }
            set {
                if ((object.ReferenceEquals(this.PrenotationField, value) != true)) {
                    this.PrenotationField = value;
                    this.RaisePropertyChanged("Prenotation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFServer.ServiceReferencePrenotation.Reservation Reservation {
            get {
                return this.ReservationField;
            }
            set {
                if ((object.ReferenceEquals(this.ReservationField, value) != true)) {
                    this.ReservationField = value;
                    this.RaisePropertyChanged("Reservation");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Event", Namespace="http://schemas.datacontract.org/2004/07/WCFDatabaseManager")]
    [System.SerializableAttribute()]
    public partial class Event : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EventCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FilmCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HallCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameAdminField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTime {
            get {
                return this.DateTimeField;
            }
            set {
                if ((this.DateTimeField.Equals(value) != true)) {
                    this.DateTimeField = value;
                    this.RaisePropertyChanged("DateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EventCode {
            get {
                return this.EventCodeField;
            }
            set {
                if ((this.EventCodeField.Equals(value) != true)) {
                    this.EventCodeField = value;
                    this.RaisePropertyChanged("EventCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FilmCode {
            get {
                return this.FilmCodeField;
            }
            set {
                if ((this.FilmCodeField.Equals(value) != true)) {
                    this.FilmCodeField = value;
                    this.RaisePropertyChanged("FilmCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HallCode {
            get {
                return this.HallCodeField;
            }
            set {
                if ((this.HallCodeField.Equals(value) != true)) {
                    this.HallCodeField = value;
                    this.RaisePropertyChanged("HallCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsernameAdmin {
            get {
                return this.UsernameAdminField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameAdminField, value) != true)) {
                    this.UsernameAdminField = value;
                    this.RaisePropertyChanged("UsernameAdmin");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Film", Namespace="http://schemas.datacontract.org/2004/07/WCFDatabaseManager")]
    [System.SerializableAttribute()]
    public partial class Film : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DurationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FilmCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReleaseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direction {
            get {
                return this.DirectionField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectionField, value) != true)) {
                    this.DirectionField = value;
                    this.RaisePropertyChanged("Direction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Duration {
            get {
                return this.DurationField;
            }
            set {
                if ((this.DurationField.Equals(value) != true)) {
                    this.DurationField = value;
                    this.RaisePropertyChanged("Duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FilmCode {
            get {
                return this.FilmCodeField;
            }
            set {
                if ((this.FilmCodeField.Equals(value) != true)) {
                    this.FilmCodeField = value;
                    this.RaisePropertyChanged("FilmCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reservation", Namespace="http://schemas.datacontract.org/2004/07/WCFDatabaseManager")]
    [System.SerializableAttribute()]
    public partial class Reservation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PlaceNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PrenotationCodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PlaceNumber {
            get {
                return this.PlaceNumberField;
            }
            set {
                if ((this.PlaceNumberField.Equals(value) != true)) {
                    this.PlaceNumberField = value;
                    this.RaisePropertyChanged("PlaceNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PrenotationCode {
            get {
                return this.PrenotationCodeField;
            }
            set {
                if ((this.PrenotationCodeField.Equals(value) != true)) {
                    this.PrenotationCodeField = value;
                    this.RaisePropertyChanged("PrenotationCode");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePrenotation.IServicePrenotation")]
    public interface IServicePrenotation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePrenotation/AddPrenotation", ReplyAction="http://tempuri.org/IServicePrenotation/AddPrenotationResponse")]
        bool AddPrenotation(System.DateTime dateTime, string usernameUser, int eventCode, int placeNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePrenotation/AddPrenotation", ReplyAction="http://tempuri.org/IServicePrenotation/AddPrenotationResponse")]
        System.Threading.Tasks.Task<bool> AddPrenotationAsync(System.DateTime dateTime, string usernameUser, int eventCode, int placeNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePrenotation/DeletePrenotation", ReplyAction="http://tempuri.org/IServicePrenotation/DeletePrenotationResponse")]
        bool DeletePrenotation(int prenotationCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePrenotation/DeletePrenotation", ReplyAction="http://tempuri.org/IServicePrenotation/DeletePrenotationResponse")]
        System.Threading.Tasks.Task<bool> DeletePrenotationAsync(int prenotationCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePrenotation/GetPrenotationsList", ReplyAction="http://tempuri.org/IServicePrenotation/GetPrenotationsListResponse")]
        WCFServer.ServiceReferencePrenotation.Prenotation[] GetPrenotationsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePrenotation/GetPrenotationsList", ReplyAction="http://tempuri.org/IServicePrenotation/GetPrenotationsListResponse")]
        System.Threading.Tasks.Task<WCFServer.ServiceReferencePrenotation.Prenotation[]> GetPrenotationsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePrenotation/GetTicketsList", ReplyAction="http://tempuri.org/IServicePrenotation/GetTicketsListResponse")]
        WCFServer.ServiceReferencePrenotation.Ticket[] GetTicketsList(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePrenotation/GetTicketsList", ReplyAction="http://tempuri.org/IServicePrenotation/GetTicketsListResponse")]
        System.Threading.Tasks.Task<WCFServer.ServiceReferencePrenotation.Ticket[]> GetTicketsListAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePrenotationChannel : WCFServer.ServiceReferencePrenotation.IServicePrenotation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePrenotationClient : System.ServiceModel.ClientBase<WCFServer.ServiceReferencePrenotation.IServicePrenotation>, WCFServer.ServiceReferencePrenotation.IServicePrenotation {
        
        public ServicePrenotationClient() {
        }
        
        public ServicePrenotationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePrenotationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePrenotationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePrenotationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddPrenotation(System.DateTime dateTime, string usernameUser, int eventCode, int placeNumber) {
            return base.Channel.AddPrenotation(dateTime, usernameUser, eventCode, placeNumber);
        }
        
        public System.Threading.Tasks.Task<bool> AddPrenotationAsync(System.DateTime dateTime, string usernameUser, int eventCode, int placeNumber) {
            return base.Channel.AddPrenotationAsync(dateTime, usernameUser, eventCode, placeNumber);
        }
        
        public bool DeletePrenotation(int prenotationCode) {
            return base.Channel.DeletePrenotation(prenotationCode);
        }
        
        public System.Threading.Tasks.Task<bool> DeletePrenotationAsync(int prenotationCode) {
            return base.Channel.DeletePrenotationAsync(prenotationCode);
        }
        
        public WCFServer.ServiceReferencePrenotation.Prenotation[] GetPrenotationsList() {
            return base.Channel.GetPrenotationsList();
        }
        
        public System.Threading.Tasks.Task<WCFServer.ServiceReferencePrenotation.Prenotation[]> GetPrenotationsListAsync() {
            return base.Channel.GetPrenotationsListAsync();
        }
        
        public WCFServer.ServiceReferencePrenotation.Ticket[] GetTicketsList(string username) {
            return base.Channel.GetTicketsList(username);
        }
        
        public System.Threading.Tasks.Task<WCFServer.ServiceReferencePrenotation.Ticket[]> GetTicketsListAsync(string username) {
            return base.Channel.GetTicketsListAsync(username);
        }
    }
}
