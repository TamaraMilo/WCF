﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZI.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptA52", ReplyAction="http://tempuri.org/IService/EncryptA52Response")]
        void EncryptA52(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptA52", ReplyAction="http://tempuri.org/IService/EncryptA52Response")]
        System.Threading.Tasks.Task EncryptA52Async(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptA52", ReplyAction="http://tempuri.org/IService/DecryptA52Response")]
        void DecryptA52(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptA52", ReplyAction="http://tempuri.org/IService/DecryptA52Response")]
        System.Threading.Tasks.Task DecryptA52Async(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptRailFence", ReplyAction="http://tempuri.org/IService/EncryptRailFenceResponse")]
        void EncryptRailFence(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptRailFence", ReplyAction="http://tempuri.org/IService/EncryptRailFenceResponse")]
        System.Threading.Tasks.Task EncryptRailFenceAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptRailDence", ReplyAction="http://tempuri.org/IService/DecryptRailDenceResponse")]
        void DecryptRailDence(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptRailDence", ReplyAction="http://tempuri.org/IService/DecryptRailDenceResponse")]
        System.Threading.Tasks.Task DecryptRailDenceAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptXTEA", ReplyAction="http://tempuri.org/IService/EncryptXTEAResponse")]
        void EncryptXTEA(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptXTEA", ReplyAction="http://tempuri.org/IService/EncryptXTEAResponse")]
        System.Threading.Tasks.Task EncryptXTEAAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptXTEA", ReplyAction="http://tempuri.org/IService/DecryptXTEAResponse")]
        void DecryptXTEA(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptXTEA", ReplyAction="http://tempuri.org/IService/DecryptXTEAResponse")]
        System.Threading.Tasks.Task DecryptXTEAAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptPCBC", ReplyAction="http://tempuri.org/IService/EncryptPCBCResponse")]
        void EncryptPCBC(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptPCBC", ReplyAction="http://tempuri.org/IService/EncryptPCBCResponse")]
        System.Threading.Tasks.Task EncryptPCBCAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptPCBC", ReplyAction="http://tempuri.org/IService/DecryptPCBCResponse")]
        void DecryptPCBC(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptPCBC", ReplyAction="http://tempuri.org/IService/DecryptPCBCResponse")]
        System.Threading.Tasks.Task DecryptPCBCAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptA52BMP", ReplyAction="http://tempuri.org/IService/EncryptA52BMPResponse")]
        void EncryptA52BMP(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptA52BMP", ReplyAction="http://tempuri.org/IService/EncryptA52BMPResponse")]
        System.Threading.Tasks.Task EncryptA52BMPAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptA52BMP", ReplyAction="http://tempuri.org/IService/DecryptA52BMPResponse")]
        void DecryptA52BMP(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptA52BMP", ReplyAction="http://tempuri.org/IService/DecryptA52BMPResponse")]
        System.Threading.Tasks.Task DecryptA52BMPAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptRailFenceBMP", ReplyAction="http://tempuri.org/IService/EncryptRailFenceBMPResponse")]
        void EncryptRailFenceBMP(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptRailFenceBMP", ReplyAction="http://tempuri.org/IService/EncryptRailFenceBMPResponse")]
        System.Threading.Tasks.Task EncryptRailFenceBMPAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptRailDenceBMP", ReplyAction="http://tempuri.org/IService/DecryptRailDenceBMPResponse")]
        void DecryptRailDenceBMP(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptRailDenceBMP", ReplyAction="http://tempuri.org/IService/DecryptRailDenceBMPResponse")]
        System.Threading.Tasks.Task DecryptRailDenceBMPAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptPCBCBMP", ReplyAction="http://tempuri.org/IService/EncryptPCBCBMPResponse")]
        void EncryptPCBCBMP(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptPCBCBMP", ReplyAction="http://tempuri.org/IService/EncryptPCBCBMPResponse")]
        System.Threading.Tasks.Task EncryptPCBCBMPAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptPCBCBMP", ReplyAction="http://tempuri.org/IService/DecryptPCBCBMPResponse")]
        void DecryptPCBCBMP(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DecryptPCBCBMP", ReplyAction="http://tempuri.org/IService/DecryptPCBCBMPResponse")]
        System.Threading.Tasks.Task DecryptPCBCBMPAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Md5hash", ReplyAction="http://tempuri.org/IService/Md5hashResponse")]
        bool Md5hash(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Md5hash", ReplyAction="http://tempuri.org/IService/Md5hashResponse")]
        System.Threading.Tasks.Task<bool> Md5hashAsync(string loadPath, string savePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptParalelization", ReplyAction="http://tempuri.org/IService/EncryptParalelizationResponse")]
        void EncryptParalelization(string loadPath, string savePath, int numberOfThreads, int rails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EncryptParalelization", ReplyAction="http://tempuri.org/IService/EncryptParalelizationResponse")]
        System.Threading.Tasks.Task EncryptParalelizationAsync(string loadPath, string savePath, int numberOfThreads, int rails);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ZI.Service.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ZI.Service.IService>, ZI.Service.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void EncryptA52(string loadPath, string savePath) {
            base.Channel.EncryptA52(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task EncryptA52Async(string loadPath, string savePath) {
            return base.Channel.EncryptA52Async(loadPath, savePath);
        }
        
        public void DecryptA52(string loadPath, string savePath) {
            base.Channel.DecryptA52(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task DecryptA52Async(string loadPath, string savePath) {
            return base.Channel.DecryptA52Async(loadPath, savePath);
        }
        
        public void EncryptRailFence(string loadPath, string savePath) {
            base.Channel.EncryptRailFence(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task EncryptRailFenceAsync(string loadPath, string savePath) {
            return base.Channel.EncryptRailFenceAsync(loadPath, savePath);
        }
        
        public void DecryptRailDence(string loadPath, string savePath) {
            base.Channel.DecryptRailDence(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task DecryptRailDenceAsync(string loadPath, string savePath) {
            return base.Channel.DecryptRailDenceAsync(loadPath, savePath);
        }
        
        public void EncryptXTEA(string loadPath, string savePath) {
            base.Channel.EncryptXTEA(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task EncryptXTEAAsync(string loadPath, string savePath) {
            return base.Channel.EncryptXTEAAsync(loadPath, savePath);
        }
        
        public void DecryptXTEA(string loadPath, string savePath) {
            base.Channel.DecryptXTEA(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task DecryptXTEAAsync(string loadPath, string savePath) {
            return base.Channel.DecryptXTEAAsync(loadPath, savePath);
        }
        
        public void EncryptPCBC(string loadPath, string savePath) {
            base.Channel.EncryptPCBC(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task EncryptPCBCAsync(string loadPath, string savePath) {
            return base.Channel.EncryptPCBCAsync(loadPath, savePath);
        }
        
        public void DecryptPCBC(string loadPath, string savePath) {
            base.Channel.DecryptPCBC(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task DecryptPCBCAsync(string loadPath, string savePath) {
            return base.Channel.DecryptPCBCAsync(loadPath, savePath);
        }
        
        public void EncryptA52BMP(string loadPath, string savePath) {
            base.Channel.EncryptA52BMP(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task EncryptA52BMPAsync(string loadPath, string savePath) {
            return base.Channel.EncryptA52BMPAsync(loadPath, savePath);
        }
        
        public void DecryptA52BMP(string loadPath, string savePath) {
            base.Channel.DecryptA52BMP(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task DecryptA52BMPAsync(string loadPath, string savePath) {
            return base.Channel.DecryptA52BMPAsync(loadPath, savePath);
        }
        
        public void EncryptRailFenceBMP(string loadPath, string savePath) {
            base.Channel.EncryptRailFenceBMP(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task EncryptRailFenceBMPAsync(string loadPath, string savePath) {
            return base.Channel.EncryptRailFenceBMPAsync(loadPath, savePath);
        }
        
        public void DecryptRailDenceBMP(string loadPath, string savePath) {
            base.Channel.DecryptRailDenceBMP(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task DecryptRailDenceBMPAsync(string loadPath, string savePath) {
            return base.Channel.DecryptRailDenceBMPAsync(loadPath, savePath);
        }
        
        public void EncryptPCBCBMP(string loadPath, string savePath) {
            base.Channel.EncryptPCBCBMP(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task EncryptPCBCBMPAsync(string loadPath, string savePath) {
            return base.Channel.EncryptPCBCBMPAsync(loadPath, savePath);
        }
        
        public void DecryptPCBCBMP(string loadPath, string savePath) {
            base.Channel.DecryptPCBCBMP(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task DecryptPCBCBMPAsync(string loadPath, string savePath) {
            return base.Channel.DecryptPCBCBMPAsync(loadPath, savePath);
        }
        
        public bool Md5hash(string loadPath, string savePath) {
            return base.Channel.Md5hash(loadPath, savePath);
        }
        
        public System.Threading.Tasks.Task<bool> Md5hashAsync(string loadPath, string savePath) {
            return base.Channel.Md5hashAsync(loadPath, savePath);
        }
        
        public void EncryptParalelization(string loadPath, string savePath, int numberOfThreads, int rails) {
            base.Channel.EncryptParalelization(loadPath, savePath, numberOfThreads, rails);
        }
        
        public System.Threading.Tasks.Task EncryptParalelizationAsync(string loadPath, string savePath, int numberOfThreads, int rails) {
            return base.Channel.EncryptParalelizationAsync(loadPath, savePath, numberOfThreads, rails);
        }
    }
}