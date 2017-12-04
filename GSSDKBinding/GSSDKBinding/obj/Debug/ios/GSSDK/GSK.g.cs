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
	[Register("GSK", true)]
	public unsafe partial class GSK : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GSK");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GSK () : base (NSObjectFlag.Empty)
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
		protected GSK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("bestPostProcessingForImage:")]
		[CompilerGenerated]
		public static GSKPostProcessingType BestPostProcessingForImage (global::UIKit.UIImage image)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			return (GSKPostProcessingType) global::ApiDefinitions.Messaging.int_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("bestPostProcessingForImage:"), image.Handle);
		}
		
		[Export ("detectQuadrangleFromImage:options:")]
		[CompilerGenerated]
		public static GSKQuadrangle DetectQuadrangleFromImage (global::UIKit.UIImage image, GSKDetectQuadrangleOptions options)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_int (class_ptr, Selector.GetHandle ("detectQuadrangleFromImage:options:"), image.Handle, (int)options));
		}
		
		[Export ("detectQuadrangleFromSampleBuffer:")]
		[CompilerGenerated]
		public static GSKQuadrangle DetectQuadrangleFromSampleBuffer (global::CoreMedia.CMSampleBuffer sampleBuffer)
		{
			if (sampleBuffer == null)
				throw new ArgumentNullException ("sampleBuffer");
			return  Runtime.GetNSObject<GSKQuadrangle> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("detectQuadrangleFromSampleBuffer:"), sampleBuffer.Handle));
		}
		
		[Export ("enhanceImage:withPostProcessing:")]
		[CompilerGenerated]
		public static global::UIKit.UIImage EnhanceImage (global::UIKit.UIImage image, GSKPostProcessingType postProcessing)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_int (class_ptr, Selector.GetHandle ("enhanceImage:withPostProcessing:"), image.Handle, (int)postProcessing));
		}
		
		[Export ("initWithLicenseKey:")]
		[CompilerGenerated]
		public static bool InitWithLicenseKey (string licenseKey)
		{
			if (licenseKey == null)
				throw new ArgumentNullException ("licenseKey");
			var nslicenseKey = NSString.CreateNative (licenseKey);
			
			bool ret;
			ret = global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("initWithLicenseKey:"), nslicenseKey);
			NSString.ReleaseNative (nslicenseKey);
			
			return ret;
		}
		
		[Export ("warpImage:withQuadrangle:")]
		[CompilerGenerated]
		public static global::UIKit.UIImage WarpImage (global::UIKit.UIImage image, GSKQuadrangle quadrangle)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (quadrangle == null)
				throw new ArgumentNullException ("quadrangle");
			return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("warpImage:withQuadrangle:"), image.Handle, quadrangle.Handle));
		}
		
	} /* class GSK */
}
