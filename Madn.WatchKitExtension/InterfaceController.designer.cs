// WARNING
//
// This file has been generated automatically by Xamarin Studio Business to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Madn.WatchKitExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		WatchKit.WKInterfaceLabel LblHelloWorld { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LblHelloWorld != null) {
				LblHelloWorld.Dispose ();
				LblHelloWorld = null;
			}
		}
	}
}
