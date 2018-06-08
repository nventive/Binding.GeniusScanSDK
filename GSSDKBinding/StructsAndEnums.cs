using System;
using ObjCRuntime;

namespace GSSDK
{
	public enum GSKPostProcessingType : int
	{
		None = 0,
		BlackAndWhite,
		Color,
		Whiteboard,
		BlackAndWhiteBinary
	}

    public enum GSKDetectQuadrangleOptions : int
	{
		None = 0,
		Fast = 1 << 0
	}

    public enum GSKCameraSessionFlashStatus : int
	{
		On,
		Off,
		Auto
	}

    public enum GSKCameraSessionError : int
	{
		ErrorOther = -1,
		ErrorNotAuthorized = -2,
		ErrorLockDevice = -3,
		ErrorNoDevice = -4,
		ErrorInvalidSetupDependency = -5,
		ErrorNoVideoCaptureConnection = -6,
		ErrorInvalidData = -7,
		WarnLockDevice = -1003
	}

    public enum GSKPDFGeneratorError : int
	{
		Success,
		Internal,
		FileNotFound,
		InvalidPassword,
		InvalidPageSize,
		ProcessorError
	}
}
