﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCMathService.MathMVCService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathMVCService.ICulcService")]
    public interface ICulcService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICulcService/Add", ReplyAction="http://tempuri.org/ICulcService/AddResponse")]
        int Add(int param1, int param2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICulcService/Add", ReplyAction="http://tempuri.org/ICulcService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int param1, int param2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICulcService/Subtract", ReplyAction="http://tempuri.org/ICulcService/SubtractResponse")]
        int Subtract(int param1, int param2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICulcService/Subtract", ReplyAction="http://tempuri.org/ICulcService/SubtractResponse")]
        System.Threading.Tasks.Task<int> SubtractAsync(int param1, int param2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICulcService/Multiply", ReplyAction="http://tempuri.org/ICulcService/MultiplyResponse")]
        int Multiply(int param1, int param2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICulcService/Multiply", ReplyAction="http://tempuri.org/ICulcService/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int param1, int param2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICulcService/Divide", ReplyAction="http://tempuri.org/ICulcService/DivideResponse")]
        int Divide(int param1, int param2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICulcService/Divide", ReplyAction="http://tempuri.org/ICulcService/DivideResponse")]
        System.Threading.Tasks.Task<int> DivideAsync(int param1, int param2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICulcServiceChannel : MVCMathService.MathMVCService.ICulcService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CulcServiceClient : System.ServiceModel.ClientBase<MVCMathService.MathMVCService.ICulcService>, MVCMathService.MathMVCService.ICulcService {
        
        public CulcServiceClient() {
        }
        
        public CulcServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CulcServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CulcServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CulcServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int param1, int param2) {
            return base.Channel.Add(param1, param2);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int param1, int param2) {
            return base.Channel.AddAsync(param1, param2);
        }
        
        public int Subtract(int param1, int param2) {
            return base.Channel.Subtract(param1, param2);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int param1, int param2) {
            return base.Channel.SubtractAsync(param1, param2);
        }
        
        public int Multiply(int param1, int param2) {
            return base.Channel.Multiply(param1, param2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int param1, int param2) {
            return base.Channel.MultiplyAsync(param1, param2);
        }
        
        public int Divide(int param1, int param2) {
            return base.Channel.Divide(param1, param2);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int param1, int param2) {
            return base.Channel.DivideAsync(param1, param2);
        }
    }
}
