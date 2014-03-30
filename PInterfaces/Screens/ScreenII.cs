using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace PInterfaces
{
	public class ScreenII : UIViewController
	{
		public ScreenII () : base (){

		}

		public override void ViewDidLoad (){
			base.ViewDidLoad ();
			Title = "Screen II";
			View.BackgroundColor = UIColor.Orange;

			var paddedLabel = new UIPaddedLabel (new RectangleF (0, 66, Screen.w, 30)) {
				Text = "This is a padded label",
				EdgeInsets = new UIEdgeInsets(0,10,0,0),
				BackgroundColor = UIColor.White,
			};

			var normalLabel = new UILabel (new RectangleF (0, 96, Screen.w, 30)) {
				Text = "This is a normal label",
				BackgroundColor = UIColor.LightGray,
			};

			var paddedTextField = new UIPaddedTextField (new RectangleF (0, 126, Screen.w, 30)) {
				Placeholder = "This is a padded text field",
				EdgeInsets = new UIEdgeInsets(0,0,0,10),
				BackgroundColor = UIColor.White,
				TextAlignment = UITextAlignment.Right,
			};

			paddedTextField.ShouldReturn += t => {
				t.ResignFirstResponder();
				return true;
			};

			var normalTextField = new UITextField (new RectangleF (0, 156, Screen.w, 30)) {
				Placeholder = "This is a normal text field",
				BackgroundColor = UIColor.LightGray,
				TextAlignment = UITextAlignment.Right,
			};

			normalTextField.ShouldReturn += t => {
				t.ResignFirstResponder();
				return true;
			};

			View.AddSubviews (paddedLabel, normalLabel, paddedTextField, normalTextField);
			AddNextScreenButton ();
		}

		void AddNextScreenButton(){
			var nextScreenButton = new UIButton (new RectangleF (0, Screen.h - 50, Screen.w, 50)){
				BackgroundColor = UIColor.LightGray,
			};

			nextScreenButton.SetTitle ("Next screen", UIControlState.Normal);
			nextScreenButton.SetTitleColor (UIColor.Red, UIControlState.Highlighted);
			nextScreenButton.TouchUpInside += (sender, e) => 
				NavigationController.PushViewController (new ScreenIII (), true);

			View.AddSubview (nextScreenButton);
		}
	}
}

