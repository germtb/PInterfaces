using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace PInterfaces
{
	public class MainScreen : UIViewController
	{
		public MainScreen () : base (){

		}

		public override void ViewDidLoad (){
			base.ViewDidLoad ();

			View.BackgroundColor = UIColor.Orange;

			var label = new UILabel (new RectangleF (50, 100, 100, 30)) {
				BackgroundColor = UIColor.Blue,
				Text = "Label",
				TextAlignment = UITextAlignment.Center,
			};

			View.AddSubview (label);

			var button = new UIButton (new RectangleF (50, 140, 100, 30)){
				BackgroundColor = UIColor.LightGray,
			};
			button.SetTitle ("Button", UIControlState.Normal);
			button.SetTitleColor (UIColor.Red, UIControlState.Highlighted);
			button.TouchUpInside += (sender, e) => 
				label.Text = new Random ().Next (0, 1000).ToString ();

			View.AddSubview (button);
		}
	}
}