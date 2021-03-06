﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMathOperations")]
    public interface IMathOperations {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathOperations/Sum", ReplyAction="http://tempuri.org/IMathOperations/SumResponse")]
        int Sum(WcfFun.Operator input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathOperations/Sum", ReplyAction="http://tempuri.org/IMathOperations/SumResponse")]
        System.Threading.Tasks.Task<int> SumAsync(WcfFun.Operator input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathOperations/Multiply", ReplyAction="http://tempuri.org/IMathOperations/MultiplyResponse")]
        int Multiply(WcfFun.Operator input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathOperations/Multiply", ReplyAction="http://tempuri.org/IMathOperations/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(WcfFun.Operator input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathOperationsChannel : ConsoleApplication1.ServiceReference1.IMathOperations, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathOperationsClient : System.ServiceModel.ClientBase<ConsoleApplication1.ServiceReference1.IMathOperations>, ConsoleApplication1.ServiceReference1.IMathOperations {
        
        public MathOperationsClient() {
        }
        
        public MathOperationsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathOperationsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathOperationsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathOperationsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Sum(WcfFun.Operator input) {
            return base.Channel.Sum(input);
        }
        
        public System.Threading.Tasks.Task<int> SumAsync(WcfFun.Operator input) {
            return base.Channel.SumAsync(input);
        }
        
        public int Multiply(WcfFun.Operator input) {
            return base.Channel.Multiply(input);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(WcfFun.Operator input) {
            return base.Channel.MultiplyAsync(input);
        }
    }
}
