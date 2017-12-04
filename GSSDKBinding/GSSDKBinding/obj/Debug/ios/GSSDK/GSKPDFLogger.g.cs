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
	[Protocol (Name = "GSKPDFLogger", WrapperType = typeof (GSKPDFLoggerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Log", Selector = "log:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface IGSKPDFLogger : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("log:")]
		[Preserve (Conditional = true)]
		void Log (string debug);
		
	}
	
	internal sealed class GSKPDFLoggerWrapper : BaseWrapper, IGSKPDFLogger {
		[Preserve (Conditional = true)]
		public GSKPDFLoggerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("log:")]
		[CompilerGenerated]
		public void Log (string debug)
		{
			if (debug == null)
				throw new ArgumentNullException ("debug");
			var nsdebug = NSString.CreateNative (debug);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("log:"), nsdebug);
			NSString.ReleaseNative (nsdebug);
			
		}
		
	}
}
namespace GSSDK {
	[Protocol]
	[Register("GSKPDFLogger", false)]
	[Model]
	public unsafe abstract partial class GSKPDFLogger : NSObject, IGSKPDFLogger {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GSKPDFLogger () : base (NSObjectFlag.Empty)
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
		protected GSKPDFLogger (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKPDFLogger (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("log:")]
		[CompilerGenerated]
		public abstract void Log (string debug);
	} /* class GSKPDFLogger */
}
