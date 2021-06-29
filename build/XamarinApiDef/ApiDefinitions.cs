using Foundation;
using UIKit;

namespace Binding
{
	// @protocol KeyboardControllerCallback
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface KeyboardControllerCallback
	{
		// @required -(void)onKeyPadPressedWithText:(NSString * _Nullable)text;
		[Abstract]
		[Export ("onKeyPadPressedWithText:")]
		void OnKeyPadPressedWithText ([NullAllowed] string text);

		// @required -(void)textLeftOfCusorWithText:(NSString * _Nullable)text;
		[Abstract]
		[Export ("textLeftOfCusorWithText:")]
		void TextLeftOfCusorWithText ([NullAllowed] string text);

		// @required -(void)textRightOfCusorWithText:(NSString * _Nullable)text;
		[Abstract]
		[Export ("textRightOfCusorWithText:")]
		void TextRightOfCusorWithText ([NullAllowed] string text);

		// @required -(void)enterKeyWithText:(NSString * _Nullable)text;
		[Abstract]
		[Export ("enterKeyWithText:")]
		void EnterKeyWithText ([NullAllowed] string text);

		// @required -(void)deleteKey;
		[Abstract]
		[Export ("deleteKey")]
		void DeleteKey ();

		// @required -(void)changeTosymbols;
		[Abstract]
		[Export ("changeTosymbols")]
		void ChangeTosymbols ();
	}

	// @interface KeyboardProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface KeyboardProxy
	{
		// -(void)onLaunchKeyboardWithViewController:(UIViewController * _Nonnull)viewController delegate:(id<KeyboardControllerCallback> _Nonnull)delegate;
		[Export ("onLaunchKeyboardWithViewController:delegate:")]
		void OnLaunchKeyboardWithViewController (UIViewController viewController, KeyboardControllerCallback @delegate);

		// -(void)onLoginWithUsername:(NSString * _Nonnull)username os:(NSString * _Nonnull)os imei:(NSString * _Nonnull)imei;
		[Export ("onLoginWithUsername:os:imei:")]
		void OnLoginWithUsername (string username, string os, string imei);
	}
}
