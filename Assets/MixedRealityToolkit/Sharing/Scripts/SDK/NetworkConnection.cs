//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace MixedRealityToolkit.Sharing {

public class NetworkConnection : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NetworkConnection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NetworkConnection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NetworkConnection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_NetworkConnection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool IsConnected() {
    bool ret = SharingClientPINVOKE.NetworkConnection_IsConnected(swigCPtr);
    return ret;
  }

  public virtual ulong GetConnectionGUID() {
    ulong ret = SharingClientPINVOKE.NetworkConnection_GetConnectionGUID(swigCPtr);
    return ret;
  }

  public virtual void Send(NetworkOutMessage msg, MessagePriority priority, MessageReliability reliability, MessageChannel channel, bool releaseMessage) {
    SharingClientPINVOKE.NetworkConnection_Send__SWIG_0(swigCPtr, NetworkOutMessage.getCPtr(msg), (int)priority, (int)reliability, (int)channel, releaseMessage);
  }

  public virtual void Send(NetworkOutMessage msg, MessagePriority priority, MessageReliability reliability, MessageChannel channel) {
    SharingClientPINVOKE.NetworkConnection_Send__SWIG_1(swigCPtr, NetworkOutMessage.getCPtr(msg), (int)priority, (int)reliability, (int)channel);
  }

  public virtual void Send(NetworkOutMessage msg, MessagePriority priority, MessageReliability reliability) {
    SharingClientPINVOKE.NetworkConnection_Send__SWIG_2(swigCPtr, NetworkOutMessage.getCPtr(msg), (int)priority, (int)reliability);
  }

  public virtual void Send(NetworkOutMessage msg, MessagePriority priority) {
    SharingClientPINVOKE.NetworkConnection_Send__SWIG_3(swigCPtr, NetworkOutMessage.getCPtr(msg), (int)priority);
  }

  public virtual void Send(NetworkOutMessage msg) {
    SharingClientPINVOKE.NetworkConnection_Send__SWIG_4(swigCPtr, NetworkOutMessage.getCPtr(msg));
  }

  public virtual void SendTo(User user, ClientRole deviceRole, NetworkOutMessage msg, MessagePriority priority, MessageReliability reliability, MessageChannel channel, bool releaseMessage) {
    SharingClientPINVOKE.NetworkConnection_SendTo__SWIG_0(swigCPtr, User.getCPtr(user), (int)deviceRole, NetworkOutMessage.getCPtr(msg), (int)priority, (int)reliability, (int)channel, releaseMessage);
  }

  public virtual void SendTo(User user, ClientRole deviceRole, NetworkOutMessage msg, MessagePriority priority, MessageReliability reliability, MessageChannel channel) {
    SharingClientPINVOKE.NetworkConnection_SendTo__SWIG_1(swigCPtr, User.getCPtr(user), (int)deviceRole, NetworkOutMessage.getCPtr(msg), (int)priority, (int)reliability, (int)channel);
  }

  public virtual void SendTo(User user, ClientRole deviceRole, NetworkOutMessage msg, MessagePriority priority, MessageReliability reliability) {
    SharingClientPINVOKE.NetworkConnection_SendTo__SWIG_2(swigCPtr, User.getCPtr(user), (int)deviceRole, NetworkOutMessage.getCPtr(msg), (int)priority, (int)reliability);
  }

  public virtual void SendTo(User user, ClientRole deviceRole, NetworkOutMessage msg, MessagePriority priority) {
    SharingClientPINVOKE.NetworkConnection_SendTo__SWIG_3(swigCPtr, User.getCPtr(user), (int)deviceRole, NetworkOutMessage.getCPtr(msg), (int)priority);
  }

  public virtual void SendTo(User user, ClientRole deviceRole, NetworkOutMessage msg) {
    SharingClientPINVOKE.NetworkConnection_SendTo__SWIG_4(swigCPtr, User.getCPtr(user), (int)deviceRole, NetworkOutMessage.getCPtr(msg));
  }

  public virtual void Broadcast(NetworkOutMessage msg, MessagePriority priority, MessageReliability reliability, MessageChannel channel, bool releaseMessage) {
    SharingClientPINVOKE.NetworkConnection_Broadcast__SWIG_0(swigCPtr, NetworkOutMessage.getCPtr(msg), (int)priority, (int)reliability, (int)channel, releaseMessage);
  }

  public virtual void Broadcast(NetworkOutMessage msg, MessagePriority priority, MessageReliability reliability, MessageChannel channel) {
    SharingClientPINVOKE.NetworkConnection_Broadcast__SWIG_1(swigCPtr, NetworkOutMessage.getCPtr(msg), (int)priority, (int)reliability, (int)channel);
  }

  public virtual void Broadcast(NetworkOutMessage msg, MessagePriority priority, MessageReliability reliability) {
    SharingClientPINVOKE.NetworkConnection_Broadcast__SWIG_2(swigCPtr, NetworkOutMessage.getCPtr(msg), (int)priority, (int)reliability);
  }

  public virtual void Broadcast(NetworkOutMessage msg, MessagePriority priority) {
    SharingClientPINVOKE.NetworkConnection_Broadcast__SWIG_3(swigCPtr, NetworkOutMessage.getCPtr(msg), (int)priority);
  }

  public virtual void Broadcast(NetworkOutMessage msg) {
    SharingClientPINVOKE.NetworkConnection_Broadcast__SWIG_4(swigCPtr, NetworkOutMessage.getCPtr(msg));
  }

  public virtual void AddListener(byte messageType, NetworkConnectionListener newListener) {
    SharingClientPINVOKE.NetworkConnection_AddListener(swigCPtr, messageType, NetworkConnectionListener.getCPtr(newListener));
  }

  public virtual void RemoveListener(byte messageType, NetworkConnectionListener oldListener) {
    SharingClientPINVOKE.NetworkConnection_RemoveListener(swigCPtr, messageType, NetworkConnectionListener.getCPtr(oldListener));
  }

  public virtual void AddListenerAsync(byte messageType, NetworkConnectionListener newListener) {
    SharingClientPINVOKE.NetworkConnection_AddListenerAsync(swigCPtr, messageType, NetworkConnectionListener.getCPtr(newListener));
  }

  public virtual void RemoveListenerAsync(byte messageType, NetworkConnectionListener oldListener) {
    SharingClientPINVOKE.NetworkConnection_RemoveListenerAsync(swigCPtr, messageType, NetworkConnectionListener.getCPtr(oldListener));
  }

  public virtual NetworkOutMessage CreateMessage(byte messageType) {
    global::System.IntPtr cPtr = SharingClientPINVOKE.NetworkConnection_CreateMessage(swigCPtr, messageType);
    NetworkOutMessage ret = (cPtr == global::System.IntPtr.Zero) ? null : new NetworkOutMessage(cPtr, true);
    return ret; 
  }

  public virtual void ReturnMessage(NetworkOutMessage msg) {
    SharingClientPINVOKE.NetworkConnection_ReturnMessage(swigCPtr, NetworkOutMessage.getCPtr(msg));
  }

  public virtual void Disconnect() {
    SharingClientPINVOKE.NetworkConnection_Disconnect(swigCPtr);
  }

  public virtual XString GetRemoteAddress() {
    global::System.IntPtr cPtr = SharingClientPINVOKE.NetworkConnection_GetRemoteAddress(swigCPtr);
    XString ret = (cPtr == global::System.IntPtr.Zero) ? null : new XString(cPtr, true);
    return ret; 
  }

}

}
