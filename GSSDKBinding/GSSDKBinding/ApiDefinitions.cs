using System;
using AVFoundation;
using CoreAnimation;
using CoreGraphics;
using CoreMedia;
using Foundation;
using GSSDK;
using ObjCRuntime;
using UIKit;

namespace GSSDK
{
	public partial interface Constants
	{
		// extern double GSSDKVersionNumber;
		[Field ("GSSDKVersionNumber", "__Internal")]
		double GSSDKVersionNumber { get; }

		// extern const unsigned char [] GSSDKVersionString;
		[Field ("GSSDKVersionString", "__Internal")]
		IntPtr GSSDKVersionString { get; }
	}

	// @protocol GSKScanProtocol <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	public interface GSKScanProtocol
	{
		// @required -(NSString *)filePath;
		[Abstract]
		[Export ("filePath")]
		string FilePath { get; }
	}

	// typedef void (^GSKCameraStringBlock)(NSString *);
	public delegate void GSKCameraStringBlock (string arg0);

	// typedef void (^GSKCameraVoidBlock)();
	public delegate void GSKCameraVoidBlock ();

	// typedef void (^GSKCameraBoolBlock)(BOOL);
	public delegate void GSKCameraBoolBlock (bool arg0);

	// typedef void (^GSKCameraErrorBlock)(NSError *);
	public delegate void GSKCameraErrorBlock (NSError arg0);

	// typedef void (^GSKCameraScanBlock)(id<GSKScanProtocol>);
	public delegate void GSKCameraScanBlock (GSKScanProtocol arg0);

	// @public interface GSK : NSObject
	[BaseType (typeof(NSObject))]
	public interface GSK
	{
		// +(BOOL)initWithLicenseKey:(NSString *)licenseKey;
		[Static]
		[Export ("initWithLicenseKey:")]
		bool InitWithLicenseKey (string licenseKey);

		// +(GSKQuadrangle *)detectQuadrangleFromImage:(UIImage *)image options:(GSKDetectQuadrangleOptions)options;
		[Static]
		[Export ("detectQuadrangleFromImage:options:")]
		GSKQuadrangle DetectQuadrangleFromImage (UIImage image, GSKDetectQuadrangleOptions options);

		// +(GSKQuadrangle *)detectQuadrangleFromSampleBuffer:(CMSampleBufferRef)sampleBuffer;
		[Static]
		[Export ("detectQuadrangleFromSampleBuffer:")]
		unsafe GSKQuadrangle DetectQuadrangleFromSampleBuffer (CMSampleBuffer sampleBuffer);

		// +(UIImage *)warpImage:(UIImage *)image withQuadrangle:(GSKQuadrangle *)quadrangle;
		[Static]
		[Export ("warpImage:withQuadrangle:")]
		UIImage WarpImage (UIImage image, GSKQuadrangle quadrangle);

		// +(GSKPostProcessingType)bestPostProcessingForImage:(UIImage *)image;
		[Static]
		[Export ("bestPostProcessingForImage:")]
		GSKPostProcessingType BestPostProcessingForImage (UIImage image);

		// +(UIImage *)enhanceImage:(UIImage *)image withPostProcessing:(GSKPostProcessingType)postProcessing;
		[Static]
		[Export ("enhanceImage:withPostProcessing:")]
		UIImage EnhanceImage (UIImage image, GSKPostProcessingType postProcessing);
	}

	// @public interface GSKUtils (UIImage)
	[Category]
	[BaseType (typeof(UIImage))]
	public interface UIImage_GSKUtils
	{
		// -(UIImage *)gsk_scaleWithMaxSize:(CGFloat)maxSize quality:(CGInterpolationQuality)quality scale:(CGFloat)scale;
		[Static]
		[Export ("gsk_scaleWithMaxSize:quality:scale:")]
		UIImage Gsk_scaleWithMaxSize (nfloat maxSize, CGInterpolationQuality quality, nfloat scale);

		// -(UIImage *)gsk_upOrientedImage;
		[Export ("gsk_upOrientedImage")]
		[Static]
		UIImage Gsk_upOrientedImage { get; }
	}

