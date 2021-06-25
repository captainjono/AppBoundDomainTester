// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AppBoundTest
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel DeviceIpAddress { get; set; }

		[Outlet]
		UIKit.UILabel ServerRunningAtLbl { get; set; }

		[Outlet]
		UIKit.UIView viewWeb { get; set; }

		[Action ("OnClick_ClearCache:")]
		partial void OnClick_ClearCache (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DeviceIpAddress != null) {
				DeviceIpAddress.Dispose ();
				DeviceIpAddress = null;
			}

			if (ServerRunningAtLbl != null) {
				ServerRunningAtLbl.Dispose ();
				ServerRunningAtLbl = null;
			}

			if (viewWeb != null) {
				viewWeb.Dispose ();
				viewWeb = null;
			}
		}
	}
}
