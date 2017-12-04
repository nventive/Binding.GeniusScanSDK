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
	[Protocol (Name = "GSCViewDelegate", WrapperType = typeof (GSCViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestedFocusAtPoint", Selector = "cameraView:requestedFocusAtPoint:", ParameterType = new Type [] { typeof (GSSDK.GSKView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	public interface IGSCViewDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("cameraView:requestedFocusAtPoint:")]
		[Preserve (Conditional = true)]
		void RequestedFocusAtPoint (GSKView cameraView, global::System.IntPtr focusPoint);
		
	}
	
	internal sealed class GSCViewDelegateWrapper : BaseWrapper, IGSCViewDelegate {
		[Preserve (Conditional = true)]
		public GSCViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("cameraView:requestedFocusAtPoint:")]
		[CompilerGenerated]
		public void RequestedFocusAtPoint (GSKView cameraView, global::System.IntPtr focusPoint)
		{
			if (cameraView == null)
				throw new ArgumentNullException ("cameraView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cameraView:requestedFocusAtPoint:"), cameraView.Handle, focusPoint);
		}
		
	}
}
namespace GSSDK {
	[Protocol]
	[Register("GSCViewDelegate", false)]
	[Model]
	public unsafe abstract partial class GSCViewDelegate : NSObject, IGSCViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GSCViewDelegate () : base (NSObjectFlag.Empty)
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
		protected GSCViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSCViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("cameraView:requestedFocusAtPoint:")]
		[CompilerGenerated]
		public abstract void RequestedFocusAtPoint (GSKView cameraView, global::System.IntPtr focusPoint);
	} /* class GSCViewDelegate */
}
