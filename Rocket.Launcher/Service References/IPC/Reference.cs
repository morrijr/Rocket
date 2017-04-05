﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Rocket.API.Player;
using Rocket.API.Providers.Logging;
using Rocket.Core.Player;

namespace Rocket.Launcher.Service_References.IPC {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPC.IRocketService")]
    public interface IRocketService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/Execute", ReplyAction="http://tempuri.org/IRocketService/ExecuteResponse")]
        void Execute(string command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/Execute", ReplyAction="http://tempuri.org/IRocketService/ExecuteResponse")]
        System.Threading.Tasks.Task ExecuteAsync(string command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/Test", ReplyAction="http://tempuri.org/IRocketService/TestResponse")]
        bool Test();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/Test", ReplyAction="http://tempuri.org/IRocketService/TestResponse")]
        System.Threading.Tasks.Task<bool> TestAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/Disconnect", ReplyAction="http://tempuri.org/IRocketService/DisconnectResponse")]
        void Disconnect(bool shutdown);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/Disconnect", ReplyAction="http://tempuri.org/IRocketService/DisconnectResponse")]
        System.Threading.Tasks.Task DisconnectAsync(bool shutdown);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/OnPlayerConnected", ReplyAction="http://tempuri.org/IRocketService/OnPlayerConnectedResponse")]
        RocketPlayerBase OnPlayerConnected();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/OnPlayerConnected", ReplyAction="http://tempuri.org/IRocketService/OnPlayerConnectedResponse")]
        System.Threading.Tasks.Task<RocketPlayerBase> OnPlayerConnectedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/OnPlayerDisconnected", ReplyAction="http://tempuri.org/IRocketService/OnPlayerDisconnectedResponse")]
        RocketPlayerBase OnPlayerDisconnected();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/OnPlayerDisconnected", ReplyAction="http://tempuri.org/IRocketService/OnPlayerDisconnectedResponse")]
        System.Threading.Tasks.Task<RocketPlayerBase> OnPlayerDisconnectedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/OnShutdown", ReplyAction="http://tempuri.org/IRocketService/OnShutdownResponse")]
        bool OnShutdown();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/OnShutdown", ReplyAction="http://tempuri.org/IRocketService/OnShutdownResponse")]
        System.Threading.Tasks.Task<bool> OnShutdownAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/OnLog", ReplyAction="http://tempuri.org/IRocketService/OnLogResponse")]
        System.Collections.Generic.Queue<LogMessage> OnLog();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRocketService/OnLog", ReplyAction="http://tempuri.org/IRocketService/OnLogResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Queue<LogMessage>> OnLogAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRocketServiceChannel : IRocketService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RocketServiceClient : System.ServiceModel.ClientBase<IRocketService>, IRocketService {
        
        public RocketServiceClient() {
        }
        
        public RocketServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RocketServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RocketServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RocketServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Execute(string command) {
            base.Channel.Execute(command);
        }
        
        public System.Threading.Tasks.Task ExecuteAsync(string command) {
            return base.Channel.ExecuteAsync(command);
        }
        
        public bool Test() {
            return base.Channel.Test();
        }
        
        public System.Threading.Tasks.Task<bool> TestAsync() {
            return base.Channel.TestAsync();
        }
        
        public void Disconnect(bool shutdown) {
            base.Channel.Disconnect(shutdown);
        }
        
        public System.Threading.Tasks.Task DisconnectAsync(bool shutdown) {
            return base.Channel.DisconnectAsync(shutdown);
        }
        
        public RocketPlayerBase OnPlayerConnected() {
            return base.Channel.OnPlayerConnected();
        }
        
        public System.Threading.Tasks.Task<RocketPlayerBase> OnPlayerConnectedAsync() {
            return base.Channel.OnPlayerConnectedAsync();
        }
        
        public RocketPlayerBase OnPlayerDisconnected() {
            return base.Channel.OnPlayerDisconnected();
        }
        
        public System.Threading.Tasks.Task<RocketPlayerBase> OnPlayerDisconnectedAsync() {
            return base.Channel.OnPlayerDisconnectedAsync();
        }
        
        public bool OnShutdown() {
            return base.Channel.OnShutdown();
        }
        
        public System.Threading.Tasks.Task<bool> OnShutdownAsync() {
            return base.Channel.OnShutdownAsync();
        }
        
        public System.Collections.Generic.Queue<LogMessage> OnLog() {
            return base.Channel.OnLog();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Queue<LogMessage>> OnLogAsync() {
            return base.Channel.OnLogAsync();
        }
    }
}
