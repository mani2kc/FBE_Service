﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroServiceClient.GetEstimateService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SOCRequest", Namespace="http://schemas.datacontract.org/2004/07/Microservice_WCF_library.DataContract")]
    [System.SerializableAttribute()]
    public partial class SOCRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MicroServiceClient.GetEstimateService.ProductInfo[] ProductsField;
        
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
        public MicroServiceClient.GetEstimateService.ProductInfo[] Products {
            get {
                return this.ProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductsField, value) != true)) {
                    this.ProductsField = value;
                    this.RaisePropertyChanged("Products");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductInfo", Namespace="http://schemas.datacontract.org/2004/07/Microservice_WCF_library.DataContract")]
    [System.SerializableAttribute()]
    public partial class ProductInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIOSCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal RateField;
        
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
        public string ProductIOSC {
            get {
                return this.ProductIOSCField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIOSCField, value) != true)) {
                    this.ProductIOSCField = value;
                    this.RaisePropertyChanged("ProductIOSC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Rate {
            get {
                return this.RateField;
            }
            set {
                if ((this.RateField.Equals(value) != true)) {
                    this.RateField = value;
                    this.RaisePropertyChanged("Rate");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SOCResponse", Namespace="http://schemas.datacontract.org/2004/07/Microservice_WCF_library.DataContract")]
    [System.SerializableAttribute()]
    public partial class SOCResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MicroServiceClient.GetEstimateService.ProductInfo[] ProductlstField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MicroServiceClient.GetEstimateService.SOCEstimate SOCEstimateField;
        
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
        public MicroServiceClient.GetEstimateService.ProductInfo[] Productlst {
            get {
                return this.ProductlstField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductlstField, value) != true)) {
                    this.ProductlstField = value;
                    this.RaisePropertyChanged("Productlst");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MicroServiceClient.GetEstimateService.SOCEstimate SOCEstimate {
            get {
                return this.SOCEstimateField;
            }
            set {
                if ((object.ReferenceEquals(this.SOCEstimateField, value) != true)) {
                    this.SOCEstimateField = value;
                    this.RaisePropertyChanged("SOCEstimate");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SOCEstimate", Namespace="http://schemas.datacontract.org/2004/07/Microservice_WCF_library.DataContract")]
    [System.SerializableAttribute()]
    public partial class SOCEstimate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal FirstBillField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MonthlyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MicroServiceClient.GetEstimateService.TaxResponse TaxResponseField;
        
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
        public decimal FirstBill {
            get {
                return this.FirstBillField;
            }
            set {
                if ((this.FirstBillField.Equals(value) != true)) {
                    this.FirstBillField = value;
                    this.RaisePropertyChanged("FirstBill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Monthly {
            get {
                return this.MonthlyField;
            }
            set {
                if ((this.MonthlyField.Equals(value) != true)) {
                    this.MonthlyField = value;
                    this.RaisePropertyChanged("Monthly");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MicroServiceClient.GetEstimateService.TaxResponse TaxResponse {
            get {
                return this.TaxResponseField;
            }
            set {
                if ((object.ReferenceEquals(this.TaxResponseField, value) != true)) {
                    this.TaxResponseField = value;
                    this.RaisePropertyChanged("TaxResponse");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TaxResponse", Namespace="http://schemas.datacontract.org/2004/07/Microservice_WCF_library.DataContract")]
    [System.SerializableAttribute()]
    public partial class TaxResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal FirstBillTaxesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MonthlyTaxesField;
        
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
        public decimal FirstBillTaxes {
            get {
                return this.FirstBillTaxesField;
            }
            set {
                if ((this.FirstBillTaxesField.Equals(value) != true)) {
                    this.FirstBillTaxesField = value;
                    this.RaisePropertyChanged("FirstBillTaxes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MonthlyTaxes {
            get {
                return this.MonthlyTaxesField;
            }
            set {
                if ((this.MonthlyTaxesField.Equals(value) != true)) {
                    this.MonthlyTaxesField = value;
                    this.RaisePropertyChanged("MonthlyTaxes");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TaxRequest", Namespace="http://schemas.datacontract.org/2004/07/Microservice_WCF_library.DataContract")]
    [System.SerializableAttribute()]
    public partial class TaxRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal FirstBillChargesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MonthlyChargesField;
        
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
        public decimal FirstBillCharges {
            get {
                return this.FirstBillChargesField;
            }
            set {
                if ((this.FirstBillChargesField.Equals(value) != true)) {
                    this.FirstBillChargesField = value;
                    this.RaisePropertyChanged("FirstBillCharges");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MonthlyCharges {
            get {
                return this.MonthlyChargesField;
            }
            set {
                if ((this.MonthlyChargesField.Equals(value) != true)) {
                    this.MonthlyChargesField = value;
                    this.RaisePropertyChanged("MonthlyCharges");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GetEstimateService.IGetEstimate")]
    public interface IGetEstimate {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEstimate/GetSOCEstimate", ReplyAction="http://tempuri.org/IGetEstimate/GetSOCEstimateResponse")]
        MicroServiceClient.GetEstimateService.SOCResponse GetSOCEstimate(MicroServiceClient.GetEstimateService.SOCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEstimate/GetSOCEstimate", ReplyAction="http://tempuri.org/IGetEstimate/GetSOCEstimateResponse")]
        System.Threading.Tasks.Task<MicroServiceClient.GetEstimateService.SOCResponse> GetSOCEstimateAsync(MicroServiceClient.GetEstimateService.SOCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEstimate/GetTaxes", ReplyAction="http://tempuri.org/IGetEstimate/GetTaxesResponse")]
        MicroServiceClient.GetEstimateService.TaxResponse GetTaxes(MicroServiceClient.GetEstimateService.TaxRequest taxRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEstimate/GetTaxes", ReplyAction="http://tempuri.org/IGetEstimate/GetTaxesResponse")]
        System.Threading.Tasks.Task<MicroServiceClient.GetEstimateService.TaxResponse> GetTaxesAsync(MicroServiceClient.GetEstimateService.TaxRequest taxRequest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetEstimateChannel : MicroServiceClient.GetEstimateService.IGetEstimate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetEstimateClient : System.ServiceModel.ClientBase<MicroServiceClient.GetEstimateService.IGetEstimate>, MicroServiceClient.GetEstimateService.IGetEstimate {
        
        public GetEstimateClient() {
        }
        
        public GetEstimateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetEstimateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetEstimateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetEstimateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MicroServiceClient.GetEstimateService.SOCResponse GetSOCEstimate(MicroServiceClient.GetEstimateService.SOCRequest request) {
            return base.Channel.GetSOCEstimate(request);
        }
        
        public System.Threading.Tasks.Task<MicroServiceClient.GetEstimateService.SOCResponse> GetSOCEstimateAsync(MicroServiceClient.GetEstimateService.SOCRequest request) {
            return base.Channel.GetSOCEstimateAsync(request);
        }
        
        public MicroServiceClient.GetEstimateService.TaxResponse GetTaxes(MicroServiceClient.GetEstimateService.TaxRequest taxRequest) {
            return base.Channel.GetTaxes(taxRequest);
        }
        
        public System.Threading.Tasks.Task<MicroServiceClient.GetEstimateService.TaxResponse> GetTaxesAsync(MicroServiceClient.GetEstimateService.TaxRequest taxRequest) {
            return base.Channel.GetTaxesAsync(taxRequest);
        }
    }
}
