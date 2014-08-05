// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace UIImageEffects
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		UIKit.UILabel effectLabel { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		UIKit.UIImageView imageView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (effectLabel != null) {
				effectLabel.Dispose ();
				effectLabel = null;
			}
			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}
		}
	}
}
