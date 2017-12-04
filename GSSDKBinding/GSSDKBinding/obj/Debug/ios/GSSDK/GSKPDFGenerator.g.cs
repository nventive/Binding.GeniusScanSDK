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
	[Register("GSKPDFGenerator", true)]
	public unsafe partial class GSKPDFGenerator : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GSKPDFGenerator");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GSKPDFGenerator () : base (NSObjectFlag.Empty)
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
		protected GSKPDFGenerator (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKPDFGenerator (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("createWithDocument:processor:logger:")]
		[CompilerGenerated]
		public static GSKPDFGenerator CreateWithDocument (GSKPDFDocument document, GSKPDFImageProcessor processor, GSKPDFLogger logger)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			return  Runtime.GetNSObject<GSKPDFGenerator> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("createWithDocument:processor:logger:"), document.Handle, processor == null ? IntPtr.Zero : processor.Handle, logger == null ? IntPtr.Zero : logger.Handle));
		}
		
		[Export ("generatePDF:")]
		[CompilerGenerated]
		public virtual GSKPDFGeneratorError GeneratePDF (string outputFile)
		{
			if (outputFile == null)
				throw new ArgumentNullException ("outputFile");
			var nsoutputFile = NSString.CreateNative (outputFile);
			
			GSKPDFGeneratorError ret;
			if (IsDirectBinding) {
				ret = (GSKPDFGeneratorError) global::ApiDefinitions.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("generatePDF:"), nsoutputFile);
			} else {
				ret = (GSKPDFGeneratorError) global::ApiDefinitions.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("generatePDF:"), nsoutputFile);
			}
			NSString.ReleaseNative (nsoutputFile);
			
			return ret;
		}
		
	} /* class GSKPDFGenerator */
}