	// @protocol GSKLogger <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	public interface GSKLogger
	{
		// @required -(void)logVerbose:(NSString *)message;
		[Abstract]
		[Export ("logVerbose:")]
		void LogVerbose (string message);

		// @required -(void)logDebug:(NSString *)message;
		[Abstract]
		[Export ("logDebug:")]
		void LogDebug (string message);

		// @required -(void)logInfo:(NSString *)message;
		[Abstract]
		[Export ("logInfo:")]
		void LogInfo (string message);

		// @required -(void)logWarn:(NSString *)message;
		[Abstract]
		[Export ("logWarn:")]
		void LogWarn (string message);

		// @required -(void)logError:(NSString *)message;
		[Abstract]
		[Export ("logError:")]
		void LogError (string message);
	}

	// @public interface GSKLog : NSObject
	[BaseType (typeof(NSObject))]
	public interface GSKLog
	{
		// +(void)setLogger:(id<GSKLogger>)logger;
		[Static]
		[Export ("setLogger:")]
		void SetLogger (GSKLogger logger);
	}

	// @protocol GSKScanFactoryProtocol <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	public interface GSKScanFactoryProtocol
	{
		// @required -(id<GSKScanProtocol>)createScan;
		[Abstract]
		[Export("createScan")]
		GSKScanProtocol CreateScan();
	}

	public partial interface Constants
	{
		// extern NSString *const GSCManagerTakePhotoOptionManualKey;
		[Field ("GSCManagerTakePhotoOptionManualKey", "__Internal")]
		NSString GSCManagerTakePhotoOptionManualKey { get; }

		// extern NSString *const kGSKCameraSessionErrorDomain;
		[Field ("kGSKCameraSessionErrorDomain", "__Internal")]
		NSString kGSKCameraSessionErrorDomain { get; }
	}

