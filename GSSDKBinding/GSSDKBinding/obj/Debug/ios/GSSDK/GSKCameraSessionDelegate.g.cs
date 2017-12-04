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
	[Protocol (Name = "GSKCameraSessionDelegate", WrapperType = typeof (GSKCameraSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CameraSessionSetupFailedWithError", Selector = "cameraSession:setupFailedWithError:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CameraSessionFailureWithError", Selector = "cameraSession:didEncounterFailureWithError:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CameraSessionWillSnapPhoto", Selector = "cameraSessionWillSnapPhoto:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CameraSessionDidSnapPhoto", Selector = "cameraSessionDidSnapPhoto:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CameraSessionFailToSnapWithError", Selector = "cameraSession:didFailToSnapPhotoWithError:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CameraSessionDidScan", Selector = "cameraSession:didGenerateScan:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession), typeof (GSSDK.GSKScanProtocol) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CameraSessionDidFailWithError", Selector = "cameraSession:didFailWithError:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CameraSessionDidFindQuadrangle", Selector = "cameraSession:didFindQuadrangle:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession), typeof (GSSDK.GSKQuadrangle) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSessionDidSetupDidSetup", Selector = "cameraSessionDidSetup:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSessionFailedToFindQuadrangle", Selector = "cameraSessionFailedToFindQuadrangle:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSessionWillautoTriggerWithQuadrangle", Selector = "cameraSession:willAutoTriggerWithQuadrangle:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession), typeof (GSSDK.GSKQuadrangle) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSessionIsAboutToChooseQuadrangle", Selector = "cameraSessionIsAboutToChooseQuadrangle:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSessionisSearchingQuadrangle", Selector = "cameraSessionisSearchingQuadrangle:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSessionDidStart", Selector = "cameraSessionDidStart:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSessionDidStop", Selector = "cameraSessionDidStop:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSessionWasInterrupted", Selector = "cameraSession:wasInterruptedWithReason:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession), typeof (AVCaptureSessionInterruptionReason) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSessionInterruptionEnded", Selector = "cameraSessionInterruptionEnded:", ParameterType = new Type [] { typeof (GSSDK.GSKCameraSession) }, ParameterByRef = new bool [] { false })]
	public interface IGSKCameraSessionDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("cameraSession:setupFailedWithError:")]
		[Preserve (Conditional = true)]
		void CameraSessionSetupFailedWithError (GSKCameraSession cameraSession, NSError error);
		
		[CompilerGenerated]
		[Export ("cameraSession:didEncounterFailureWithError:")]
		[Preserve (Conditional = true)]
		void CameraSessionFailureWithError (GSKCameraSession cameraSession, NSError error);
		
		[CompilerGenerated]
		[Export ("cameraSessionWillSnapPhoto:")]
		[Preserve (Conditional = true)]
		void CameraSessionWillSnapPhoto (GSKCameraSession cameraSession);
		
		[CompilerGenerated]
		[Export ("cameraSessionDidSnapPhoto:")]
		[Preserve (Conditional = true)]
		void CameraSessionDidSnapPhoto (GSKCameraSession cameraSession);
		
		[CompilerGenerated]
		[Export ("cameraSession:didFailToSnapPhotoWithError:")]
		[Preserve (Conditional = true)]
		void CameraSessionFailToSnapWithError (GSKCameraSession cameraSession, NSError error);
		
		[CompilerGenerated]
		[Export ("cameraSession:didGenerateScan:")]
		[Preserve (Conditional = true)]
		void CameraSessionDidScan (GSKCameraSession cameraSession, GSKScanProtocol scan);
		
		[CompilerGenerated]
		[Export ("cameraSession:didFailWithError:")]
		[Preserve (Conditional = true)]
		void CameraSessionDidFailWithError (GSKCameraSession cameraSession, NSError error);
		
		[CompilerGenerated]
		[Export ("cameraSession:didFindQuadrangle:")]
		[Preserve (Conditional = true)]
		void CameraSessionDidFindQuadrangle (GSKCameraSession cameraSession, GSKQuadrangle quadrangle);
		
	}
	
	public static partial class GSKCameraSessionDelegate_Extensions {
		[CompilerGenerated]
		public static void CameraSessionDidSetupDidSetup (this IGSKCameraSessionDelegate This, GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("cameraSessionDidSetup:"), cameraSession.Handle);
		}
		
		[CompilerGenerated]
		public static void CameraSessionFailedToFindQuadrangle (this IGSKCameraSessionDelegate This, GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("cameraSessionFailedToFindQuadrangle:"), cameraSession.Handle);
		}
		
		[CompilerGenerated]
		public static void CameraSessionWillautoTriggerWithQuadrangle (this IGSKCameraSessionDelegate This, GSKCameraSession cameraSession, GSKQuadrangle quadrangle)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (quadrangle == null)
				throw new ArgumentNullException ("quadrangle");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("cameraSession:willAutoTriggerWithQuadrangle:"), cameraSession.Handle, quadrangle.Handle);
		}
		
		[CompilerGenerated]
		public static void CameraSessionIsAboutToChooseQuadrangle (this IGSKCameraSessionDelegate This, GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("cameraSessionIsAboutToChooseQuadrangle:"), cameraSession.Handle);
		}
		
		[CompilerGenerated]
		public static void CameraSessionisSearchingQuadrangle (this IGSKCameraSessionDelegate This, GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("cameraSessionisSearchingQuadrangle:"), cameraSession.Handle);
		}
		
		[CompilerGenerated]
		public static void CameraSessionDidStart (this IGSKCameraSessionDelegate This, GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("cameraSessionDidStart:"), cameraSession.Handle);
		}
		
		[CompilerGenerated]
		public static void CameraSessionDidStop (this IGSKCameraSessionDelegate This, GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("cameraSessionDidStop:"), cameraSession.Handle);
		}
		
		[CompilerGenerated]
		public static void CameraSessionWasInterrupted (this IGSKCameraSessionDelegate This, GSKCameraSession cameraSession, global::AVFoundation.AVCaptureSessionInterruptionReason reason)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (IntPtr.Size == 8) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_Int64 (This.Handle, Selector.GetHandle ("cameraSession:wasInterruptedWithReason:"), cameraSession.Handle, (Int64)reason);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("cameraSession:wasInterruptedWithReason:"), cameraSession.Handle, (int)reason);
			}
		}
		
		[CompilerGenerated]
		public static void CameraSessionInterruptionEnded (this IGSKCameraSessionDelegate This, GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("cameraSessionInterruptionEnded:"), cameraSession.Handle);
		}
		
	}
	
	internal sealed class GSKCameraSessionDelegateWrapper : BaseWrapper, IGSKCameraSessionDelegate {
		[Preserve (Conditional = true)]
		public GSKCameraSessionDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("cameraSession:setupFailedWithError:")]
		[CompilerGenerated]
		public void CameraSessionSetupFailedWithError (GSKCameraSession cameraSession, NSError error)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:setupFailedWithError:"), cameraSession.Handle, error.Handle);
		}
		
		[Export ("cameraSession:didEncounterFailureWithError:")]
		[CompilerGenerated]
		public void CameraSessionFailureWithError (GSKCameraSession cameraSession, NSError error)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didEncounterFailureWithError:"), cameraSession.Handle, error.Handle);
		}
		
		[Export ("cameraSessionWillSnapPhoto:")]
		[CompilerGenerated]
		public void CameraSessionWillSnapPhoto (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionWillSnapPhoto:"), cameraSession.Handle);
		}
		
		[Export ("cameraSessionDidSnapPhoto:")]
		[CompilerGenerated]
		public void CameraSessionDidSnapPhoto (GSKCameraSession cameraSession)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraSessionDidSnapPhoto:"), cameraSession.Handle);
		}
		
		[Export ("cameraSession:didFailToSnapPhotoWithError:")]
		[CompilerGenerated]
		public void CameraSessionFailToSnapWithError (GSKCameraSession cameraSession, NSError error)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didFailToSnapPhotoWithError:"), cameraSession.Handle, error.Handle);
		}
		
		[Export ("cameraSession:didGenerateScan:")]
		[CompilerGenerated]
		public void CameraSessionDidScan (GSKCameraSession cameraSession, GSKScanProtocol scan)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (scan == null)
				throw new ArgumentNullException ("scan");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didGenerateScan:"), cameraSession.Handle, scan.Handle);
		}
		
		[Export ("cameraSession:didFailWithError:")]
		[CompilerGenerated]
		public void CameraSessionDidFailWithError (GSKCameraSession cameraSession, NSError error)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didFailWithError:"), cameraSession.Handle, error.Handle);
		}
		
		[Export ("cameraSession:didFindQuadrangle:")]
		[CompilerGenerated]
		public void CameraSessionDidFindQuadrangle (GSKCameraSession cameraSession, GSKQuadrangle quadrangle)
		{
			if (cameraSession == null)
				throw new ArgumentNullException ("cameraSession");
			if (quadrangle == null)
				throw new ArgumentNullException ("quadrangle");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraSession:didFindQuadrangle:"), cameraSession.Handle, quadrangle.Handle);
		}
		
	}
}
namespace GSSDK {
	[Protocol]
	[Register("GSKCameraSessionDelegate", false)]
	[Model]
	public unsafe abstract partial class GSKCameraSessionDelegate : NSObject, IGSKCameraSessionDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GSKCameraSessionDelegate () : base (NSObjectFlag.Empty)
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
		protected GSKCameraSessionDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKCameraSessionDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("cameraSession:didFailWithError:")]
		[CompilerGenerated]
		public abstract void CameraSessionDidFailWithError (GSKCameraSession cameraSession, NSError error);
		[Export ("cameraSession:didFindQuadrangle:")]
		[CompilerGenerated]
		public abstract void CameraSessionDidFindQuadrangle (GSKCameraSession cameraSession, GSKQuadrangle quadrangle);
		[Export ("cameraSession:didGenerateScan:")]
		[CompilerGenerated]
		public abstract void CameraSessionDidScan (GSKCameraSession cameraSession, GSKScanProtocol scan);
		[Export ("cameraSessionDidSetup:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidSetupDidSetup (GSKCameraSession cameraSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cameraSessionDidSnapPhoto:")]
		[CompilerGenerated]
		public abstract void CameraSessionDidSnapPhoto (GSKCameraSession cameraSession);
		[Export ("cameraSessionDidStart:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidStart (GSKCameraSession cameraSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cameraSessionDidStop:")]
		[CompilerGenerated]
		public virtual void CameraSessionDidStop (GSKCameraSession cameraSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cameraSession:didFailToSnapPhotoWithError:")]
		[CompilerGenerated]
		public abstract void CameraSessionFailToSnapWithError (GSKCameraSession cameraSession, NSError error);
		[Export ("cameraSessionFailedToFindQuadrangle:")]
		[CompilerGenerated]
		public virtual void CameraSessionFailedToFindQuadrangle (GSKCameraSession cameraSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cameraSession:didEncounterFailureWithError:")]
		[CompilerGenerated]
		public abstract void CameraSessionFailureWithError (GSKCameraSession cameraSession, NSError error);
		[Export ("cameraSessionInterruptionEnded:")]
		[CompilerGenerated]
		public virtual void CameraSessionInterruptionEnded (GSKCameraSession cameraSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cameraSessionIsAboutToChooseQuadrangle:")]
		[CompilerGenerated]
		public virtual void CameraSessionIsAboutToChooseQuadrangle (GSKCameraSession cameraSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cameraSession:setupFailedWithError:")]
		[CompilerGenerated]
		public abstract void CameraSessionSetupFailedWithError (GSKCameraSession cameraSession, NSError error);
		[Export ("cameraSession:wasInterruptedWithReason:")]
		[CompilerGenerated]
		public virtual void CameraSessionWasInterrupted (GSKCameraSession cameraSession, global::AVFoundation.AVCaptureSessionInterruptionReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cameraSessionWillSnapPhoto:")]
		[CompilerGenerated]
		public abstract void CameraSessionWillSnapPhoto (GSKCameraSession cameraSession);
		[Export ("cameraSession:willAutoTriggerWithQuadrangle:")]
		[CompilerGenerated]
		public virtual void CameraSessionWillautoTriggerWithQuadrangle (GSKCameraSession cameraSession, GSKQuadrangle quadrangle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cameraSessionisSearchingQuadrangle:")]
		[CompilerGenerated]
		public virtual void CameraSessionisSearchingQuadrangle (GSKCameraSession cameraSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GSKCameraSessionDelegate */
}
