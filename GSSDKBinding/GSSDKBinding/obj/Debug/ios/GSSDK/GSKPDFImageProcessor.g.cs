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
	[Protocol (Name = "GSKPDFImageProcessor", WrapperType = typeof (GSKPDFImageProcessorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Process", Selector = "process:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface IGSKPDFImageProcessor : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("process:")]
		[Preserve (Conditional = true)]
		string Process (string inputFilePath);
		
	}
	
	internal sealed class GSKPDFImageProcessorWrapper : BaseWrapper, IGSKPDFImageProcessor {
		[Preserve (Conditional = true)]
		public GSKPDFImageProcessorWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("process:")]
		[CompilerGenerated]
		public string Process (string inputFilePath)
		{
			if (inputFilePath == null)
				throw new ArgumentNullException ("inputFilePath");
			var nsinputFilePath = NSString.CreateNative (inputFilePath);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("process:"), nsinputFilePath));
			NSString.ReleaseNative (nsinputFilePath);
			
			return ret;
		}
		
	}
}
namespace GSSDK {
	[Protocol]
	[Register("GSKPDFImageProcessor", false)]
	[Model]
	public unsafe abstract partial class GSKPDFImageProcessor : NSObject, IGSKPDFImageProcessor {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GSKPDFImageProcessor () : base (NSObjectFlag.Empty)
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
		protected GSKPDFImageProcessor (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKPDFImageProcessor (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("process:")]
		[CompilerGenerated]
		public abstract string Process (string inputFilePath);
	} /* class GSKPDFImageProcessor */
}