	// @protocol GSKCameraSessionDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	public interface GSKCameraSessionDelegate
	{
		// @required -(void)cameraSession:(GSKCameraSession *)cameraSession setupFailedWithError:(NSError *)error;
		[Abstract]
		[Export ("cameraSession:setupFailedWithError:")]
		void CameraSessionSetupFailedWithError (GSKCameraSession cameraSession, NSError error);

		// @required -(void)cameraSession:(GSKCameraSession *)cameraSession didEncounterFailureWithError:(NSError *)error;
		[Abstract]
		[Export ("cameraSession:didEncounterFailureWithError:")]
		void CameraSessionFailureWithError (GSKCameraSession cameraSession, NSError error);

		// @required -(void)cameraSessionWillSnapPhoto:(GSKCameraSession *)cameraSession;
		[Abstract]
		[Export ("cameraSessionWillSnapPhoto:")]
		void CameraSessionWillSnapPhoto (GSKCameraSession cameraSession);

		// @required -(void)cameraSessionDidSnapPhoto:(GSKCameraSession *)cameraSession;
		[Abstract]
		[Export ("cameraSessionDidSnapPhoto:")]
		void CameraSessionDidSnapPhoto (GSKCameraSession cameraSession);

		// @required -(void)cameraSession:(GSKCameraSession *)cameraSession didFailToSnapPhotoWithError:(NSError *)error;
		[Abstract]
		[Export ("cameraSession:didFailToSnapPhotoWithError:")]
		void CameraSessionFailToSnapWithError (GSKCameraSession cameraSession, NSError error);

		// @required -(void)cameraSession:(GSKCameraSession *)cameraSession didGenerateScan:(id<GSKScanProtocol>)scan;
		[Abstract]
		[Export ("cameraSession:didGenerateScan:")]
		void CameraSessionDidScan (GSKCameraSession cameraSession, GSKScanProtocol scan);

		// @required -(void)cameraSession:(GSKCameraSession *)cameraSession didFailWithError:(NSError *)error;
		[Abstract]
		[Export ("cameraSession:didFailWithError:")]
		void CameraSessionDidFailWithError (GSKCameraSession cameraSession, NSError error);

		// @required -(void)cameraSession:(GSKCameraSession *)cameraSession didFindQuadrangle:(GSKQuadrangle *)quadrangle;
		[Abstract]
		[Export ("cameraSession:didFindQuadrangle:")]
		void CameraSessionDidFindQuadrangle (GSKCameraSession cameraSession, GSKQuadrangle quadrangle);

		// @optional -(void)cameraSessionDidSetup:(GSKCameraSession *)cameraSession;
		[Export ("cameraSessionDidSetup:")]
		void CameraSessionDidSetupDidSetup (GSKCameraSession cameraSession);

		// @optional -(void)cameraSessionFailedToFindQuadrangle:(GSKCameraSession *)cameraSession;
		[Export ("cameraSessionFailedToFindQuadrangle:")]
		void CameraSessionFailedToFindQuadrangle (GSKCameraSession cameraSession);

		// @optional -(void)cameraSession:(GSKCameraSession *)cameraSession willAutoTriggerWithQuadrangle:(GSKQuadrangle *)quadrangle;
		[Export ("cameraSession:willAutoTriggerWithQuadrangle:")]
		void CameraSessionWillautoTriggerWithQuadrangle (GSKCameraSession cameraSession, GSKQuadrangle quadrangle);

		// @optional -(void)cameraSessionIsAboutToChooseQuadrangle:(GSKCameraSession *)cameraSession;
		[Export ("cameraSessionIsAboutToChooseQuadrangle:")]
		void CameraSessionIsAboutToChooseQuadrangle (GSKCameraSession cameraSession);

		// @optional -(void)cameraSessionisSearchingQuadrangle:(GSKCameraSession *)cameraSession;
		[Export ("cameraSessionisSearchingQuadrangle:")]
		void CameraSessionisSearchingQuadrangle (GSKCameraSession cameraSession);

		// @optional -(void)cameraSessionDidStart:(GSKCameraSession *)cameraSession;
		[Export ("cameraSessionDidStart:")]
		void CameraSessionDidStart (GSKCameraSession cameraSession);

		// @optional -(void)cameraSessionDidStop:(GSKCameraSession *)cameraSession;
		[Export ("cameraSessionDidStop:")]
		void CameraSessionDidStop (GSKCameraSession cameraSession);

		// @optional -(void)cameraSession:(GSKCameraSession *)cameraSession wasInterruptedWithReason:(AVCaptureSessionInterruptionReason)reason;
		[Export ("cameraSession:wasInterruptedWithReason:")]
		void CameraSessionWasInterrupted (GSKCameraSession cameraSession, AVCaptureSessionInterruptionReason reason);

		// @optional -(void)cameraSessionInterruptionEnded:(GSKCameraSession *)cameraSession;
		[Export ("cameraSessionInterruptionEnded:")]
		void CameraSessionInterruptionEnded (GSKCameraSession cameraSession);
	}

	// @public interface GSKCameraSession : NSObject
	[BaseType (typeof(NSObject))]
	public interface GSKCameraSession
	{
		// -(instancetype)initWithScanFactory:(id<GSKScanFactoryProtocol>)scanFactory __attribute__((objc_designated_initializer));
		[Export ("initWithScanFactory:")]
		[DesignatedInitializer]
		IntPtr Constructor (GSKScanFactoryProtocol scanFactory);

		// TODO Fix this
		// @property (readonly, nonatomic) GSKCaptureHandler * cameraCaptureHandler;
		//[Export ("cameraCaptureHandler")]
		//GSKCaptureHandler CameraCaptureHandler { get; }

		// @property (readonly, nonatomic) AVCaptureDevice * captureDevice;
		[Export ("captureDevice")]
		AVCaptureDevice CaptureDevice { get; }

		// @property (readonly, nonatomic) AVCaptureDeviceInput * captureInput;
		[Export ("captureInput")]
		AVCaptureDeviceInput CaptureInput { get; }

		// @property (readonly, nonatomic) AVCaptureSession * captureSession;
		[Export ("captureSession")]
		AVCaptureSession CaptureSession { get; }

		// @property (readonly, nonatomic) AVCaptureConnection * captureConnection;
		[Export ("captureConnection")]
		AVCaptureConnection CaptureConnection { get; }

