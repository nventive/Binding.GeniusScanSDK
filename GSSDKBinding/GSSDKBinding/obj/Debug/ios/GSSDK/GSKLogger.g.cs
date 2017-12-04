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
	[Protocol (Name = "GSKLogger", WrapperType = typeof (GSKLoggerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LogVerbose", Selector = "logVerbose:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LogDebug", Selector = "logDebug:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LogInfo", Selector = "logInfo:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LogWarn", Selector = "logWarn:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LogError", Selector = "logError:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface IGSKLogger : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("logVerbose:")]
		[Preserve (Conditional = true)]
		void LogVerbose (string message);
		
		[CompilerGenerated]
		[Export ("logDebug:")]
		[Preserve (Conditional = true)]
		void LogDebug (string message);
		
		[CompilerGenerated]
		[Export ("logInfo:")]
		[Preserve (Conditional = true)]
		void LogInfo (string message);
		
		[CompilerGenerated]
		[Export ("logWarn:")]
		[Preserve (Conditional = true)]
		void LogWarn (string message);
		
		[CompilerGenerated]
		[Export ("logError:")]
		[Preserve (Conditional = true)]
		void LogError (string message);
		
	}
	
	internal sealed class GSKLoggerWrapper : BaseWrapper, IGSKLogger {
		[Preserve (Conditional = true)]
		public GSKLoggerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("logVerbose:")]
		[CompilerGenerated]
		public void LogVerbose (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("logVerbose:"), nsmessage);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("logDebug:")]
		[CompilerGenerated]
		public void LogDebug (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("logDebug:"), nsmessage);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("logInfo:")]
		[CompilerGenerated]
		public void LogInfo (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("logInfo:"), nsmessage);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("logWarn:")]
		[CompilerGenerated]
		public void LogWarn (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("logWarn:"), nsmessage);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("logError:")]
		[CompilerGenerated]
		public void LogError (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("logError:"), nsmessage);
			NSString.ReleaseNative (nsmessage);
			
		}
		
	}
}
namespace GSSDK {
	[Protocol]
	[Register("GSKLogger", false)]
	[Model]
	public unsafe abstract partial class GSKLogger : NSObject, IGSKLogger {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GSKLogger () : base (NSObjectFlag.Empty)
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
		protected GSKLogger (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GSKLogger (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("logDebug:")]
		[CompilerGenerated]
		public abstract void LogDebug (string message);
		[Export ("logError:")]
		[CompilerGenerated]
		public abstract void LogError (string message);
		[Export ("logInfo:")]
		[CompilerGenerated]
		public abstract void LogInfo (string message);
		[Export ("logVerbose:")]
		[CompilerGenerated]
		public abstract void LogVerbose (string message);
		[Export ("logWarn:")]
		[CompilerGenerated]
		public abstract void LogWarn (string message);
	} /* class GSKLogger */
}
