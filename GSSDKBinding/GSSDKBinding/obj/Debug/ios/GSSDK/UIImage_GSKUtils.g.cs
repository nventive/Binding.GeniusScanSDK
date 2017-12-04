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
	public unsafe static partial class UIImage_GSKUtils  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIImage");
		
		[Export ("gsk_scaleWithMaxSize:quality:scale:")]
		[CompilerGenerated]
		public static global::UIKit.UIImage Gsk_scaleWithMaxSize (this global::UIKit.UIImage This, nfloat maxSize, CGInterpolationQuality quality, nfloat scale)
		{
			return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_nfloat_int_nfloat (class_ptr, Selector.GetHandle ("gsk_scaleWithMaxSize:quality:scale:"), maxSize, (int)quality, scale));
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIImage Gsk_upOrientedImage {
			[Export ("gsk_upOrientedImage")]
			get {
				global::UIKit.UIImage ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("gsk_upOrientedImage")));
				return ret;
			}
			
		}
		
	} /* class UIImage_GSKUtils */
}