		// @property (readonly, nonatomic) AVCaptureStillImageOutput * captureStillImageOutput;
		[Export ("captureStillImageOutput")]
		AVCaptureStillImageOutput CaptureStillImageOutput { get; }

		// -(void)setup;
		[Export ("setup")]
		void Setup ();

		// -(void)startSessionOnComplete:(GSKCameraVoidBlock)onComplete;
		[Export ("startSessionOnComplete:")]
		void StartSessionOnComplete (GSKCameraVoidBlock onComplete);

		// -(void)stopSessionOnComplete:(GSKCameraVoidBlock)onComplete;
		[Export ("stopSessionOnComplete:")]
		void StopSessionOnComplete (GSKCameraVoidBlock onComplete);

		// -(void)focusAtPoint:(IntPtr)focusPoint;
		[Export ("focusAtPoint:")]
		void FocusAtPoint (IntPtr focusPoint);

		// -(void)setFlashStatus:(GSKCameraSessionFlashStatus)flashStatus onSuccess:(void (^)(GSKCameraSessionFlashStatus))successBlock error:(void (^)(NSError *))errorBlock;
		[Export ("setFlashStatus:onSuccess:error:")]
		void SetFlashStatus (GSKCameraSessionFlashStatus flashStatus, Action<GSKCameraSessionFlashStatus> successBlock, Action<NSError> errorBlock);

		// -(void)takePhoto;
		[Export ("takePhoto")]
		void TakePhoto ();

		// @property (getter = isTakingPhoto, assign, nonatomic) BOOL takingPhoto;
		[Export ("takingPhoto")]
		bool TakingPhoto { [Bind ("isTakingPhoto")] get; set; }

		// -(void)cleanup;
		[Export ("cleanup")]
		void Cleanup ();

		// @property (getter = isAutoTriggerEnabled, assign, nonatomic) BOOL autoTriggerEnabled;
		[Export ("autoTriggerEnabled")]
		bool AutoTriggerEnabled { [Bind ("isAutoTriggerEnabled")] get; set; }

		[Wrap ("WeakDelegate")]
		GSKCameraSessionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GSKCameraSessionDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @public interface GSKCameraViewController : UIViewController <GSKCameraSessionDelegate>
	[BaseType (typeof(UIViewController))]
	public interface GSKCameraViewController : GSKCameraSessionDelegate
	{
		// -(instancetype)initWithCameraSession:(GSKCameraSession *)cameraSession __attribute__((objc_designated_initializer));
		[Export ("initWithCameraSession:")]
		[DesignatedInitializer]
		IntPtr Constructor (GSKCameraSession cameraSession);

		// @property (readonly, nonatomic) UIView * cameraView;
		[Export ("cameraView")]
		UIView CameraView { get; }

		// @property (nonatomic, strong) GSKView * captureView;
		[Export ("captureView", ArgumentSemantic.Strong)]
		GSKView CaptureView { get; set; }

		// @property (readonly, nonatomic) GSKShutterView * shutterView;
		[Export ("shutterView")]
		GSKShutterView ShutterView { get; }

		// -(void)takePhoto;
		[Export ("takePhoto")]
		void TakePhoto ();

		// @property (assign, nonatomic) BOOL drawsDocumentFrameOverlay;
		[Export ("drawsDocumentFrameOverlay")]
		bool DrawsDocumentFrameOverlay { get; set; }

		// @property (copy, nonatomic) UIColor * overlayColor;
		[Export ("overlayColor", ArgumentSemantic.Copy)]
		UIColor OverlayColor { get; set; }

		// @property (readonly, nonatomic) GSKCameraSession * cameraSession;
		[Export ("cameraSession")]
		GSKCameraSession CameraSession { get; }
	}

	// @public interface GSKEditFrameViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	public interface GSKEditFrameViewController
	{
		// @property (nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (assign, nonatomic) GSKQuadrangle * quadrangle;
		[Export ("quadrangle", ArgumentSemantic.Assign)]
		GSKQuadrangle Quadrangle { get; set; }

		// @property (readonly, nonatomic) UIView * frameView;
		[Export ("frameView")]
		UIView FrameView { get; }

		// @property (copy, nonatomic) UIColor * shadeColor;
		[Export ("shadeColor", ArgumentSemantic.Copy)]
		UIColor ShadeColor { get; set; }

		// @property (copy, nonatomic) UIColor * lineColor;
		[Export ("lineColor", ArgumentSemantic.Copy)]
		UIColor LineColor { get; set; }
	}

