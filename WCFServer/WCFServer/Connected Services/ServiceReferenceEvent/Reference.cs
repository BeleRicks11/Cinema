﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServer.ServiceReferenceEvent {
    using System.Runtime.Serialization;
    using System;
    
    
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Show", Namespace="http://schemas.datacontract.org/2004/07/WCFDatabaseManager")]
    [System.SerializableAttribute()]
    public partial struct Show : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFServer.ServiceReferenceEvent.Event EventField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFServer.ServiceReferenceEvent.Film FilmField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFServer.ServiceReferenceEvent.Event Event {
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
        public WCFServer.ServiceReferenceEvent.Film Film {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceEvent.IServiceEvent")]
    public interface IServiceEvent {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEvent/AddEvent", ReplyAction="http://tempuri.org/IServiceEvent/AddEventResponse")]
        bool AddEvent(string usernameAdmin, System.DateTime dateTime, int filmCode, int hallCode, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEvent/AddEvent", ReplyAction="http://tempuri.org/IServiceEvent/AddEventResponse")]
        System.Threading.Tasks.Task<bool> AddEventAsync(string usernameAdmin, System.DateTime dateTime, int filmCode, int hallCode, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEvent/DeleteEvent", ReplyAction="http://tempuri.org/IServiceEvent/DeleteEventResponse")]
        bool DeleteEvent(int eventCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEvent/DeleteEvent", ReplyAction="http://tempuri.org/IServiceEvent/DeleteEventResponse")]
        System.Threading.Tasks.Task<bool> DeleteEventAsync(int eventCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEvent/GetEventsList", ReplyAction="http://tempuri.org/IServiceEvent/GetEventsListResponse")]
        WCFServer.ServiceReferenceEvent.Event[] GetEventsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEvent/GetEventsList", ReplyAction="http://tempuri.org/IServiceEvent/GetEventsListResponse")]
        System.Threading.Tasks.Task<WCFServer.ServiceReferenceEvent.Event[]> GetEventsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEvent/GetShowsList", ReplyAction="http://tempuri.org/IServiceEvent/GetShowsListResponse")]
        WCFServer.ServiceReferenceEvent.Show[] GetShowsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceEvent/GetShowsList", ReplyAction="http://tempuri.org/IServiceEvent/GetShowsListResponse")]
        System.Threading.Tasks.Task<WCFServer.ServiceReferenceEvent.Show[]> GetShowsListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceEventChannel : WCFServer.ServiceReferenceEvent.IServiceEvent, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceEventClient : System.ServiceModel.ClientBase<WCFServer.ServiceReferenceEvent.IServiceEvent>, WCFServer.ServiceReferenceEvent.IServiceEvent {
        
        public ServiceEventClient() {
        }
        
        public ServiceEventClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceEventClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEventClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEventClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddEvent(string usernameAdmin, System.DateTime dateTime, int filmCode, int hallCode, decimal price) {
            return base.Channel.AddEvent(usernameAdmin, dateTime, filmCode, hallCode, price);
        }
        
        public System.Threading.Tasks.Task<bool> AddEventAsync(string usernameAdmin, System.DateTime dateTime, int filmCode, int hallCode, decimal price) {
            return base.Channel.AddEventAsync(usernameAdmin, dateTime, filmCode, hallCode, price);
        }
        
        public bool DeleteEvent(int eventCode) {
            return base.Channel.DeleteEvent(eventCode);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteEventAsync(int eventCode) {
            return base.Channel.DeleteEventAsync(eventCode);
        }
        
        public WCFServer.ServiceReferenceEvent.Event[] GetEventsList() {
            return base.Channel.GetEventsList();
        }
        
        public System.Threading.Tasks.Task<WCFServer.ServiceReferenceEvent.Event[]> GetEventsListAsync() {
            return base.Channel.GetEventsListAsync();
        }
        
        public WCFServer.ServiceReferenceEvent.Show[] GetShowsList() {
            return base.Channel.GetShowsList();
        }
        
        public System.Threading.Tasks.Task<WCFServer.ServiceReferenceEvent.Show[]> GetShowsListAsync() {
            return base.Channel.GetShowsListAsync();
        }
    }
}
