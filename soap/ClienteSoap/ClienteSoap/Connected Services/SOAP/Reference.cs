﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clientesoap.SOAP {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://prueba", ConfigurationName="SOAP.redes")]
    public interface redes {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Rut del espacio de nombres http://prueba no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        clientesoap.SOAP.validarutResponse validarut(clientesoap.SOAP.validarutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<clientesoap.SOAP.validarutResponse> validarutAsync(clientesoap.SOAP.validarutRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Nombres del espacio de nombres http://prueba no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        clientesoap.SOAP.nombrepropioResponse nombrepropio(clientesoap.SOAP.nombrepropioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<clientesoap.SOAP.nombrepropioResponse> nombrepropioAsync(clientesoap.SOAP.nombrepropioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Rut del espacio de nombres http://prueba no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        clientesoap.SOAP.validadigitoResponse validadigito(clientesoap.SOAP.validadigitoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<clientesoap.SOAP.validadigitoResponse> validadigitoAsync(clientesoap.SOAP.validadigitoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarut", Namespace="http://prueba", Order=0)]
        public clientesoap.SOAP.validarutRequestBody Body;
        
        public validarutRequest() {
        }
        
        public validarutRequest(clientesoap.SOAP.validarutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://prueba")]
    public partial class validarutRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Rut;
        
        public validarutRequestBody() {
        }
        
        public validarutRequestBody(string Rut) {
            this.Rut = Rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarutResponse", Namespace="http://prueba", Order=0)]
        public clientesoap.SOAP.validarutResponseBody Body;
        
        public validarutResponse() {
        }
        
        public validarutResponse(clientesoap.SOAP.validarutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://prueba")]
    public partial class validarutResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string validarutReturn;
        
        public validarutResponseBody() {
        }
        
        public validarutResponseBody(string validarutReturn) {
            this.validarutReturn = validarutReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nombrepropioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="nombrepropio", Namespace="http://prueba", Order=0)]
        public clientesoap.SOAP.nombrepropioRequestBody Body;
        
        public nombrepropioRequest() {
        }
        
        public nombrepropioRequest(clientesoap.SOAP.nombrepropioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://prueba")]
    public partial class nombrepropioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Nombres;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Ap_paterno;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Ap_materno;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Genero;
        
        public nombrepropioRequestBody() {
        }
        
        public nombrepropioRequestBody(string Nombres, string Ap_paterno, string Ap_materno, string Genero) {
            this.Nombres = Nombres;
            this.Ap_paterno = Ap_paterno;
            this.Ap_materno = Ap_materno;
            this.Genero = Genero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nombrepropioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="nombrepropioResponse", Namespace="http://prueba", Order=0)]
        public clientesoap.SOAP.nombrepropioResponseBody Body;
        
        public nombrepropioResponse() {
        }
        
        public nombrepropioResponse(clientesoap.SOAP.nombrepropioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://prueba")]
    public partial class nombrepropioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombrepropioReturn;
        
        public nombrepropioResponseBody() {
        }
        
        public nombrepropioResponseBody(string nombrepropioReturn) {
            this.nombrepropioReturn = nombrepropioReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validadigitoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validadigito", Namespace="http://prueba", Order=0)]
        public clientesoap.SOAP.validadigitoRequestBody Body;
        
        public validadigitoRequest() {
        }
        
        public validadigitoRequest(clientesoap.SOAP.validadigitoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://prueba")]
    public partial class validadigitoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Rut;
        
        public validadigitoRequestBody() {
        }
        
        public validadigitoRequestBody(string Rut) {
            this.Rut = Rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validadigitoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validadigitoResponse", Namespace="http://prueba", Order=0)]
        public clientesoap.SOAP.validadigitoResponseBody Body;
        
        public validadigitoResponse() {
        }
        
        public validadigitoResponse(clientesoap.SOAP.validadigitoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://prueba")]
    public partial class validadigitoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string validadigitoReturn;
        
        public validadigitoResponseBody() {
        }
        
        public validadigitoResponseBody(string validadigitoReturn) {
            this.validadigitoReturn = validadigitoReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface redesChannel : clientesoap.SOAP.redes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class redesClient : System.ServiceModel.ClientBase<clientesoap.SOAP.redes>, clientesoap.SOAP.redes {
        
        public redesClient() {
        }
        
        public redesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public redesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public redesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public redesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientesoap.SOAP.validarutResponse clientesoap.SOAP.redes.validarut(clientesoap.SOAP.validarutRequest request) {
            return base.Channel.validarut(request);
        }
        
        public string validarut(string Rut) {
            clientesoap.SOAP.validarutRequest inValue = new clientesoap.SOAP.validarutRequest();
            inValue.Body = new clientesoap.SOAP.validarutRequestBody();
            inValue.Body.Rut = Rut;
            clientesoap.SOAP.validarutResponse retVal = ((clientesoap.SOAP.redes)(this)).validarut(inValue);
            return retVal.Body.validarutReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<clientesoap.SOAP.validarutResponse> clientesoap.SOAP.redes.validarutAsync(clientesoap.SOAP.validarutRequest request) {
            return base.Channel.validarutAsync(request);
        }
        
        public System.Threading.Tasks.Task<clientesoap.SOAP.validarutResponse> validarutAsync(string Rut) {
            clientesoap.SOAP.validarutRequest inValue = new clientesoap.SOAP.validarutRequest();
            inValue.Body = new clientesoap.SOAP.validarutRequestBody();
            inValue.Body.Rut = Rut;
            return ((clientesoap.SOAP.redes)(this)).validarutAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientesoap.SOAP.nombrepropioResponse clientesoap.SOAP.redes.nombrepropio(clientesoap.SOAP.nombrepropioRequest request) {
            return base.Channel.nombrepropio(request);
        }
        
        public string nombrepropio(string Nombres, string Ap_paterno, string Ap_materno, string Genero) {
            clientesoap.SOAP.nombrepropioRequest inValue = new clientesoap.SOAP.nombrepropioRequest();
            inValue.Body = new clientesoap.SOAP.nombrepropioRequestBody();
            inValue.Body.Nombres = Nombres;
            inValue.Body.Ap_paterno = Ap_paterno;
            inValue.Body.Ap_materno = Ap_materno;
            inValue.Body.Genero = Genero;
            clientesoap.SOAP.nombrepropioResponse retVal = ((clientesoap.SOAP.redes)(this)).nombrepropio(inValue);
            return retVal.Body.nombrepropioReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<clientesoap.SOAP.nombrepropioResponse> clientesoap.SOAP.redes.nombrepropioAsync(clientesoap.SOAP.nombrepropioRequest request) {
            return base.Channel.nombrepropioAsync(request);
        }
        
        public System.Threading.Tasks.Task<clientesoap.SOAP.nombrepropioResponse> nombrepropioAsync(string Nombres, string Ap_paterno, string Ap_materno, string Genero) {
            clientesoap.SOAP.nombrepropioRequest inValue = new clientesoap.SOAP.nombrepropioRequest();
            inValue.Body = new clientesoap.SOAP.nombrepropioRequestBody();
            inValue.Body.Nombres = Nombres;
            inValue.Body.Ap_paterno = Ap_paterno;
            inValue.Body.Ap_materno = Ap_materno;
            inValue.Body.Genero = Genero;
            return ((clientesoap.SOAP.redes)(this)).nombrepropioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientesoap.SOAP.validadigitoResponse clientesoap.SOAP.redes.validadigito(clientesoap.SOAP.validadigitoRequest request) {
            return base.Channel.validadigito(request);
        }
        
        public string validadigito(string Rut) {
            clientesoap.SOAP.validadigitoRequest inValue = new clientesoap.SOAP.validadigitoRequest();
            inValue.Body = new clientesoap.SOAP.validadigitoRequestBody();
            inValue.Body.Rut = Rut;
            clientesoap.SOAP.validadigitoResponse retVal = ((clientesoap.SOAP.redes)(this)).validadigito(inValue);
            return retVal.Body.validadigitoReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<clientesoap.SOAP.validadigitoResponse> clientesoap.SOAP.redes.validadigitoAsync(clientesoap.SOAP.validadigitoRequest request) {
            return base.Channel.validadigitoAsync(request);
        }
        
        public System.Threading.Tasks.Task<clientesoap.SOAP.validadigitoResponse> validadigitoAsync(string Rut) {
            clientesoap.SOAP.validadigitoRequest inValue = new clientesoap.SOAP.validadigitoRequest();
            inValue.Body = new clientesoap.SOAP.validadigitoRequestBody();
            inValue.Body.Rut = Rut;
            return ((clientesoap.SOAP.redes)(this)).validadigitoAsync(inValue);
        }
    }
}
