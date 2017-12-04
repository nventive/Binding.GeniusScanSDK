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
	[Register("GSKQuadrangle", true)]
	public unsafe partial class GSKQuadrangle : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GSKQuadrangle");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GSKQuadrangle () : base (NSObjectFlag.Empty)
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
		protected GSKQuadrangle (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKQuadrangle (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("normalizedWithSize:")]
		[CompilerGenerated]
		public virtual GSKQuadrangle NormalizedWithSize (CGSize size)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("normalizedWithSize:"), size));
			} else {
				return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("normalizedWithSize:"), size));
			}
		}
		
		[Export ("quadrangleFromCGRect:")]
		[CompilerGenerated]
		public static GSKQuadrangle QuadrangleFromCGRect (CGRect rect)
		{
			return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGRect (class_ptr, Selector.GetHandle ("quadrangleFromCGRect:"), rect));
		}
		
		[Export ("rotatedForUpOrientation:")]
		[CompilerGenerated]
		public virtual GSKQuadrangle RotatedForUpOrientation (global::UIKit.UIImageOrientation orientation)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("rotatedForUpOrientation:"), (Int64)orientation));
				} else {
					return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("rotatedForUpOrientation:"), (int)orientation));
				}
			} else {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("rotatedForUpOrientation:"), (Int64)orientation));
				} else {
					return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("rotatedForUpOrientation:"), (int)orientation));
				}
			}
		}
		
		[Export ("rotatedWithoutOrientation:")]
		[CompilerGenerated]
		public virtual GSKQuadrangle RotatedWithoutOrientation (global::UIKit.UIImageOrientation orientation)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("rotatedWithoutOrientation:"), (Int64)orientation));
				} else {
					return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("rotatedWithoutOrientation:"), (int)orientation));
				}
			} else {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("rotatedWithoutOrientation:"), (Int64)orientation));
				} else {
					return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("rotatedWithoutOrientation:"), (int)orientation));
				}
			}
		}
		
		[Export ("scaleForSize:")]
		[CompilerGenerated]
		public virtual GSKQuadrangle ScaleForSize (CGSize size)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("scaleForSize:"), size));
			} else {
				return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("scaleForSize:"), size));
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr BottomLeft {
			[Export ("bottomLeft", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bottomLeft"));
				} else {
					return global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bottomLeft"));
				}
			}
			
			[Export ("setBottomLeft:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBottomLeft:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBottomLeft:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr BottomRight {
			[Export ("bottomRight", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bottomRight"));
				} else {
					return global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bottomRight"));
				}
			}
			
			[Export ("setBottomRight:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBottomRight:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBottomRight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public static GSKQuadrangle EmptyQuadrangle {
			[Export ("emptyQuadrangle")]
			get {
				GSKQuadrangle ret;
				ret =  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("emptyQuadrangle")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsConvex {
			[Export ("isConvex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isConvex"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isConvex"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsEmpty {
			[Export ("isEmpty")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEmpty"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEmpty"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsMax {
			[Export ("isMax")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMax"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isMax"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public static GSKQuadrangle MaxQuadrangle {
			[Export ("maxQuadrangle")]
			get {
				GSKQuadrangle ret;
				ret =  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("maxQuadrangle")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual GSKQuadrangle Sanitized {
			[Export ("sanitized")]
			get {
				GSKQuadrangle ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sanitized")));
				} else {
					ret =  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sanitized")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr TopLeft {
			[Export ("topLeft", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("topLeft"));
				} else {
					return global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("topLeft"));
				}
			}
			
			[Export ("setTopLeft:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTopLeft:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTopLeft:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.IntPtr TopRight {
			[Export ("topRight", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("topRight"));
				} else {
					return global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("topRight"));
				}
			}
			
			[Export ("setTopRight:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTopRight:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTopRight:"), value);
				}
			}
		}
		
	} /* class GSKQuadrangle */
}
