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

public class StringArrayElement : Element {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal StringArrayElement(global::System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.StringArrayElement_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StringArrayElement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StringArrayElement() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_StringArrayElement(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static StringArrayElement Cast(Element element) {
    global::System.IntPtr cPtr = SharingClientPINVOKE.StringArrayElement_Cast(Element.getCPtr(element));
    StringArrayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new StringArrayElement(cPtr, true);
    return ret; 
  }

  public virtual int GetCount() {
    int ret = SharingClientPINVOKE.StringArrayElement_GetCount(swigCPtr);
    return ret;
  }

  public virtual XString GetValue(int index) {
    global::System.IntPtr cPtr = SharingClientPINVOKE.StringArrayElement_GetValue(swigCPtr, index);
    XString ret = (cPtr == global::System.IntPtr.Zero) ? null : new XString(cPtr, true);
    return ret; 
  }

  public virtual void SetValue(int index, XString newValue) {
    SharingClientPINVOKE.StringArrayElement_SetValue(swigCPtr, index, XString.getCPtr(newValue));
  }

  public virtual void InsertValue(int index, XString value) {
    SharingClientPINVOKE.StringArrayElement_InsertValue(swigCPtr, index, XString.getCPtr(value));
  }

  public virtual void RemoveValue(int index) {
    SharingClientPINVOKE.StringArrayElement_RemoveValue(swigCPtr, index);
  }

  public virtual void AddListener(StringArrayListener newListener) {
    SharingClientPINVOKE.StringArrayElement_AddListener(swigCPtr, StringArrayListener.getCPtr(newListener));
  }

  public virtual void RemoveListener(StringArrayListener oldListener) {
    SharingClientPINVOKE.StringArrayElement_RemoveListener(swigCPtr, StringArrayListener.getCPtr(oldListener));
  }

}

}
