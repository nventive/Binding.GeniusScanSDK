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
	[Register("GSKCameraViewController", true)]
	public unsafe partial class GSKCameraViewController : global::UIKit.UIViewController, IGSKCameraSessionDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GSKCameraViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GSKCameraViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public GSKCameraViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected GSKCameraViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKCameraViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithCameraSession:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public GSKCameraViewController (GSKCameraSession cameraSession)
			: base (NSObjectFlag.Empty)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCameraSession:"), cameraSession.Handle), "initWithCameraSession:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCameraSession:"), cameraSession.Handle), "initWithCameraSession:");
			}
		}
		
		[Export ("cameraSession:didFailWithError:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidFailWithError (GSKCameraSession cameraSession, NSError error)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didFailWithError:"), cameraSession.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSession:didFailWithError:"), cameraSession.Handle, error.Handle);
			}
		}
		
		[Export ("cameraSession:didFindQuadrangle:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidFindQuadrangle (GSKCameraSession cameraSession, GSKQuadrangle quadrangle)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (quadrangle == null)
				throw new ArgumentNullException ("quadrangle");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didFindQuadrangle:"), cameraSession.Handle, quadrangle.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSession:didFindQuadrangle:"), cameraSession.Handle, quadrangle.Handle);
			}
		}
		
		[Export ("cameraSession:didGenerateScan:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidScan (GSKCameraSession cameraSession, GSKScanProtocol scan)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (scan == null)
				throw new ArgumentNullException ("scan");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didGenerateScan:"), cameraSession.Handle, scan.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSession:didGenerateScan:"), cameraSession.Handle, scan.Handle);
			}
		}
		
		[Export ("cameraSessionDidSetup:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidSetupDidSetup (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionDidSetup:"), cameraSession.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSessionDidSetup:"), cameraSession.Handle);
			}
		}
		
		[Export ("cameraSessionDidSnapPhoto:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidSnapPhoto (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionDidSnapPhoto:"), cameraSession.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSessionDidSnapPhoto:"), cameraSession.Handle);
			}
		}
		
		[Export ("cameraSessionDidStart:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidStart (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionDidStart:"), cameraSession.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSessionDidStart:"), cameraSession.Handle);
			}
		}
		
		[Export ("cameraSessionDidStop:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidStop (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionDidStop:"), cameraSession.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSessionDidStop:"), cameraSession.Handle);
			}
		}
		
		[Export ("cameraSession:didFailToSnapPhotoWithError:")]
		[CompilerGenerated]
		public virtual void CameraSessionFailToSnapWithError (GSKCameraSession cameraSession, NSError error)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didFailToSnapPhotoWithError:"), cameraSession.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSession:didFailToSnapPhotoWithError:"), cameraSession.Handle, error.Handle);
			}
		}
		
		[Export ("cameraSessionFailedToFindQuadrangle:")]
		[CompilerGenerated]
		public virtual void CameraSessionFailedToFindQuadrangle (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionFailedToFindQuadrangle:"), cameraSession.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSessionFailedToFindQuadrangle:"), cameraSession.Handle);
			}
		}
		
		[Export ("cameraSession:didEncounterFailureWithError:")]
		[CompilerGenerated]
		public virtual void CameraSessionFailureWithError (GSKCameraSession cameraSession, NSError error)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didEncounterFailureWithError:"), cameraSession.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSession:didEncounterFailureWithError:"), cameraSession.Handle, error.Handle);
			}
		}
		
		[Export ("cameraSessionInterruptionEnded:")]
		[CompilerGenerated]
		public virtual void CameraSessionInterruptionEnded (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionInterruptionEnded:"), cameraSession.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSessionInterruptionEnded:"), cameraSession.Handle);
			}
		}
		
		[Export ("cameraSessionIsAboutToChooseQuadrangle:")]
		[CompilerGenerated]
		public virtual void CameraSessionIsAboutToChooseQuadrangle (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionIsAboutToChooseQuadrangle:"), cameraSession.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSessionIsAboutToChooseQuadrangle:"), cameraSession.Handle);
			}
		}
		
		[Export ("cameraSession:setupFailedWithError:")]
		[CompilerGenerated]
		public virtual void CameraSessionSetupFailedWithError (GSKCameraSession cameraSession, NSError error)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:setupFailedWithError:"), cameraSession.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSession:setupFailedWithError:"), cameraSession.Handle, error.Handle);
			}
		}
		
		[Export ("cameraSession:wasInterruptedWithReason:")]
		[CompilerGenerated]
		public virtual void CameraSessionWasInterrupted (GSKCameraSession cameraSession, global::AVFoundation.AVCaptureSessionInterruptionReason reason)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_Int64 (this.Handle, Selector.GetHandle ("cameraSession:wasInterruptedWithReason:"), cameraSession.Handle, (Int64)reason);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("cameraSession:wasInterruptedWithReason:"), cameraSession.Handle, (int)reason);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_Int64 (this.SuperHandle, Selector.GetHandle ("cameraSession:wasInterruptedWithReason:"), cameraSession.Handle, (Int64)reason);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("cameraSession:wasInterruptedWithReason:"), cameraSession.Handle, (int)reason);
				}
			}
		}
		
		[Export ("cameraSessionWillSnapPhoto:")]
		[CompilerGenerated]
		public virtual void CameraSessionWillSnapPhoto (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionWillSnapPhoto:"), cameraSession.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSessionWillSnapPhoto:"), cameraSession.Handle);
			}
		}
		
		[Export ("cameraSession:willAutoTriggerWithQuadrangle:")]
		[CompilerGenerated]
		public virtual void CameraSessionWillautoTriggerWithQuadrangle (GSKCameraSession cameraSession, GSKQuadrangle quadrangle)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (quadrangle == null)
				throw new ArgumentNullException ("quadrangle");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:willAutoTriggerWithQuadrangle:"), cameraSession.Handle, quadrangle.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSession:willAutoTriggerWithQuadrangle:"), cameraSession.Handle, quadrangle.Handle);
			}
		}
		
		[Export ("cameraSessionisSearchingQuadrangle:")]
		[CompilerGenerated]
		public virtual void CameraSessionisSearchingQuadrangle (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionisSearchingQuadrangle:"), cameraSession.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraSessionisSearchingQuadrangle:"), cameraSession.Handle);
			}
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
		public virtual GSKCameraSession CameraSession {
			[Export ("cameraSession")]
			get {
				GSKCameraSession ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GSKCameraSession> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cameraSession")));
				} else {
					ret =  Runtime.GetNSObject<GSKCameraSession> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cameraSession")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIView CameraView {
			[Export ("cameraView")]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cameraView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cameraView")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual GSKView CaptureView {
			[Export ("captureView", ArgumentSemantic.Retain)]
			get {
				GSKView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GSKView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("captureView")));
				} else {
					ret =  Runtime.GetNSObject<GSKView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("captureView")));
				}
				return ret;
			}
			
			[Export ("setCaptureView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCaptureView:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCaptureView:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DrawsDocumentFrameOverlay {
			[Export ("drawsDocumentFrameOverlay")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("drawsDocumentFrameOverlay"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("drawsDocumentFrameOverlay"));
				}
			}
			
			[Export ("setDrawsDocumentFrameOverlay:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDrawsDocumentFrameOverlay:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDrawsDocumentFrameOverlay:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor OverlayColor {
			[Export ("overlayColor", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("overlayColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("overlayColor")));
				}
				return ret;
			}
			
			[Export ("setOverlayColor:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOverlayColor:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOverlayColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual GSKShutterView ShutterView {
			[Export ("shutterView")]
			get {
				GSKShutterView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GSKShutterView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shutterView")));
				} else {
					ret =  Runtime.GetNSObject<GSKShutterView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shutterView")));
				}
				return ret;
			}
			
		}
		
	} /* class GSKCameraViewController */
}
