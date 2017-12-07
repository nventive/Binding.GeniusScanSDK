using ObjCRuntime;

[assembly: LinkWith("GSSDK.framework",
	target: LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64,
	SmartLink = true,
	ForceLoad = true,
	LinkerFlags = "-libstdc++ -ObjC",
	Frameworks = "AVFoundation Foundation CoreGraphics CoreMedia UIKit")]
