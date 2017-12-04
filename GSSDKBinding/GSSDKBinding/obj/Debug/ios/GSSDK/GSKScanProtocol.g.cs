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
	[Protocol (Name = "GSKScanProtocol", WrapperType = typeof (GSKScanProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FilePath", Selector = "filePath", PropertyType = typeof (string), GetterSelector = "filePath", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IGSKScanProtocol : INativeObject, IDisposable
	{
		[Preserve (Conditional = true)]
		string FilePath {
			[Export ("filePath")]
			get;
		}
		
	}
	
	internal sealed class GSKScanProtocolWrapper : BaseWrapper, IGSKScanProtocol {
		[Preserve (Conditional = true)]
		public GSKScanProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[CompilerGenerated]
		public string FilePath {
			[Export ("filePath")]
			get {
				return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("filePath")));
			}
			
		}
		
	}
}
namespace GSSDK {
	[Protocol]
	[Register("GSKScanProtocol", false)]
	[Model]
	public unsafe abstract partial class GSKScanProtocol : NSObject, IGSKScanProtocol {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GSKScanProtocol () : base (NSObjectFlag.Empty)
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
		protected GSKScanProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKScanProtocol (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public abstract string FilePath {
			[Export ("filePath")]
			get; 
		}
		
	} /* class GSKScanProtocol */
}