	// @public interface GSKShutterView : UIView
	[BaseType (typeof(UIView))]
	public interface GSKShutterView
	{
		// -(void)shut;
		[Export ("shut")]
		void Shut ();

		// -(void)reveal;
		[Export ("reveal")]
		void Reveal ();
	}

	// @protocol GSCViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	public interface GSCViewDelegate
	{
		// @required -(void)cameraView:(GSKView *)cameraView requestedFocusAtPoint:(IntPtr)focusPoint;
		[Abstract]
		[Export ("cameraView:requestedFocusAtPoint:")]
		void RequestedFocusAtPoint (GSKView cameraView, IntPtr focusPoint);
	}

	// @public interface GSKView : UIView
	[BaseType (typeof(UIView))]
	public interface GSKView
	{
		// -(void)initializeRotationWithpublic interfaceOrientation:(UIpublic interfaceOrientation)orientation;
		[Export ("initializeRotationWithpublicInterfaceOrientation:")]
		void InitializeRotationWithpublicInterfaceOrientation (UIInterfaceOrientation Orientation);

		// -(void)rotateWithCoordinator:(id<UIViewControllerTransitionCoordinator>)coordinator;
		[Export ("rotateWithCoordinator:")]
		void RotateWithCoordinator (IUIViewControllerTransitionCoordinator coordinator);

		// -(void)animateFocusAtLocation:(IntPtr)location;
		[Export ("animateFocusAtLocation:")]
		void AnimateFocusAtLocation (IntPtr location);

		// -(void)updateQuadrangle:(GSKQuadrangle *)quadrangle;
		[Export ("updateQuadrangle:")]
		void UpdateQuadrangle (GSKQuadrangle quadrangle);

		// -(void)setCaptureSession:(AVCaptureSession *)session;
		[Export ("setCaptureSession:")]
		void SetCaptureSession (AVCaptureSession session);

		// -(void)pausePreview;
		[Export ("pausePreview")]
		void PausePreview ();

		// -(void)resumePreview;
		[Export ("resumePreview")]
		void ResumePreview ();

		// @property (readonly, nonatomic) CAShapeLayer * frameLayer;
		[Export ("frameLayer")]
		CAShapeLayer FrameLayer { get; }

		// @property (readonly, nonatomic) CAShapeLayer * snapFrameLayer;
		[Export ("snapFrameLayer")]
		CAShapeLayer SnapFrameLayer { get; }

		// @property (copy, nonatomic) UIColor * overlayColor;
		[Export ("overlayColor", ArgumentSemantic.Copy)]
		UIColor OverlayColor { get; set; }

		[Wrap ("WeakDelegate")]
		GSCViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GSCViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	public partial interface Constants
	{
		// extern const IntPtr GSKQuadrangleTopRightPoint;
		[Field ("GSKQuadrangleTopRightPoint", "__Internal")]
		IntPtr GSKQuadrangleTopRightPoint { get; }

		// extern const IntPtr GSKQuadrangleTopLeftPoint;
		[Field ("GSKQuadrangleTopLeftPoint", "__Internal")]
		IntPtr GSKQuadrangleTopLeftPoint { get; }

		// extern const IntPtr GSKQuadrangleBottomLeftPoint;
		[Field ("GSKQuadrangleBottomLeftPoint", "__Internal")]
		IntPtr GSKQuadrangleBottomLeftPoint { get; }

		// extern const IntPtr GSKQuadrangleBottomRightPoint;
		[Field ("GSKQuadrangleBottomRightPoint", "__Internal")]
		IntPtr GSKQuadrangleBottomRightPoint { get; }
	}

	// @public interface GSKQuadrangle : NSObject
	[BaseType (typeof(NSObject))]
	public interface GSKQuadrangle
	{
		// +(GSKQuadrangle *)emptyQuadrangle;
		[Static]
		[Export ("emptyQuadrangle")]
		GSKQuadrangle EmptyQuadrangle { get; }

