﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHMES.WebServiceReference.WCF_SalesModuleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCF_SalesModuleService.ISalesModuleService")]
    public interface ISalesModuleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesModuleService/SC_Delete", ReplyAction="http://tempuri.org/ISalesModuleService/SC_DeleteResponse")]
        bool SC_Delete(byte[] loginTicket, string keyValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesModuleService/SO_ApprovalBusiness", ReplyAction="http://tempuri.org/ISalesModuleService/SO_ApprovalBusinessResponse")]
        void SO_ApprovalBusiness(byte[] loginTicket, string keyValue, string flagApp, string appUser, System.DateTime appDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesModuleService/SO_CheckNoExists", ReplyAction="http://tempuri.org/ISalesModuleService/SO_CheckNoExistsResponse")]
        bool SO_CheckNoExists(byte[] loginTicket, string keyValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesModuleService/SO_Delete", ReplyAction="http://tempuri.org/ISalesModuleService/SO_DeleteResponse")]
        bool SO_Delete(byte[] loginTicket, string keyValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesModuleService/SO_GetBusinessByKey", ReplyAction="http://tempuri.org/ISalesModuleService/SO_GetBusinessByKeyResponse")]
        byte[] SO_GetBusinessByKey(byte[] loginTicket, string keyValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesModuleService/SO_GetReportData", ReplyAction="http://tempuri.org/ISalesModuleService/SO_GetReportDataResponse")]
        byte[] SO_GetReportData(byte[] loginTicket, string DocNoFrom, string DocNoTo, System.DateTime DateFrom, System.DateTime DateTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesModuleService/SO_GetSummaryByParam", ReplyAction="http://tempuri.org/ISalesModuleService/SO_GetSummaryByParamResponse")]
        byte[] SO_GetSummaryByParam(byte[] loginTicket, string DocNoFrom, string DocNoTo, System.DateTime docDateFrom, System.DateTime docDateTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesModuleService/SO_Update", ReplyAction="http://tempuri.org/ISalesModuleService/SO_UpdateResponse")]
        byte[] SO_Update(byte[] loginTicket, byte[] saveData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISalesModuleServiceChannel : HHMES.WebServiceReference.WCF_SalesModuleService.ISalesModuleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SalesModuleServiceClient : System.ServiceModel.ClientBase<HHMES.WebServiceReference.WCF_SalesModuleService.ISalesModuleService>, HHMES.WebServiceReference.WCF_SalesModuleService.ISalesModuleService {
        
        public SalesModuleServiceClient() {
        }
        
        public SalesModuleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SalesModuleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesModuleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesModuleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SC_Delete(byte[] loginTicket, string keyValue) {
            return base.Channel.SC_Delete(loginTicket, keyValue);
        }
        
        public void SO_ApprovalBusiness(byte[] loginTicket, string keyValue, string flagApp, string appUser, System.DateTime appDate) {
            base.Channel.SO_ApprovalBusiness(loginTicket, keyValue, flagApp, appUser, appDate);
        }
        
        public bool SO_CheckNoExists(byte[] loginTicket, string keyValue) {
            return base.Channel.SO_CheckNoExists(loginTicket, keyValue);
        }
        
        public bool SO_Delete(byte[] loginTicket, string keyValue) {
            return base.Channel.SO_Delete(loginTicket, keyValue);
        }
        
        public byte[] SO_GetBusinessByKey(byte[] loginTicket, string keyValue) {
            return base.Channel.SO_GetBusinessByKey(loginTicket, keyValue);
        }
        
        public byte[] SO_GetReportData(byte[] loginTicket, string DocNoFrom, string DocNoTo, System.DateTime DateFrom, System.DateTime DateTo) {
            return base.Channel.SO_GetReportData(loginTicket, DocNoFrom, DocNoTo, DateFrom, DateTo);
        }
        
        public byte[] SO_GetSummaryByParam(byte[] loginTicket, string DocNoFrom, string DocNoTo, System.DateTime docDateFrom, System.DateTime docDateTo) {
            return base.Channel.SO_GetSummaryByParam(loginTicket, DocNoFrom, DocNoTo, docDateFrom, docDateTo);
        }
        
        public byte[] SO_Update(byte[] loginTicket, byte[] saveData) {
            return base.Channel.SO_Update(loginTicket, saveData);
        }
    }
}