﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWebService.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.mywebserviceSoap")]
    public interface mywebserviceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplication", ReplyAction="*")]
        int Multiplication(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplication", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MultiplicationAsync(int a, int b);
        
        // CODEGEN: Generating message contract since the wrapper name (Adds_x0020_2_x0020_numbers) of message Adds_x0020_2_x0020_numbers does not match the default value (Add)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Adds 2 numbers", ReplyAction="*")]
        TestWebService.ServiceReference1.Adds2numbers1 Add(TestWebService.ServiceReference1.Adds2numbers request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Adds 2 numbers", ReplyAction="*")]
        System.Threading.Tasks.Task<TestWebService.ServiceReference1.Adds2numbers1> AddAsync(TestWebService.ServiceReference1.Adds2numbers request);
        
        // CODEGEN: Generating message contract since the wrapper name (Add) of message AddRequest does not match the default value (Add1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        TestWebService.ServiceReference1.AddResponse Add1(TestWebService.ServiceReference1.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<TestWebService.ServiceReference1.AddResponse> Add1Async(TestWebService.ServiceReference1.AddRequest request);
        
        // CODEGEN: Generating message contract since element name GetCalculationsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalculations", ReplyAction="*")]
        TestWebService.ServiceReference1.GetCalculationsResponse GetCalculations(TestWebService.ServiceReference1.GetCalculationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalculations", ReplyAction="*")]
        System.Threading.Tasks.Task<TestWebService.ServiceReference1.GetCalculationsResponse> GetCalculationsAsync(TestWebService.ServiceReference1.GetCalculationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Adds 2 numbers", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Adds2numbers {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int b;
        
        public Adds2numbers() {
        }
        
        public Adds2numbers(int a, int b) {
            this.a = a;
            this.b = b;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Adds 2 numbersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Adds2numbers1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Adds_x0020_2_x0020_numbersResult", Namespace="http://tempuri.org/", Order=0)]
        public int Adds2numbersResult;
        
        public Adds2numbers1() {
        }
        
        public Adds2numbers1(int Adds2numbersResult) {
            this.Adds2numbersResult = Adds2numbersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Add", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int b;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int c;
        
        public AddRequest() {
        }
        
        public AddRequest(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int AddResult;
        
        public AddResponse() {
        }
        
        public AddResponse(int AddResult) {
            this.AddResult = AddResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculations", Namespace="http://tempuri.org/", Order=0)]
        public TestWebService.ServiceReference1.GetCalculationsRequestBody Body;
        
        public GetCalculationsRequest() {
        }
        
        public GetCalculationsRequest(TestWebService.ServiceReference1.GetCalculationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCalculationsRequestBody {
        
        public GetCalculationsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculationsResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestWebService.ServiceReference1.GetCalculationsResponseBody Body;
        
        public GetCalculationsResponse() {
        }
        
        public GetCalculationsResponse(TestWebService.ServiceReference1.GetCalculationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCalculationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TestWebService.ServiceReference1.ArrayOfString GetCalculationsResult;
        
        public GetCalculationsResponseBody() {
        }
        
        public GetCalculationsResponseBody(TestWebService.ServiceReference1.ArrayOfString GetCalculationsResult) {
            this.GetCalculationsResult = GetCalculationsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface mywebserviceSoapChannel : TestWebService.ServiceReference1.mywebserviceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class mywebserviceSoapClient : System.ServiceModel.ClientBase<TestWebService.ServiceReference1.mywebserviceSoap>, TestWebService.ServiceReference1.mywebserviceSoap {
        
        public mywebserviceSoapClient() {
        }
        
        public mywebserviceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public mywebserviceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public mywebserviceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public mywebserviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Multiplication(int a, int b) {
            return base.Channel.Multiplication(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicationAsync(int a, int b) {
            return base.Channel.MultiplicationAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestWebService.ServiceReference1.Adds2numbers1 TestWebService.ServiceReference1.mywebserviceSoap.Add(TestWebService.ServiceReference1.Adds2numbers request) {
            return base.Channel.Add(request);
        }
        
        public int Add(int a, int b) {
            TestWebService.ServiceReference1.Adds2numbers inValue = new TestWebService.ServiceReference1.Adds2numbers();
            inValue.a = a;
            inValue.b = b;
            TestWebService.ServiceReference1.Adds2numbers1 retVal = ((TestWebService.ServiceReference1.mywebserviceSoap)(this)).Add(inValue);
            return retVal.Adds2numbersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestWebService.ServiceReference1.Adds2numbers1> TestWebService.ServiceReference1.mywebserviceSoap.AddAsync(TestWebService.ServiceReference1.Adds2numbers request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestWebService.ServiceReference1.Adds2numbers1> AddAsync(int a, int b) {
            TestWebService.ServiceReference1.Adds2numbers inValue = new TestWebService.ServiceReference1.Adds2numbers();
            inValue.a = a;
            inValue.b = b;
            return ((TestWebService.ServiceReference1.mywebserviceSoap)(this)).AddAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestWebService.ServiceReference1.AddResponse TestWebService.ServiceReference1.mywebserviceSoap.Add1(TestWebService.ServiceReference1.AddRequest request) {
            return base.Channel.Add1(request);
        }
        
        public int Add1(int a, int b, int c) {
            TestWebService.ServiceReference1.AddRequest inValue = new TestWebService.ServiceReference1.AddRequest();
            inValue.a = a;
            inValue.b = b;
            inValue.c = c;
            TestWebService.ServiceReference1.AddResponse retVal = ((TestWebService.ServiceReference1.mywebserviceSoap)(this)).Add1(inValue);
            return retVal.AddResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestWebService.ServiceReference1.AddResponse> TestWebService.ServiceReference1.mywebserviceSoap.Add1Async(TestWebService.ServiceReference1.AddRequest request) {
            return base.Channel.Add1Async(request);
        }
        
        public System.Threading.Tasks.Task<TestWebService.ServiceReference1.AddResponse> Add1Async(int a, int b, int c) {
            TestWebService.ServiceReference1.AddRequest inValue = new TestWebService.ServiceReference1.AddRequest();
            inValue.a = a;
            inValue.b = b;
            inValue.c = c;
            return ((TestWebService.ServiceReference1.mywebserviceSoap)(this)).Add1Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestWebService.ServiceReference1.GetCalculationsResponse TestWebService.ServiceReference1.mywebserviceSoap.GetCalculations(TestWebService.ServiceReference1.GetCalculationsRequest request) {
            return base.Channel.GetCalculations(request);
        }
        
        public TestWebService.ServiceReference1.ArrayOfString GetCalculations() {
            TestWebService.ServiceReference1.GetCalculationsRequest inValue = new TestWebService.ServiceReference1.GetCalculationsRequest();
            inValue.Body = new TestWebService.ServiceReference1.GetCalculationsRequestBody();
            TestWebService.ServiceReference1.GetCalculationsResponse retVal = ((TestWebService.ServiceReference1.mywebserviceSoap)(this)).GetCalculations(inValue);
            return retVal.Body.GetCalculationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestWebService.ServiceReference1.GetCalculationsResponse> TestWebService.ServiceReference1.mywebserviceSoap.GetCalculationsAsync(TestWebService.ServiceReference1.GetCalculationsRequest request) {
            return base.Channel.GetCalculationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestWebService.ServiceReference1.GetCalculationsResponse> GetCalculationsAsync() {
            TestWebService.ServiceReference1.GetCalculationsRequest inValue = new TestWebService.ServiceReference1.GetCalculationsRequest();
            inValue.Body = new TestWebService.ServiceReference1.GetCalculationsRequestBody();
            return ((TestWebService.ServiceReference1.mywebserviceSoap)(this)).GetCalculationsAsync(inValue);
        }
    }
}