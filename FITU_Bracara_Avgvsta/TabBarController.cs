
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FITU_Bracara_Avgvsta
{
	partial class TabBarController : UITabBarController
	{
		public TabBarController (IntPtr handle) : base (handle)
		{
			
			TabBar.BarTintColor = UIColor.Red;
			TabBar.TintColor = UIColor.White;
			TabBar.Translucent = false;



			TabBar.Items[0].Image = UIImage.FromFile ("agenda").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
			TabBar.Items[1].Image = UIImage.FromFile ("tum").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
			TabBar.Items[2].Image = UIImage.FromFile ("fitu").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
			TabBar.Items[3].Image = UIImage.FromFile ("vote").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);


		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}
