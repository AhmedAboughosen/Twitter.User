// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/send_email.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Infrastructure.Services.Grpc.Protos.SendEmail {

  /// <summary>Holder for reflection information generated from Protos/send_email.proto</summary>
  public static partial class SendEmailReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/send_email.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SendEmailReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90b3Mvc2VuZF9lbWFpbC5wcm90bxISdHdpdHRlci5zZW5kX2VtYWls",
            "Gh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aG2dvb2dsZS9wcm90",
            "b2J1Zi9lbXB0eS5wcm90byIHCgVFbXB0eSKdAQoTRW1haWxNZXNzYWdlUmVx",
            "dWVzdBIoCgJ0bxgBIAMoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1",
            "ZRItCgdzdWJqZWN0GAIgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1Zh",
            "bHVlEi0KB2NvbnRlbnQYAyABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5n",
            "VmFsdWUyXgoLRW1haWxTZW5kZXISTwoJU2VuZEVtYWlsEicudHdpdHRlci5z",
            "ZW5kX2VtYWlsLkVtYWlsTWVzc2FnZVJlcXVlc3QaGS50d2l0dGVyLnNlbmRf",
            "ZW1haWwuRW1wdHlCMKoCLUluZnJhc3RydWN0dXJlLlNlcnZpY2VzLkdycGMu",
            "UHJvdG9zLlNlbmRFbWFpbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Infrastructure.Services.Grpc.Protos.SendEmail.Empty), global::Infrastructure.Services.Grpc.Protos.SendEmail.Empty.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Infrastructure.Services.Grpc.Protos.SendEmail.EmailMessageRequest), global::Infrastructure.Services.Grpc.Protos.SendEmail.EmailMessageRequest.Parser, new[]{ "To", "Subject", "Content" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Empty : pb::IMessage<Empty>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Empty> _parser = new pb::MessageParser<Empty>(() => new Empty());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Empty> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Infrastructure.Services.Grpc.Protos.SendEmail.SendEmailReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Empty() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Empty(Empty other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Empty Clone() {
      return new Empty(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Empty);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Empty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Empty other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  public sealed partial class EmailMessageRequest : pb::IMessage<EmailMessageRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EmailMessageRequest> _parser = new pb::MessageParser<EmailMessageRequest>(() => new EmailMessageRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EmailMessageRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Infrastructure.Services.Grpc.Protos.SendEmail.SendEmailReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EmailMessageRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EmailMessageRequest(EmailMessageRequest other) : this() {
      to_ = other.to_.Clone();
      Subject = other.Subject;
      Content = other.Content;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EmailMessageRequest Clone() {
      return new EmailMessageRequest(this);
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_to_codec
        = pb::FieldCodec.ForClassWrapper<string>(10);
    private readonly pbc::RepeatedField<string> to_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> To {
      get { return to_; }
    }

    /// <summary>Field number for the "subject" field.</summary>
    public const int SubjectFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_subject_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string subject_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Subject {
      get { return subject_; }
      set {
        subject_ = value;
      }
    }


    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_content_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string content_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Content {
      get { return content_; }
      set {
        content_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EmailMessageRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EmailMessageRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!to_.Equals(other.to_)) return false;
      if (Subject != other.Subject) return false;
      if (Content != other.Content) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= to_.GetHashCode();
      if (subject_ != null) hash ^= Subject.GetHashCode();
      if (content_ != null) hash ^= Content.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      to_.WriteTo(output, _repeated_to_codec);
      if (subject_ != null) {
        _single_subject_codec.WriteTagAndValue(output, Subject);
      }
      if (content_ != null) {
        _single_content_codec.WriteTagAndValue(output, Content);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      to_.WriteTo(ref output, _repeated_to_codec);
      if (subject_ != null) {
        _single_subject_codec.WriteTagAndValue(ref output, Subject);
      }
      if (content_ != null) {
        _single_content_codec.WriteTagAndValue(ref output, Content);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += to_.CalculateSize(_repeated_to_codec);
      if (subject_ != null) {
        size += _single_subject_codec.CalculateSizeWithTag(Subject);
      }
      if (content_ != null) {
        size += _single_content_codec.CalculateSizeWithTag(Content);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EmailMessageRequest other) {
      if (other == null) {
        return;
      }
      to_.Add(other.to_);
      if (other.subject_ != null) {
        if (subject_ == null || other.Subject != "") {
          Subject = other.Subject;
        }
      }
      if (other.content_ != null) {
        if (content_ == null || other.Content != "") {
          Content = other.Content;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            to_.AddEntriesFrom(input, _repeated_to_codec);
            break;
          }
          case 18: {
            string value = _single_subject_codec.Read(input);
            if (subject_ == null || value != "") {
              Subject = value;
            }
            break;
          }
          case 26: {
            string value = _single_content_codec.Read(input);
            if (content_ == null || value != "") {
              Content = value;
            }
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            to_.AddEntriesFrom(ref input, _repeated_to_codec);
            break;
          }
          case 18: {
            string value = _single_subject_codec.Read(ref input);
            if (subject_ == null || value != "") {
              Subject = value;
            }
            break;
          }
          case 26: {
            string value = _single_content_codec.Read(ref input);
            if (content_ == null || value != "") {
              Content = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code