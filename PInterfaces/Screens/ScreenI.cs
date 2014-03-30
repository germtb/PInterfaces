using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace PInterfaces
{
	//This class is associated with the first post of metacode3.blospot.com about programatically created interfaces
	public class ScreenI : UIViewController
	{
		public ScreenI () : base (){

		}

		public override void ViewDidLoad (){
			base.ViewDidLoad ();
			Title = "Screen I";
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

			AddNextScreenButton ();
		}

		void AddNextScreenButton(){
			var nextScreenButton = new UIButton (new RectangleF (0, Screen.h - 50, Screen.w, 50)){
				BackgroundColor = UIColor.LightGray,
			};

			nextScreenButton.SetTitle ("Next screen", UIControlState.Normal);
			nextScreenButton.SetTitleColor (UIColor.Red, UIControlState.Highlighted);
			nextScreenButton.TouchUpInside += (sender, e) => 
				NavigationController.PushViewController (new ScreenII (), true);

			View.AddSubview (nextScreenButton);
		}
	}
}

