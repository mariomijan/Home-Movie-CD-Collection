﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCHTTPClient.CategoryReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<MVCHTTPClient.CategoryReference.Movie> MoviesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCHTTPClient.CategoryReference.UserTable UserField;
        
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
        public System.Collections.Generic.List<MVCHTTPClient.CategoryReference.Movie> Movies {
            get {
                return this.MoviesField;
            }
            set {
                if ((object.ReferenceEquals(this.MoviesField, value) != true)) {
                    this.MoviesField = value;
                    this.RaisePropertyChanged("Movies");
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
        public MVCHTTPClient.CategoryReference.UserTable User {
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
        private MVCHTTPClient.CategoryReference.Login LoginField;
        
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
        public MVCHTTPClient.CategoryReference.Login Login {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCHTTPClient.CategoryReference.Category CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCHTTPClient.CategoryReference.UserTable UserField;
        
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
        public MVCHTTPClient.CategoryReference.Category Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
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
        public MVCHTTPClient.CategoryReference.UserTable User {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CategoryReference.ICategoryService")]
    public interface ICategoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/AddCategory", ReplyAction="http://tempuri.org/ICategoryService/AddCategoryResponse")]
        void AddCategory(MVCHTTPClient.CategoryReference.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/AddCategory", ReplyAction="http://tempuri.org/ICategoryService/AddCategoryResponse")]
        System.Threading.Tasks.Task AddCategoryAsync(MVCHTTPClient.CategoryReference.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetAllCategories", ReplyAction="http://tempuri.org/ICategoryService/GetAllCategoriesResponse")]
        System.Collections.Generic.List<MVCHTTPClient.CategoryReference.Category> GetAllCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetAllCategories", ReplyAction="http://tempuri.org/ICategoryService/GetAllCategoriesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MVCHTTPClient.CategoryReference.Category>> GetAllCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetCategory", ReplyAction="http://tempuri.org/ICategoryService/GetCategoryResponse")]
        MVCHTTPClient.CategoryReference.Category GetCategory(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetCategory", ReplyAction="http://tempuri.org/ICategoryService/GetCategoryResponse")]
        System.Threading.Tasks.Task<MVCHTTPClient.CategoryReference.Category> GetCategoryAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/UpdateCategory", ReplyAction="http://tempuri.org/ICategoryService/UpdateCategoryResponse")]
        void UpdateCategory(MVCHTTPClient.CategoryReference.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/UpdateCategory", ReplyAction="http://tempuri.org/ICategoryService/UpdateCategoryResponse")]
        System.Threading.Tasks.Task UpdateCategoryAsync(MVCHTTPClient.CategoryReference.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/DeleteCategory", ReplyAction="http://tempuri.org/ICategoryService/DeleteCategoryResponse")]
        void DeleteCategory(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/DeleteCategory", ReplyAction="http://tempuri.org/ICategoryService/DeleteCategoryResponse")]
        System.Threading.Tasks.Task DeleteCategoryAsync(System.Nullable<int> id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategoryServiceChannel : MVCHTTPClient.CategoryReference.ICategoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoryServiceClient : System.ServiceModel.ClientBase<MVCHTTPClient.CategoryReference.ICategoryService>, MVCHTTPClient.CategoryReference.ICategoryService {
        
        public CategoryServiceClient() {
        }
        
        public CategoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCategory(MVCHTTPClient.CategoryReference.Category category) {
            base.Channel.AddCategory(category);
        }
        
        public System.Threading.Tasks.Task AddCategoryAsync(MVCHTTPClient.CategoryReference.Category category) {
            return base.Channel.AddCategoryAsync(category);
        }
        
        public System.Collections.Generic.List<MVCHTTPClient.CategoryReference.Category> GetAllCategories() {
            return base.Channel.GetAllCategories();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MVCHTTPClient.CategoryReference.Category>> GetAllCategoriesAsync() {
            return base.Channel.GetAllCategoriesAsync();
        }
        
        public MVCHTTPClient.CategoryReference.Category GetCategory(int id) {
            return base.Channel.GetCategory(id);
        }
        
        public System.Threading.Tasks.Task<MVCHTTPClient.CategoryReference.Category> GetCategoryAsync(int id) {
            return base.Channel.GetCategoryAsync(id);
        }
        
        public void UpdateCategory(MVCHTTPClient.CategoryReference.Category category) {
            base.Channel.UpdateCategory(category);
        }
        
        public System.Threading.Tasks.Task UpdateCategoryAsync(MVCHTTPClient.CategoryReference.Category category) {
            return base.Channel.UpdateCategoryAsync(category);
        }
        
        public void DeleteCategory(System.Nullable<int> id) {
            base.Channel.DeleteCategory(id);
        }
        
        public System.Threading.Tasks.Task DeleteCategoryAsync(System.Nullable<int> id) {
            return base.Channel.DeleteCategoryAsync(id);
        }
    }
}