		// +(GSKQuadrangle *)maxQuadrangle;
		[Static]
		[Export ("maxQuadrangle")]
		GSKQuadrangle MaxQuadrangle { get; }

		// +(GSKQuadrangle *)quadrangleFromCGRect:(CGRect)rect;
		[Static]
		[Export ("quadrangleFromCGRect:")]
		GSKQuadrangle QuadrangleFromCGRect (CGRect rect);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		bool IsEmpty { get; }

		// -(BOOL)isMax;
		[Export ("isMax")]
		bool IsMax { get; }

		// -(BOOL)isConvex;
		[Export ("isConvex")]
		bool IsConvex { get; }

		// @property (assign, nonatomic) IntPtr topLeft;
		[Export ("topLeft", ArgumentSemantic.Assign)]
		IntPtr TopLeft { get; set; }

		// @property (assign, nonatomic) IntPtr topRight;
		[Export ("topRight", ArgumentSemantic.Assign)]
		IntPtr TopRight { get; set; }

		// @property (assign, nonatomic) IntPtr bottomLeft;
		[Export ("bottomLeft", ArgumentSemantic.Assign)]
		IntPtr BottomLeft { get; set; }

		// @property (assign, nonatomic) IntPtr bottomRight;
		[Export ("bottomRight", ArgumentSemantic.Assign)]
		IntPtr BottomRight { get; set; }

		// -(GSKQuadrangle *)scaleForSize:(CGSize)size;
		[Export ("scaleForSize:")]
		GSKQuadrangle ScaleForSize (CGSize size);

		// -(GSKQuadrangle *)normalizedWithSize:(CGSize)size;
		[Export ("normalizedWithSize:")]
		GSKQuadrangle NormalizedWithSize (CGSize size);

		// -(GSKQuadrangle *)rotatedForUpOrientation:(UIImageOrientation)orientation;
		[Export ("rotatedForUpOrientation:")]
		GSKQuadrangle RotatedForUpOrientation (UIImageOrientation orientation);

		// -(GSKQuadrangle *)rotatedWithoutOrientation:(UIImageOrientation)orientation;
		[Export ("rotatedWithoutOrientation:")]
		GSKQuadrangle RotatedWithoutOrientation (UIImageOrientation orientation);

		// -(GSKQuadrangle *)sanitized;
		[Export ("sanitized")]
		GSKQuadrangle Sanitized { get; }
	}

	// @public interface GSKPDFSize : NSObject
	[BaseType (typeof(NSObject))]
	public interface GSKPDFSize
	{
		// -(instancetype _Nonnull)initWithWidth:(double)width height:(double)height;
		[Export ("initWithWidth:height:")]
		IntPtr Constructor (double width, double height);

		// +(instancetype _Nonnull)PDFSizeWithWidth:(double)width height:(double)height;
		[Static]
		[Export ("PDFSizeWithWidth:height:")]
		GSKPDFSize PDFSizeWithWidth (double width, double height);

		// @property (readonly, nonatomic) double width;
		[Export ("width")]
		double Width { get; }

		// @property (readonly, nonatomic) double height;
		[Export ("height")]
		double Height { get; }
	}

	// @public interface GSKPDFPage : NSObject
	[BaseType (typeof(NSObject))]
	public interface GSKPDFPage
	{
		// -(instancetype _Nonnull)initWithFilePath:(NSString * _Nonnull)filePath inchesSize:(GSKPDFSize * _Nonnull)inchesSize;
		[Export ("initWithFilePath:inchesSize:")]
		IntPtr Constructor (string filePath, GSKPDFSize inchesSize);

		// +(instancetype _Nonnull)PDFPageWithFilePath:(NSString * _Nonnull)filePath inchesSize:(GSKPDFSize * _Nonnull)inchesSize;
		[Static]
		[Export ("PDFPageWithFilePath:inchesSize:")]
		GSKPDFPage PDFPageWithFilePath (string filePath, GSKPDFSize inchesSize);

		// @property (readonly, nonatomic) NSString * _Nonnull filePath;
		[Export ("filePath")]
		string FilePath { get; }

