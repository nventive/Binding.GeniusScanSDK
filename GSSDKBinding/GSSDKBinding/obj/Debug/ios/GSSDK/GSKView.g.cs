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
	[Register("GSKView", true)]
	public unsafe partial class GSKView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GSKView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GSKView () : base (NSObjectFlag.Empty)
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
		public GSKView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected GSKView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("animateFocusAtLocation:")]
		[CompilerGenerated]
		public virtual void AnimateFocusAtLocation (global::System.IntPtr location)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("animateFocusAtLocation:"), location);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("animateFocusAtLocation:"), location);
			}
		}
		
		[Export ("initializeRotationWithpublicInterfaceOrientation:")]
		[CompilerGenerated]
		public virtual void InitializeRotationWithpublicInterfaceOrientation (global::UIKit.UIInterfaceOrientation Orientation)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("initializeRotationWithpublicInterfaceOrientation:"), (Int64)Orientation);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("initializeRotationWithpublicInterfaceOrientation:"), (int)Orientation);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("initializeRotationWithpublicInterfaceOrientation:"), (Int64)Orientation);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("initializeRotationWithpublicInterfaceOrientation:"), (int)Orientation);
				}
			}
		}
		
		[Export ("pausePreview")]
		[CompilerGenerated]
		public virtual void PausePreview ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pausePreview"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pausePreview"));
			}
		}
		
		[Export ("resumePreview")]
		[CompilerGenerated]
		public virtual void ResumePreview ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resumePreview"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resumePreview"));
			}
		}
		
		[Export ("rotateWithCoordinator:")]
		[CompilerGenerated]
		public virtual void RotateWithCoordinator (global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			if (coordinator == null)
				throw new ArgumentNullException ("coordinator");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("rotateWithCoordinator:"), coordinator.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("rotateWithCoordinator:"), coordinator.Handle);
			}
		}
		
		[Export ("setCaptureSession:")]
		[CompilerGenerated]
		public virtual void SetCaptureSession (global::AVFoundation.AVCaptureSession session)
		{
			if (session == null)
				throw new ArgumentNullException ("session");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCaptureSession:"), session.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCaptureSession:"), session.Handle);
			}
		}
		
		[Export ("updateQuadrangle:")]
		[CompilerGenerated]
		public virtual void UpdateQuadrangle (GSKQuadrangle quadrangle)
		{
			if (quadrangle == null)
				throw new ArgumentNullException ("quadrangle");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("updateQuadrangle:"), quadrangle.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("updateQuadrangle:"), quadrangle.Handle);
			}
		}
		
		[CompilerGenerated]
		public GSCViewDelegate Delegate {
			get {
				return WeakDelegate as GSCViewDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::CoreAnimation.CAShapeLayer FrameLayer {
			[Export ("frameLayer")]
			get {
				global::CoreAnimation.CAShapeLayer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreAnimation.CAShapeLayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("frameLayer")));
				} else {
					ret =  Runtime.GetNSObject<global::CoreAnimation.CAShapeLayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("frameLayer")));
				}
				return ret;
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
		public virtual global::CoreAnimation.CAShapeLayer SnapFrameLayer {
			[Export ("snapFrameLayer")]
			get {
				global::CoreAnimation.CAShapeLayer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreAnimation.CAShapeLayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("snapFrameLayer")));
				} else {
					ret =  Runtime.GetNSObject<global::CoreAnimation.CAShapeLayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("snapFrameLayer")));
				}
				return ret;
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
		public partial class GSKViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal GSKViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new GSKViewAppearance Appearance {
			get { return new GSKViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new GSKViewAppearance GetAppearance<T> () where T: GSKView {
			return new GSKViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new GSKViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new GSKViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new GSKViewAppearance GetAppearance (UITraitCollection traits) {
			return new GSKViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new GSKViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new GSKViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new GSKViewAppearance GetAppearance<T> (UITraitCollection traits) where T: GSKView {
			return new GSKViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new GSKViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: GSKView{
			return new GSKViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class GSKView */
}
