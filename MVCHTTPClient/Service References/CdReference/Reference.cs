﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCHTTPClient.CdReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cd", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class Cd : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCHTTPClient.CdReference.Genre GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCHTTPClient.CdReference.UserTable UserField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVCHTTPClient.CdReference.Genre Genre {
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVCHTTPClient.CdReference.UserTable User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Genre", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class Genre : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd> CdsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd> Cds {
            get {
                return this.CdsField;
            }
            set {
                if ((object.ReferenceEquals(this.CdsField, value) != true)) {
                    this.CdsField = value;
                    this.RaisePropertyChanged("Cds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserTable", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class UserTable : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCHTTPClient.CdReference.Login LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lastname {
            get {
                return this.LastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameField, value) != true)) {
                    this.LastnameField = value;
                    this.RaisePropertyChanged("Lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MVCHTTPClient.CdReference.Login Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Login", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class Login : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CdReference.ICdService")]
    public interface ICdService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/AddCd", ReplyAction="http://tempuri.org/ICdService/AddCdResponse")]
        void AddCd(MVCHTTPClient.CdReference.Cd cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/AddCd", ReplyAction="http://tempuri.org/ICdService/AddCdResponse")]
        System.Threading.Tasks.Task AddCdAsync(MVCHTTPClient.CdReference.Cd cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/UpdateCd", ReplyAction="http://tempuri.org/ICdService/UpdateCdResponse")]
        void UpdateCd(MVCHTTPClient.CdReference.Cd cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/UpdateCd", ReplyAction="http://tempuri.org/ICdService/UpdateCdResponse")]
        System.Threading.Tasks.Task UpdateCdAsync(MVCHTTPClient.CdReference.Cd cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/GetCd", ReplyAction="http://tempuri.org/ICdService/GetCdResponse")]
        MVCHTTPClient.CdReference.Cd GetCd(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/GetCd", ReplyAction="http://tempuri.org/ICdService/GetCdResponse")]
        System.Threading.Tasks.Task<MVCHTTPClient.CdReference.Cd> GetCdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/GetAllCds", ReplyAction="http://tempuri.org/ICdService/GetAllCdsResponse")]
        System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd> GetAllCds();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/GetAllCds", ReplyAction="http://tempuri.org/ICdService/GetAllCdsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd>> GetAllCdsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/DeleteCd", ReplyAction="http://tempuri.org/ICdService/DeleteCdResponse")]
        void DeleteCd(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/DeleteCd", ReplyAction="http://tempuri.org/ICdService/DeleteCdResponse")]
        System.Threading.Tasks.Task DeleteCdAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/GetAllCdsByGenre", ReplyAction="http://tempuri.org/ICdService/GetAllCdsByGenreResponse")]
        System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd> GetAllCdsByGenre(int genreId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICdService/GetAllCdsByGenre", ReplyAction="http://tempuri.org/ICdService/GetAllCdsByGenreResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd>> GetAllCdsByGenreAsync(int genreId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICdServiceChannel : MVCHTTPClient.CdReference.ICdService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CdServiceClient : System.ServiceModel.ClientBase<MVCHTTPClient.CdReference.ICdService>, MVCHTTPClient.CdReference.ICdService {
        
        public CdServiceClient() {
        }
        
        public CdServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CdServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CdServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CdServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCd(MVCHTTPClient.CdReference.Cd cd) {
            base.Channel.AddCd(cd);
        }
        
        public System.Threading.Tasks.Task AddCdAsync(MVCHTTPClient.CdReference.Cd cd) {
            return base.Channel.AddCdAsync(cd);
        }
        
        public void UpdateCd(MVCHTTPClient.CdReference.Cd cd) {
            base.Channel.UpdateCd(cd);
        }
        
        public System.Threading.Tasks.Task UpdateCdAsync(MVCHTTPClient.CdReference.Cd cd) {
            return base.Channel.UpdateCdAsync(cd);
        }
        
        public MVCHTTPClient.CdReference.Cd GetCd(int id) {
            return base.Channel.GetCd(id);
        }
        
        public System.Threading.Tasks.Task<MVCHTTPClient.CdReference.Cd> GetCdAsync(int id) {
            return base.Channel.GetCdAsync(id);
        }
        
        public System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd> GetAllCds() {
            return base.Channel.GetAllCds();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd>> GetAllCdsAsync() {
            return base.Channel.GetAllCdsAsync();
        }
        
        public void DeleteCd(System.Nullable<int> id) {
            base.Channel.DeleteCd(id);
        }
        
        public System.Threading.Tasks.Task DeleteCdAsync(System.Nullable<int> id) {
            return base.Channel.DeleteCdAsync(id);
        }
        
        public System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd> GetAllCdsByGenre(int genreId) {
            return base.Channel.GetAllCdsByGenre(genreId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MVCHTTPClient.CdReference.Cd>> GetAllCdsByGenreAsync(int genreId) {
            return base.Channel.GetAllCdsByGenreAsync(genreId);
        }
    }
}