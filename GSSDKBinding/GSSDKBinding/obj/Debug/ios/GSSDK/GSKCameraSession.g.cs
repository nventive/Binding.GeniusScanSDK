//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace GSSDK {
	[Register("GSKCameraSession", true)]
	public unsafe partial class GSKCameraSession : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GSKCameraSession");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GSKCameraSession () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected GSKCameraSession (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKCameraSession (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithScanFactory:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public GSKCameraSession (GSKScanFactoryProtocol scanFactory)
			: base (NSObjectFlag.Empty)
		{
			if (scanFactory == null)
				throw new ArgumentNullException ("scanFactory");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithScanFactory:"), scanFactory.Handle), "initWithScanFactory:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithScanFactory:"), scanFactory.Handle), "initWithScanFactory:");
			}
		}
		
		[Export ("cleanup")]
		[CompilerGenerated]
		public virtual void Cleanup ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cleanup"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cleanup"));
			}
		}
		
		[Export ("focusAtPoint:")]
		[CompilerGenerated]
		public virtual void FocusAtPoint (global::System.IntPtr focusPoint)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("focusAtPoint:"), focusPoint);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("focusAtPoint:"), focusPoint);
			}
		}
		
		[Export ("setFlashStatus:onSuccess:error:")]
		[CompilerGenerated]
		public unsafe virtual void SetFlashStatus (GSKCameraSessionFlashStatus flashStatus, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<GSKCameraSessionFlashStatus> successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> errorBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDActionArity1V0.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDActionArity1V1.Handler, errorBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_int_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setFlashStatus:onSuccess:error:"), (int)flashStatus, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setFlashStatus:onSuccess:error:"), (int)flashStatus, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			}
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("setup")]
		[CompilerGenerated]
		public virtual void Setup ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setup"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setup"));
			}
		}
		
		[Export ("startSessionOnComplete:")]
		[CompilerGenerated]
		public unsafe virtual void StartSessionOnComplete ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGSKCameraVoidBlock))]GSKCameraVoidBlock onComplete)
		{
			if (onComplete == null)
				throw new ArgumentNullException ("onComplete");
			BlockLiteral *block_ptr_onComplete;
			BlockLiteral block_onComplete;
			block_onComplete = new BlockLiteral ();
			block_ptr_onComplete = &block_onComplete;
			block_onComplete.SetupBlock (Trampolines.SDGSKCameraVoidBlock.Handler, onComplete);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startSessionOnComplete:"), (IntPtr) block_ptr_onComplete);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startSessionOnComplete:"), (IntPtr) block_ptr_onComplete);
			}
			block_ptr_onComplete->CleanupBlock ();
			
		}
		
		[Export ("stopSessionOnComplete:")]
		[CompilerGenerated]
		public unsafe virtual void StopSessionOnComplete ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGSKCameraVoidBlock))]GSKCameraVoidBlock onComplete)
		{
			if (onComplete == null)
				throw new ArgumentNullException ("onComplete");
			BlockLiteral *block_ptr_onComplete;
			BlockLiteral block_onComplete;
			block_onComplete = new BlockLiteral ();
			block_ptr_onComplete = &block_onComplete;
			block_onComplete.SetupBlock (Trampolines.SDGSKCameraVoidBlock.Handler, onComplete);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stopSessionOnComplete:"), (IntPtr) block_ptr_onComplete);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stopSessionOnComplete:"), (IntPtr) block_ptr_onComplete);
			}
			block_ptr_onComplete->CleanupBlock ();
			
		}
		
		[Export ("takePhoto")]
		[CompilerGenerated]
		public virtual void TakePhoto ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("takePhoto"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("takePhoto"));
			}
		}
		
		[CompilerGenerated]
		public virtual bool AutoTriggerEnabled {
			[Export ("isAutoTriggerEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAutoTriggerEnabled"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAutoTriggerEnabled"));
				}
			}
			
			[Export ("setAutoTriggerEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoTriggerEnabled:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutoTriggerEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::AVFoundation.AVCaptureConnection CaptureConnection {
			[Export ("captureConnection")]
			get {
				global::AVFoundation.AVCaptureConnection ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureConnection> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("captureConnection")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureConnection> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("captureConnection")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::AVFoundation.AVCaptureDevice CaptureDevice {
			[Export ("captureDevice")]
			get {
				global::AVFoundation.AVCaptureDevice ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureDevice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("captureDevice")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureDevice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("captureDevice")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::AVFoundation.AVCaptureDeviceInput CaptureInput {
			[Export ("captureInput")]
			get {
				global::AVFoundation.AVCaptureDeviceInput ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureDeviceInput> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("captureInput")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureDeviceInput> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("captureInput")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::AVFoundation.AVCaptureSession CaptureSession {
			[Export ("captureSession")]
			get {
				global::AVFoundation.AVCaptureSession ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureSession> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("captureSession")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureSession> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("captureSession")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::AVFoundation.AVCaptureStillImageOutput CaptureStillImageOutput {
			[Export ("captureStillImageOutput")]
			get {
				global::AVFoundation.AVCaptureStillImageOutput ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureStillImageOutput> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("captureStillImageOutput")));
				} else {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVCaptureStillImageOutput> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("captureStillImageOutput")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public GSKCameraSessionDelegate Delegate {
			get {
				return WeakDelegate as GSKCameraSessionDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool TakingPhoto {
			[Export ("isTakingPhoto")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTakingPhoto"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isTakingPhoto"));
				}
			}
			
			[Export ("setTakingPhoto:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTakingPhoto:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTakingPhoto:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class GSKCameraSession */
}
