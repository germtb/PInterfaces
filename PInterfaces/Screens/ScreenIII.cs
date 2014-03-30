using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace PInterfaces
{
	public class ScreenIII : UIViewController
	{
		UIAutoView autoView;

		public ScreenIII () : base (){

		}

		public override void ViewDidLoad (){
			base.ViewDidLoad ();
			View.BackgroundColor = UIColor.LightGray;

			autoView = new UIAutoView(new RectangleF (0,0, Screen.w, Screen.h)){
				BackgroundColor = UIColor.Orange,
			};

			View.AddSubview (autoView);

			for (int i = 0; i < 20; i++) {
				var l = new UIPaddedLabel (new RectangleF (0, 0, Screen.w, 30 + i % 5 * 20)){
					Text = "Label number " + i.ToString(),
					BackgroundColor = i % 2 == 0 ? UIColor.White : UIColor.LightGray,
				};

				autoView.AddAutoview (l);
			}
		}
	}
}

