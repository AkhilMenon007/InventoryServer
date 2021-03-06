// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/protobuf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace InventoryService.Protos {

  /// <summary>Holder for reflection information generated from Protos/protobuf.proto</summary>
  public static partial class ProtobufReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/protobuf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtobufReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvcHJvdG9idWYucHJvdG8iLwoLRHJvcHBlZEl0ZW0SEAoIaXRl",
            "bVR5cGUYASABKA0SDgoGYW1vdW50GAIgASgNIiMKDFJlcGx5TWVzc2FnZRIT",
            "CgttZXNzYWdlQ29kZRgBIAEoDSJTChNJdGVtT2J0YWluZWRNZXNzYWdlEiMK",
            "DHJlcGx5TWVzc2FnZRgBIAEoCzINLlJlcGx5TWVzc2FnZRIXCghpdGVtSW5m",
            "bxgCIAEoCzIFLkl0ZW0iOgoNSW52ZW50b3J5SXRlbRIUCgVvd25lchgBIAEo",
            "CzIFLlVzZXISEwoEaXRlbRgCIAEoCzIFLkl0ZW0iLQoESXRlbRIRCglpdGVt",
            "SW5kZXgYASABKA0SEgoKaXRlbUFtb3VudBgCIAEoDSIWCgRVc2VyEg4KBnVz",
            "ZXJJRBgBIAEoDTKiAQoTSW52ZW50b3J5TWFuYWdlbWVudBIpCghEcm9wSXRl",
            "bRIOLkludmVudG9yeUl0ZW0aDS5SZXBseU1lc3NhZ2USLQoHR2V0SXRlbRIM",
            "LkRyb3BwZWRJdGVtGhQuSXRlbU9idGFpbmVkTWVzc2FnZRIxCglUcmFkZUl0",
            "ZW0SDi5JbnZlbnRvcnlJdGVtGhQuSXRlbU9idGFpbmVkTWVzc2FnZUIaqgIX",
            "SW52ZW50b3J5U2VydmljZS5Qcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::InventoryService.Protos.DroppedItem), global::InventoryService.Protos.DroppedItem.Parser, new[]{ "ItemType", "Amount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::InventoryService.Protos.ReplyMessage), global::InventoryService.Protos.ReplyMessage.Parser, new[]{ "MessageCode" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::InventoryService.Protos.ItemObtainedMessage), global::InventoryService.Protos.ItemObtainedMessage.Parser, new[]{ "ReplyMessage", "ItemInfo" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::InventoryService.Protos.InventoryItem), global::InventoryService.Protos.InventoryItem.Parser, new[]{ "Owner", "Item" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::InventoryService.Protos.Item), global::InventoryService.Protos.Item.Parser, new[]{ "ItemIndex", "ItemAmount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::InventoryService.Protos.User), global::InventoryService.Protos.User.Parser, new[]{ "UserID" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DroppedItem : pb::IMessage<DroppedItem> {
    private static readonly pb::MessageParser<DroppedItem> _parser = new pb::MessageParser<DroppedItem>(() => new DroppedItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DroppedItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::InventoryService.Protos.ProtobufReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DroppedItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DroppedItem(DroppedItem other) : this() {
      itemType_ = other.itemType_;
      amount_ = other.amount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DroppedItem Clone() {
      return new DroppedItem(this);
    }

    /// <summary>Field number for the "itemType" field.</summary>
    public const int ItemTypeFieldNumber = 1;
    private uint itemType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ItemType {
      get { return itemType_; }
      set {
        itemType_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private uint amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DroppedItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DroppedItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemType != other.ItemType) return false;
      if (Amount != other.Amount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemType != 0) hash ^= ItemType.GetHashCode();
      if (Amount != 0) hash ^= Amount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemType);
      }
      if (Amount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Amount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemType);
      }
      if (Amount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Amount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DroppedItem other) {
      if (other == null) {
        return;
      }
      if (other.ItemType != 0) {
        ItemType = other.ItemType;
      }
      if (other.Amount != 0) {
        Amount = other.Amount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ItemType = input.ReadUInt32();
            break;
          }
          case 16: {
            Amount = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ReplyMessage : pb::IMessage<ReplyMessage> {
    private static readonly pb::MessageParser<ReplyMessage> _parser = new pb::MessageParser<ReplyMessage>(() => new ReplyMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReplyMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::InventoryService.Protos.ProtobufReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReplyMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReplyMessage(ReplyMessage other) : this() {
      messageCode_ = other.messageCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReplyMessage Clone() {
      return new ReplyMessage(this);
    }

    /// <summary>Field number for the "messageCode" field.</summary>
    public const int MessageCodeFieldNumber = 1;
    private uint messageCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint MessageCode {
      get { return messageCode_; }
      set {
        messageCode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReplyMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReplyMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MessageCode != other.MessageCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MessageCode != 0) hash ^= MessageCode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MessageCode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MessageCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MessageCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MessageCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReplyMessage other) {
      if (other == null) {
        return;
      }
      if (other.MessageCode != 0) {
        MessageCode = other.MessageCode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            MessageCode = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ItemObtainedMessage : pb::IMessage<ItemObtainedMessage> {
    private static readonly pb::MessageParser<ItemObtainedMessage> _parser = new pb::MessageParser<ItemObtainedMessage>(() => new ItemObtainedMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ItemObtainedMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::InventoryService.Protos.ProtobufReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemObtainedMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemObtainedMessage(ItemObtainedMessage other) : this() {
      replyMessage_ = other.replyMessage_ != null ? other.replyMessage_.Clone() : null;
      itemInfo_ = other.itemInfo_ != null ? other.itemInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemObtainedMessage Clone() {
      return new ItemObtainedMessage(this);
    }

    /// <summary>Field number for the "replyMessage" field.</summary>
    public const int ReplyMessageFieldNumber = 1;
    private global::InventoryService.Protos.ReplyMessage replyMessage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::InventoryService.Protos.ReplyMessage ReplyMessage {
      get { return replyMessage_; }
      set {
        replyMessage_ = value;
      }
    }

    /// <summary>Field number for the "itemInfo" field.</summary>
    public const int ItemInfoFieldNumber = 2;
    private global::InventoryService.Protos.Item itemInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::InventoryService.Protos.Item ItemInfo {
      get { return itemInfo_; }
      set {
        itemInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ItemObtainedMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ItemObtainedMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ReplyMessage, other.ReplyMessage)) return false;
      if (!object.Equals(ItemInfo, other.ItemInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (replyMessage_ != null) hash ^= ReplyMessage.GetHashCode();
      if (itemInfo_ != null) hash ^= ItemInfo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (replyMessage_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ReplyMessage);
      }
      if (itemInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ItemInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (replyMessage_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReplyMessage);
      }
      if (itemInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ItemObtainedMessage other) {
      if (other == null) {
        return;
      }
      if (other.replyMessage_ != null) {
        if (replyMessage_ == null) {
          ReplyMessage = new global::InventoryService.Protos.ReplyMessage();
        }
        ReplyMessage.MergeFrom(other.ReplyMessage);
      }
      if (other.itemInfo_ != null) {
        if (itemInfo_ == null) {
          ItemInfo = new global::InventoryService.Protos.Item();
        }
        ItemInfo.MergeFrom(other.ItemInfo);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (replyMessage_ == null) {
              ReplyMessage = new global::InventoryService.Protos.ReplyMessage();
            }
            input.ReadMessage(ReplyMessage);
            break;
          }
          case 18: {
            if (itemInfo_ == null) {
              ItemInfo = new global::InventoryService.Protos.Item();
            }
            input.ReadMessage(ItemInfo);
            break;
          }
        }
      }
    }

  }

  public sealed partial class InventoryItem : pb::IMessage<InventoryItem> {
    private static readonly pb::MessageParser<InventoryItem> _parser = new pb::MessageParser<InventoryItem>(() => new InventoryItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InventoryItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::InventoryService.Protos.ProtobufReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryItem(InventoryItem other) : this() {
      owner_ = other.owner_ != null ? other.owner_.Clone() : null;
      item_ = other.item_ != null ? other.item_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryItem Clone() {
      return new InventoryItem(this);
    }

    /// <summary>Field number for the "owner" field.</summary>
    public const int OwnerFieldNumber = 1;
    private global::InventoryService.Protos.User owner_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::InventoryService.Protos.User Owner {
      get { return owner_; }
      set {
        owner_ = value;
      }
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 2;
    private global::InventoryService.Protos.Item item_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::InventoryService.Protos.Item Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InventoryItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InventoryItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Owner, other.Owner)) return false;
      if (!object.Equals(Item, other.Item)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (owner_ != null) hash ^= Owner.GetHashCode();
      if (item_ != null) hash ^= Item.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (owner_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Owner);
      }
      if (item_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Item);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (owner_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Owner);
      }
      if (item_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InventoryItem other) {
      if (other == null) {
        return;
      }
      if (other.owner_ != null) {
        if (owner_ == null) {
          Owner = new global::InventoryService.Protos.User();
        }
        Owner.MergeFrom(other.Owner);
      }
      if (other.item_ != null) {
        if (item_ == null) {
          Item = new global::InventoryService.Protos.Item();
        }
        Item.MergeFrom(other.Item);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (owner_ == null) {
              Owner = new global::InventoryService.Protos.User();
            }
            input.ReadMessage(Owner);
            break;
          }
          case 18: {
            if (item_ == null) {
              Item = new global::InventoryService.Protos.Item();
            }
            input.ReadMessage(Item);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Item : pb::IMessage<Item> {
    private static readonly pb::MessageParser<Item> _parser = new pb::MessageParser<Item>(() => new Item());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Item> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::InventoryService.Protos.ProtobufReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Item() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Item(Item other) : this() {
      itemIndex_ = other.itemIndex_;
      itemAmount_ = other.itemAmount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Item Clone() {
      return new Item(this);
    }

    /// <summary>Field number for the "itemIndex" field.</summary>
    public const int ItemIndexFieldNumber = 1;
    private uint itemIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ItemIndex {
      get { return itemIndex_; }
      set {
        itemIndex_ = value;
      }
    }

    /// <summary>Field number for the "itemAmount" field.</summary>
    public const int ItemAmountFieldNumber = 2;
    private uint itemAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ItemAmount {
      get { return itemAmount_; }
      set {
        itemAmount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Item);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Item other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemIndex != other.ItemIndex) return false;
      if (ItemAmount != other.ItemAmount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemIndex != 0) hash ^= ItemIndex.GetHashCode();
      if (ItemAmount != 0) hash ^= ItemAmount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemIndex);
      }
      if (ItemAmount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ItemAmount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemIndex);
      }
      if (ItemAmount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemAmount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Item other) {
      if (other == null) {
        return;
      }
      if (other.ItemIndex != 0) {
        ItemIndex = other.ItemIndex;
      }
      if (other.ItemAmount != 0) {
        ItemAmount = other.ItemAmount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ItemIndex = input.ReadUInt32();
            break;
          }
          case 16: {
            ItemAmount = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class User : pb::IMessage<User> {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::InventoryService.Protos.ProtobufReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User(User other) : this() {
      userID_ = other.userID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "userID" field.</summary>
    public const int UserIDFieldNumber = 1;
    private uint userID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UserID {
      get { return userID_; }
      set {
        userID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserID != other.UserID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserID != 0) hash ^= UserID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserID != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UserID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UserID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      if (other.UserID != 0) {
        UserID = other.UserID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            UserID = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
