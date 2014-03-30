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
			Title = "Main";
			View.BackgroundColor = UIColor.White;
			AddNextScreenButton ();
		}

		void AddNextScreenButton(){
			var nextScreenButton = new UIButton (new RectangleF (0, Screen.h - 50, Screen.w, 50)){
				BackgroundColor = UIColor.LightGray,
			};

			nextScreenButton.SetTitle ("Next screen", UIControlState.Normal);
			nextScreenButton.SetTitleColor (UIColor.Red, UIControlState.Highlighted);
			nextScreenButton.TouchUpInside += (sender, e) => 
				NavigationController.PushViewController (new ScreenI (), true);

			View.AddSubview (nextScreenButton);
		}
	}
}