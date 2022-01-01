// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Loan.proto
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

    /// <summary>Client for LoanProtoService</summary>
    public partial class LoanProtoServiceClient : grpc::ClientBase<LoanProtoServiceClient>
    {
      /// <summary>Creates a new client for LoanProtoService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LoanProtoServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LoanProtoService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LoanProtoServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LoanProtoServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LoanProtoServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::DemoRestTest.Grpc.Protos.LoanModel GetLoan(global::DemoRestTest.Grpc.Protos.GetLoanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLoan(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DemoRestTest.Grpc.Protos.LoanModel GetLoan(global::DemoRestTest.Grpc.Protos.GetLoanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLoan, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.LoanModel> GetLoanAsync(global::DemoRestTest.Grpc.Protos.GetLoanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLoanAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.LoanModel> GetLoanAsync(global::DemoRestTest.Grpc.Protos.GetLoanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLoan, null, options, request);
      }
      public virtual global::DemoRestTest.Grpc.Protos.LoanModel CreateLoan(global::DemoRestTest.Grpc.Protos.CreateLoanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateLoan(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DemoRestTest.Grpc.Protos.LoanModel CreateLoan(global::DemoRestTest.Grpc.Protos.CreateLoanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateLoan, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.LoanModel> CreateLoanAsync(global::DemoRestTest.Grpc.Protos.CreateLoanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateLoanAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.LoanModel> CreateLoanAsync(global::DemoRestTest.Grpc.Protos.CreateLoanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateLoan, null, options, request);
      }
      public virtual global::DemoRestTest.Grpc.Protos.DeleteLoanResponse DeleteLoan(global::DemoRestTest.Grpc.Protos.DeleteLoanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteLoan(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DemoRestTest.Grpc.Protos.DeleteLoanResponse DeleteLoan(global::DemoRestTest.Grpc.Protos.DeleteLoanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteLoan, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.DeleteLoanResponse> DeleteLoanAsync(global::DemoRestTest.Grpc.Protos.DeleteLoanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteLoanAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.DeleteLoanResponse> DeleteLoanAsync(global::DemoRestTest.Grpc.Protos.DeleteLoanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteLoan, null, options, request);
      }
      public virtual global::DemoRestTest.Grpc.Protos.LoanModel UpdateLoan(global::DemoRestTest.Grpc.Protos.UpdateLoanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateLoan(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DemoRestTest.Grpc.Protos.LoanModel UpdateLoan(global::DemoRestTest.Grpc.Protos.UpdateLoanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateLoan, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.LoanModel> UpdateLoanAsync(global::DemoRestTest.Grpc.Protos.UpdateLoanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateLoanAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.LoanModel> UpdateLoanAsync(global::DemoRestTest.Grpc.Protos.UpdateLoanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateLoan, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LoanProtoServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LoanProtoServiceClient(configuration);
      }
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

    /// <summary>Client for ReaderProtoService</summary>
    public partial class ReaderProtoServiceClient : grpc::ClientBase<ReaderProtoServiceClient>
    {
      /// <summary>Creates a new client for ReaderProtoService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReaderProtoServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReaderProtoService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReaderProtoServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReaderProtoServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReaderProtoServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::DemoRestTest.Grpc.Protos.ReaderModel GetReader(global::DemoRestTest.Grpc.Protos.GetReaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReader(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DemoRestTest.Grpc.Protos.ReaderModel GetReader(global::DemoRestTest.Grpc.Protos.GetReaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReader, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.ReaderModel> GetReaderAsync(global::DemoRestTest.Grpc.Protos.GetReaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReaderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.ReaderModel> GetReaderAsync(global::DemoRestTest.Grpc.Protos.GetReaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReader, null, options, request);
      }
      public virtual global::DemoRestTest.Grpc.Protos.ReaderModel CreateReader(global::DemoRestTest.Grpc.Protos.CreateReaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateReader(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DemoRestTest.Grpc.Protos.ReaderModel CreateReader(global::DemoRestTest.Grpc.Protos.CreateReaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateReader, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.ReaderModel> CreateReaderAsync(global::DemoRestTest.Grpc.Protos.CreateReaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateReaderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.ReaderModel> CreateReaderAsync(global::DemoRestTest.Grpc.Protos.CreateReaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateReader, null, options, request);
      }
      public virtual global::DemoRestTest.Grpc.Protos.DeleteReaderResponse DeleteReader(global::DemoRestTest.Grpc.Protos.DeleteReaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteReader(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DemoRestTest.Grpc.Protos.DeleteReaderResponse DeleteReader(global::DemoRestTest.Grpc.Protos.DeleteReaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteReader, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.DeleteReaderResponse> DeleteReaderAsync(global::DemoRestTest.Grpc.Protos.DeleteReaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteReaderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.DeleteReaderResponse> DeleteReaderAsync(global::DemoRestTest.Grpc.Protos.DeleteReaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteReader, null, options, request);
      }
      public virtual global::DemoRestTest.Grpc.Protos.ReaderModel UpdateReader(global::DemoRestTest.Grpc.Protos.UpdateReaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateReader(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DemoRestTest.Grpc.Protos.ReaderModel UpdateReader(global::DemoRestTest.Grpc.Protos.UpdateReaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateReader, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.ReaderModel> UpdateReaderAsync(global::DemoRestTest.Grpc.Protos.UpdateReaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateReaderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DemoRestTest.Grpc.Protos.ReaderModel> UpdateReaderAsync(global::DemoRestTest.Grpc.Protos.UpdateReaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateReader, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ReaderProtoServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReaderProtoServiceClient(configuration);
      }
    }

  }
}
#endregion
