#if UNITY_ANDROID && ! UNITY_EDITOR
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AkPlatformInitSettings : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkPlatformInitSettings(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkPlatformInitSettings obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkPlatformInitSettings() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkUnitySoundEnginePINVOKE.CSharp_delete_AkPlatformInitSettings(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkThreadProperties threadLEngine { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadLEngine_set(swigCPtr, AkThreadProperties.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadLEngine_get(swigCPtr);
      AkThreadProperties ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkThreadProperties(cPtr, false);
      return ret;
    } 
  }

  public AkThreadProperties threadOutputMgr { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadOutputMgr_set(swigCPtr, AkThreadProperties.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadOutputMgr_get(swigCPtr);
      AkThreadProperties ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkThreadProperties(cPtr, false);
      return ret;
    } 
  }

  public AkThreadProperties threadBankManager { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadBankManager_set(swigCPtr, AkThreadProperties.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadBankManager_get(swigCPtr);
      AkThreadProperties ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkThreadProperties(cPtr, false);
      return ret;
    } 
  }

  public AkThreadProperties threadMonitor { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadMonitor_set(swigCPtr, AkThreadProperties.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_threadMonitor_get(swigCPtr);
      AkThreadProperties ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkThreadProperties(cPtr, false);
      return ret;
    } 
  }

  public AkAudioAPI eAudioAPI { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_eAudioAPI_set(swigCPtr, (int)value); }  get { return (AkAudioAPI)AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_eAudioAPI_get(swigCPtr); } 
  }

  public uint uSampleRate { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uSampleRate_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uSampleRate_get(swigCPtr); } 
  }

  public ushort uNumRefillsInVoice { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(swigCPtr); } 
  }

  public bool bRoundFrameSizeToHWSize { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_bRoundFrameSizeToHWSize_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_bRoundFrameSizeToHWSize_get(swigCPtr); } 
  }

  public bool bVerboseSink { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_bVerboseSink_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_bVerboseSink_get(swigCPtr); } 
  }

  public bool bEnableLowLatency { set { AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_bEnableLowLatency_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPlatformInitSettings_bEnableLowLatency_get(swigCPtr); } 
  }

}
#endif // #if UNITY_ANDROID && ! UNITY_EDITOR