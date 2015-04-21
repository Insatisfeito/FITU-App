using System;
using System.Drawing;
using System.Net;
using System.IO;
using System.CodeDom;
using Mono;
using System.Linq;




using Foundation;
using UIKit;

namespace FITU_Bracara_Avgvsta
{
	public partial class Agenda : UIViewController
	{
		UIWebView webView;

		public Agenda (IntPtr handle) : base (handle)
		{
			Title = NSBundle.MainBundle.LocalizedString ("Notícias", "Notícias");
			TabBarItem.Image = UIImage.FromFile ("agenda");
			View.BackgroundColor = UIColor.White;
			webView = new UIWebView (View.Bounds);
			webView.ScrollView.ContentInset = new UIEdgeInsets(0,0,45,0);
			View.AddSubview(webView);
			string url = "http://ios.tum.pt/noticias.html";
			webView.LoadRequest(new NSUrlRequest(new NSUrl(url)));
			webView.ScalesPageToFit = true;



			 



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

