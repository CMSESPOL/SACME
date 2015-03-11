﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SACME.DirectorioEspol {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://academico.espol.edu.ec/webservices/", ConfigurationName="DirectorioEspol.directorioEspolSoap")]
    public interface directorioEspolSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://academico.espol.edu.ec/webservices/autenticacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool autenticacion(string varUser, string varContrasenia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://academico.espol.edu.ec/webservices/autenticacion", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> autenticacionAsync(string varUser, string varContrasenia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://academico.espol.edu.ec/webservices/busquedaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet busquedaUsuario(string strUnidad, string strRol, string strNombre, string strApellido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://academico.espol.edu.ec/webservices/busquedaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> busquedaUsuarioAsync(string strUnidad, string strRol, string strNombre, string strApellido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://academico.espol.edu.ec/webservices/datosUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet datosUsuario(string varUser, string varContrasenia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://academico.espol.edu.ec/webservices/datosUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> datosUsuarioAsync(string varUser, string varContrasenia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://academico.espol.edu.ec/webservices/consultaUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet consultaUsuario(string varUser, string varContrasenia, string identificacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://academico.espol.edu.ec/webservices/consultaUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> consultaUsuarioAsync(string varUser, string varContrasenia, string identificacion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface directorioEspolSoapChannel : SACME.DirectorioEspol.directorioEspolSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class directorioEspolSoapClient : System.ServiceModel.ClientBase<SACME.DirectorioEspol.directorioEspolSoap>, SACME.DirectorioEspol.directorioEspolSoap {
        
        public directorioEspolSoapClient() {
        }
        
        public directorioEspolSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public directorioEspolSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public directorioEspolSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public directorioEspolSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool autenticacion(string varUser, string varContrasenia) {
            return base.Channel.autenticacion(varUser, varContrasenia);
        }
        
        public System.Threading.Tasks.Task<bool> autenticacionAsync(string varUser, string varContrasenia) {
            return base.Channel.autenticacionAsync(varUser, varContrasenia);
        }
        
        public System.Data.DataSet busquedaUsuario(string strUnidad, string strRol, string strNombre, string strApellido) {
            return base.Channel.busquedaUsuario(strUnidad, strRol, strNombre, strApellido);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> busquedaUsuarioAsync(string strUnidad, string strRol, string strNombre, string strApellido) {
            return base.Channel.busquedaUsuarioAsync(strUnidad, strRol, strNombre, strApellido);
        }
        
        public System.Data.DataSet datosUsuario(string varUser, string varContrasenia) {
            return base.Channel.datosUsuario(varUser, varContrasenia);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> datosUsuarioAsync(string varUser, string varContrasenia) {
            return base.Channel.datosUsuarioAsync(varUser, varContrasenia);
        }
        
        public System.Data.DataSet consultaUsuario(string varUser, string varContrasenia, string identificacion) {
            return base.Channel.consultaUsuario(varUser, varContrasenia, identificacion);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> consultaUsuarioAsync(string varUser, string varContrasenia, string identificacion) {
            return base.Channel.consultaUsuarioAsync(varUser, varContrasenia, identificacion);
        }
    }
}
