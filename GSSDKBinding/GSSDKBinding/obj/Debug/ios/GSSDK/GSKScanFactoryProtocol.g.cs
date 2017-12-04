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
	[Protocol (Name = "GSKScanFactoryProtocol", WrapperType = typeof (GSKScanFactoryProtocolWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCreateScan", Selector = "createScan", ReturnType = typeof (GSSDK.GSKScanProtocol))]
	public interface IGSKScanFactoryProtocol : INativeObject, IDisposable
	{
	}
	
	public static partial class GSKScanFactoryProtocol_Extensions {
		[CompilerGenerated]
		public static GSKScanProtocol GetCreateScan (this IGSKScanFactoryProtocol This)
		{
			return  Runtime.GetNSObject<GSKScanProtocol> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("createScan")));
		}
		
	}
	
	internal sealed class GSKScanFactoryProtocolWrapper : BaseWrapper, IGSKScanFactoryProtocol {
		[Preserve (Conditional = true)]
		public GSKScanFactoryProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace GSSDK {
	[Protocol]
	[Register("GSKScanFactoryProtocol", false)]
	[Model]
	public unsafe partial class GSKScanFactoryProtocol : NSObject, IGSKScanFactoryProtocol {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GSKScanFactoryProtocol () : base (NSObjectFlag.Empty)
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
		protected GSKScanFactoryProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKScanFactoryProtocol (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("createScan")]
		[CompilerGenerated]
		public virtual GSKScanProtocol GetCreateScan ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GSKScanFactoryProtocol */
}