		// @property (readonly, nonatomic) GSKPDFSize * _Nonnull inchesSize;
		[Export ("inchesSize")]
		GSKPDFSize InchesSize { get; }
	}

	// @public interface GSKPDFDocument : NSObject
	[BaseType (typeof(NSObject))]
	public interface GSKPDFDocument
	{
		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title password:(NSString * _Nullable)password keywords:(NSString * _Nullable)keywords pages:(NSArray<GSKPDFPage *> * _Nonnull)pages;
		[Export ("initWithTitle:password:keywords:pages:")]
		IntPtr Constructor ([NullAllowed] string title, [NullAllowed] string password, [NullAllowed] string keywords, GSKPDFPage[] pages);

		// +(instancetype _Nonnull)PDFDocumentWithTitle:(NSString * _Nullable)title password:(NSString * _Nullable)password keywords:(NSString * _Nullable)keywords pages:(NSArray<GSKPDFPage *> * _Nonnull)pages;
		[Static]
		[Export ("PDFDocumentWithTitle:password:keywords:pages:")]
		GSKPDFDocument PDFDocumentWithTitle ([NullAllowed] string title, [NullAllowed] string password, [NullAllowed] string keywords, GSKPDFPage[] pages);

		// @property (readonly, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; }

		// @property (readonly, nonatomic) NSString * _Nullable password;
		[NullAllowed, Export ("password")]
		string Password { get; }

		// @property (readonly, nonatomic) NSString * _Nullable keywords;
		[NullAllowed, Export ("keywords")]
		string Keywords { get; }

		// @property (readonly, nonatomic) NSArray<GSKPDFPage *> * _Nonnull pages;
		[Export ("pages")]
		GSKPDFPage[] Pages { get; }
	}

	// @protocol GSKPDFLogger
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	public interface GSKPDFLogger
	{
		// @required -(void)log:(NSString * _Nonnull)debug;
		[Abstract]
		[Export("log:")]
		void Log(string debug);
	}

	// @protocol GSKPDFImageProcessor
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	public interface GSKPDFImageProcessor
	{
		// @required -(NSString * _Nullable)process:(NSString * _Nonnull)inputFilePath;
		[Abstract]
		[Export("process:")]
		[return: NullAllowed]
		string Process(string inputFilePath);
	}

	// @public interface GSKPDFGenerator : NSObject
	[BaseType (typeof(NSObject))]
	public interface GSKPDFGenerator
	{
		// +(GSKPDFGenerator * _Nullable)createWithDocument:(GSKPDFDocument * _Nonnull)document processor:(id<GSKPDFImageProcessor> _Nullable)processor logger:(id<GSKPDFLogger> _Nullable)logger;
		[Static]
		[Export ("createWithDocument:processor:logger:")]
		[return: NullAllowed]
		GSKPDFGenerator CreateWithDocument (GSKPDFDocument document, [NullAllowed] GSKPDFImageProcessor processor, [NullAllowed] GSKPDFLogger logger);

		// -(GSKPDFGeneratorError)generatePDF:(NSString * _Nonnull)outputFile;
		[Export ("generatePDF:")]
		GSKPDFGeneratorError GeneratePDF (string outputFile);
	}

	// @public interface Public (GSKPDFGenerator)
	[Category]
	[BaseType (typeof(GSKPDFGenerator))]
	public interface GSKPDFGenerator_Public
	{
		// +(GSKPDFGenerator * _Nullable)createWithDocument:(GSKPDFDocument * _Nonnull)document;
		[Static]
		[Export ("createWithDocument:")]
		[return: NullAllowed]
		GSKPDFGenerator CreateWithDocument (GSKPDFDocument document);
	}

	// @public interface GSKPDFNoopImageProcessor : NSObject <GSKPDFImageProcessor>
	[BaseType (typeof(NSObject))]
	public interface GSKPDFNoopImageProcessor : GSKPDFImageProcessor
	{
	}

	// @public interface GSKPDFDefaultLogger : NSObject <GSKPDFLogger>
	[BaseType (typeof(NSObject))]
	public interface GSKPDFDefaultLogger : GSKPDFLogger
	{
	}
}
