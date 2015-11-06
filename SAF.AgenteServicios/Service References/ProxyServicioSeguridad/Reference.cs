﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAF.AgenteServicios.ProxyServicioSeguridad {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyServicioSeguridad.ISeguridadLogic")]
    public interface ISeguridadLogic {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridadLogic/AccederSistemaExtranet", ReplyAction="http://tempuri.org/ISeguridadLogic/AccederSistemaExtranetResponse")]
        bool AccederSistemaExtranet(string usuario, string password, int tipoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridadLogic/AccederSistemaExtranet", ReplyAction="http://tempuri.org/ISeguridadLogic/AccederSistemaExtranetResponse")]
        System.Threading.Tasks.Task<bool> AccederSistemaExtranetAsync(string usuario, string password, int tipoUsuario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISeguridadLogicChannel : SAF.AgenteServicios.ProxyServicioSeguridad.ISeguridadLogic, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SeguridadLogicClient : System.ServiceModel.ClientBase<SAF.AgenteServicios.ProxyServicioSeguridad.ISeguridadLogic>, SAF.AgenteServicios.ProxyServicioSeguridad.ISeguridadLogic {
        
        public SeguridadLogicClient() {
        }
        
        public SeguridadLogicClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SeguridadLogicClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeguridadLogicClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeguridadLogicClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AccederSistemaExtranet(string usuario, string password, int tipoUsuario) {
            return base.Channel.AccederSistemaExtranet(usuario, password, tipoUsuario);
        }
        
        public System.Threading.Tasks.Task<bool> AccederSistemaExtranetAsync(string usuario, string password, int tipoUsuario) {
            return base.Channel.AccederSistemaExtranetAsync(usuario, password, tipoUsuario);
        }
    }
}
