// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Loan.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DemoRestTest.Grpc.Protos {
  public static partial class LoanProtoService
  {
    static readonly string __ServiceName = "LoanProtoService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.GetLoanRequest> __Marshaller_GetLoanRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.GetLoanRequest.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.LoanModel> __Marshaller_LoanModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.LoanModel.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.CreateLoanRequest> __Marshaller_CreateLoanRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.CreateLoanRequest.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.DeleteLoanRequest> __Marshaller_DeleteLoanRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.DeleteLoanRequest.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.DeleteLoanResponse> __Marshaller_DeleteLoanResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.DeleteLoanResponse.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.UpdateLoanRequest> __Marshaller_UpdateLoanRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.UpdateLoanRequest.Parser));

    static readonly grpc::Method<global::DemoRestTest.Grpc.Protos.GetLoanRequest, global::DemoRestTest.Grpc.Protos.LoanModel> __Method_GetLoan = new grpc::Method<global::DemoRestTest.Grpc.Protos.GetLoanRequest, global::DemoRestTest.Grpc.Protos.LoanModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLoan",
        __Marshaller_GetLoanRequest,
        __Marshaller_LoanModel);

    static readonly grpc::Method<global::DemoRestTest.Grpc.Protos.CreateLoanRequest, global::DemoRestTest.Grpc.Protos.LoanModel> __Method_CreateLoan = new grpc::Method<global::DemoRestTest.Grpc.Protos.CreateLoanRequest, global::DemoRestTest.Grpc.Protos.LoanModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateLoan",
        __Marshaller_CreateLoanRequest,
        __Marshaller_LoanModel);

    static readonly grpc::Method<global::DemoRestTest.Grpc.Protos.DeleteLoanRequest, global::DemoRestTest.Grpc.Protos.DeleteLoanResponse> __Method_DeleteLoan = new grpc::Method<global::DemoRestTest.Grpc.Protos.DeleteLoanRequest, global::DemoRestTest.Grpc.Protos.DeleteLoanResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteLoan",
        __Marshaller_DeleteLoanRequest,
        __Marshaller_DeleteLoanResponse);

    static readonly grpc::Method<global::DemoRestTest.Grpc.Protos.UpdateLoanRequest, global::DemoRestTest.Grpc.Protos.LoanModel> __Method_UpdateLoan = new grpc::Method<global::DemoRestTest.Grpc.Protos.UpdateLoanRequest, global::DemoRestTest.Grpc.Protos.LoanModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateLoan",
        __Marshaller_UpdateLoanRequest,
        __Marshaller_LoanModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DemoRestTest.Grpc.Protos.LoanReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LoanProtoService</summary>
    [grpc::BindServiceMethod(typeof(LoanProtoService), "BindService")]
    public abstract partial class LoanProtoServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::DemoRestTest.Grpc.Protos.LoanModel> GetLoan(global::DemoRestTest.Grpc.Protos.GetLoanRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DemoRestTest.Grpc.Protos.LoanModel> CreateLoan(global::DemoRestTest.Grpc.Protos.CreateLoanRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DemoRestTest.Grpc.Protos.DeleteLoanResponse> DeleteLoan(global::DemoRestTest.Grpc.Protos.DeleteLoanRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DemoRestTest.Grpc.Protos.LoanModel> UpdateLoan(global::DemoRestTest.Grpc.Protos.UpdateLoanRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LoanProtoServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetLoan, serviceImpl.GetLoan)
          .AddMethod(__Method_CreateLoan, serviceImpl.CreateLoan)
          .AddMethod(__Method_DeleteLoan, serviceImpl.DeleteLoan)
          .AddMethod(__Method_UpdateLoan, serviceImpl.UpdateLoan).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LoanProtoServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetLoan, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DemoRestTest.Grpc.Protos.GetLoanRequest, global::DemoRestTest.Grpc.Protos.LoanModel>(serviceImpl.GetLoan));
      serviceBinder.AddMethod(__Method_CreateLoan, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DemoRestTest.Grpc.Protos.CreateLoanRequest, global::DemoRestTest.Grpc.Protos.LoanModel>(serviceImpl.CreateLoan));
      serviceBinder.AddMethod(__Method_DeleteLoan, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DemoRestTest.Grpc.Protos.DeleteLoanRequest, global::DemoRestTest.Grpc.Protos.DeleteLoanResponse>(serviceImpl.DeleteLoan));
      serviceBinder.AddMethod(__Method_UpdateLoan, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DemoRestTest.Grpc.Protos.UpdateLoanRequest, global::DemoRestTest.Grpc.Protos.LoanModel>(serviceImpl.UpdateLoan));
    }

  }
  public static partial class ReaderProtoService
  {
    static readonly string __ServiceName = "ReaderProtoService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.GetReaderRequest> __Marshaller_GetReaderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.GetReaderRequest.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.ReaderModel> __Marshaller_ReaderModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.ReaderModel.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.CreateReaderRequest> __Marshaller_CreateReaderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.CreateReaderRequest.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.DeleteReaderRequest> __Marshaller_DeleteReaderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.DeleteReaderRequest.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.DeleteReaderResponse> __Marshaller_DeleteReaderResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.DeleteReaderResponse.Parser));
    static readonly grpc::Marshaller<global::DemoRestTest.Grpc.Protos.UpdateReaderRequest> __Marshaller_UpdateReaderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DemoRestTest.Grpc.Protos.UpdateReaderRequest.Parser));

    static readonly grpc::Method<global::DemoRestTest.Grpc.Protos.GetReaderRequest, global::DemoRestTest.Grpc.Protos.ReaderModel> __Method_GetReader = new grpc::Method<global::DemoRestTest.Grpc.Protos.GetReaderRequest, global::DemoRestTest.Grpc.Protos.ReaderModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetReader",
        __Marshaller_GetReaderRequest,
        __Marshaller_ReaderModel);

    static readonly grpc::Method<global::DemoRestTest.Grpc.Protos.CreateReaderRequest, global::DemoRestTest.Grpc.Protos.ReaderModel> __Method_CreateReader = new grpc::Method<global::DemoRestTest.Grpc.Protos.CreateReaderRequest, global::DemoRestTest.Grpc.Protos.ReaderModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateReader",
        __Marshaller_CreateReaderRequest,
        __Marshaller_ReaderModel);

    static readonly grpc::Method<global::DemoRestTest.Grpc.Protos.DeleteReaderRequest, global::DemoRestTest.Grpc.Protos.DeleteReaderResponse> __Method_DeleteReader = new grpc::Method<global::DemoRestTest.Grpc.Protos.DeleteReaderRequest, global::DemoRestTest.Grpc.Protos.DeleteReaderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteReader",
        __Marshaller_DeleteReaderRequest,
        __Marshaller_DeleteReaderResponse);

    static readonly grpc::Method<global::DemoRestTest.Grpc.Protos.UpdateReaderRequest, global::DemoRestTest.Grpc.Protos.ReaderModel> __Method_UpdateReader = new grpc::Method<global::DemoRestTest.Grpc.Protos.UpdateReaderRequest, global::DemoRestTest.Grpc.Protos.ReaderModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateReader",
        __Marshaller_UpdateReaderRequest,
        __Marshaller_ReaderModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DemoRestTest.Grpc.Protos.LoanReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of ReaderProtoService</summary>
    [grpc::BindServiceMethod(typeof(ReaderProtoService), "BindService")]
    public abstract partial class ReaderProtoServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::DemoRestTest.Grpc.Protos.ReaderModel> GetReader(global::DemoRestTest.Grpc.Protos.GetReaderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DemoRestTest.Grpc.Protos.ReaderModel> CreateReader(global::DemoRestTest.Grpc.Protos.CreateReaderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DemoRestTest.Grpc.Protos.DeleteReaderResponse> DeleteReader(global::DemoRestTest.Grpc.Protos.DeleteReaderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DemoRestTest.Grpc.Protos.ReaderModel> UpdateReader(global::DemoRestTest.Grpc.Protos.UpdateReaderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ReaderProtoServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetReader, serviceImpl.GetReader)
          .AddMethod(__Method_CreateReader, serviceImpl.CreateReader)
          .AddMethod(__Method_DeleteReader, serviceImpl.DeleteReader)
          .AddMethod(__Method_UpdateReader, serviceImpl.UpdateReader).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ReaderProtoServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetReader, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DemoRestTest.Grpc.Protos.GetReaderRequest, global::DemoRestTest.Grpc.Protos.ReaderModel>(serviceImpl.GetReader));
      serviceBinder.AddMethod(__Method_CreateReader, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DemoRestTest.Grpc.Protos.CreateReaderRequest, global::DemoRestTest.Grpc.Protos.ReaderModel>(serviceImpl.CreateReader));
      serviceBinder.AddMethod(__Method_DeleteReader, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DemoRestTest.Grpc.Protos.DeleteReaderRequest, global::DemoRestTest.Grpc.Protos.DeleteReaderResponse>(serviceImpl.DeleteReader));
      serviceBinder.AddMethod(__Method_UpdateReader, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DemoRestTest.Grpc.Protos.UpdateReaderRequest, global::DemoRestTest.Grpc.Protos.ReaderModel>(serviceImpl.UpdateReader));
    }

  }
}
#endregion
