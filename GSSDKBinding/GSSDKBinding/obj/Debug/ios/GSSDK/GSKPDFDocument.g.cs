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
	[Register("GSKPDFDocument", true)]
	public unsafe partial class GSKPDFDocument : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GSKPDFDocument");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GSKPDFDocument () : base (NSObjectFlag.Empty)
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
		protected GSKPDFDocument (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKPDFDocument (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithTitle:password:keywords:pages:")]
		[CompilerGenerated]
		public GSKPDFDocument (string title, string password, string keywords, GSKPDFPage[] pages)
			: base (NSObjectFlag.Empty)
		{
			if (pages == null)
				throw new ArgumentNullException ("pages");
			var nstitle = NSString.CreateNative (title);
			var nspassword = NSString.CreateNative (password);
			var nskeywords = NSString.CreateNative (keywords);
			var nsa_pages = NSArray.FromNSObjects (pages);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithTitle:password:keywords:pages:"), nstitle, nspassword, nskeywords, nsa_pages.Handle), "initWithTitle:password:keywords:pages:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTitle:password:keywords:pages:"), nstitle, nspassword, nskeywords, nsa_pages.Handle), "initWithTitle:password:keywords:pages:");
			}
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nspassword);
			NSString.ReleaseNative (nskeywords);
			nsa_pages.Dispose ();
			
		}
		
		[Export ("PDFDocumentWithTitle:password:keywords:pages:")]
		[CompilerGenerated]
		public static GSKPDFDocument PDFDocumentWithTitle (string title, string password, string keywords, GSKPDFPage[] pages)
		{
			if (pages == null)
				throw new ArgumentNullException ("pages");
			var nstitle = NSString.CreateNative (title);
			var nspassword = NSString.CreateNative (password);
			var nskeywords = NSString.CreateNative (keywords);
			var nsa_pages = NSArray.FromNSObjects (pages);
			
			GSKPDFDocument ret;
			ret =  Runtime.GetNSObject<GSKPDFDocument> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("PDFDocumentWithTitle:password:keywords:pages:"), nstitle, nspassword, nskeywords, nsa_pages.Handle));
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nspassword);
			NSString.ReleaseNative (nskeywords);
			nsa_pages.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual string Keywords {
			[Export ("keywords")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keywords")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("keywords")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual GSKPDFPage[] Pages {
			[Export ("pages")]
			get {
				GSKPDFPage[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<GSKPDFPage>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pages")));
				} else {
					ret = NSArray.ArrayFromHandle<GSKPDFPage>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pages")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Password {
			[Export ("password")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("password")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("password")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("title")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")));
				}
			}
			
		}
		
	} /* class GSKPDFDocument */
}
