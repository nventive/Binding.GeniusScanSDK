using ObjCRuntime;

[assembly: LinkWith(
	"GSSDK.framework",
	SmartLink = true,
	ForceLoad = true,
	LinkerFlags = "-libstdc++ -ObjC",
	Frameworks = "AVFoundation Foundation CoreGraphics CoreMedia UIKit"
)]
