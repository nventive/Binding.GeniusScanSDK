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
	[Register("GSKPDFPage", true)]
	public unsafe partial class GSKPDFPage : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GSKPDFPage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GSKPDFPage () : base (NSObjectFlag.Empty)
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
		protected GSKPDFPage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKPDFPage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithFilePath:inchesSize:")]
		[CompilerGenerated]
		public GSKPDFPage (string filePath, GSKPDFSize inchesSize)
			: base (NSObjectFlag.Empty)
		{
			if (filePath == null)
				throw new ArgumentNullException ("filePath");
			if (inchesSize == null)
				throw new ArgumentNullException ("inchesSize");
			var nsfilePath = NSString.CreateNative (filePath);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithFilePath:inchesSize:"), nsfilePath, inchesSize.Handle), "initWithFilePath:inchesSize:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFilePath:inchesSize:"), nsfilePath, inchesSize.Handle), "initWithFilePath:inchesSize:");
			}
			NSString.ReleaseNative (nsfilePath);
			
		}
		
		[Export ("PDFPageWithFilePath:inchesSize:")]
		[CompilerGenerated]
		public static GSKPDFPage PDFPageWithFilePath (string filePath, GSKPDFSize inchesSize)
		{
			if (filePath == null)
				throw new ArgumentNullException ("filePath");
			if (inchesSize == null)
				throw new ArgumentNullException ("inchesSize");
			var nsfilePath = NSString.CreateNative (filePath);
			
			GSKPDFPage ret;
			ret =  Runtime.GetNSObject<GSKPDFPage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("PDFPageWithFilePath:inchesSize:"), nsfilePath, inchesSize.Handle));
			NSString.ReleaseNative (nsfilePath);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual string FilePath {
			[Export ("filePath")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("filePath")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("filePath")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual GSKPDFSize InchesSize {
			[Export ("inchesSize")]
			get {
				GSKPDFSize ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GSKPDFSize> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inchesSize")));
				} else {
					ret =  Runtime.GetNSObject<GSKPDFSize> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inchesSize")));
				}
				return ret;
			}
			
		}
		
	} /* class GSKPDFPage */
}
