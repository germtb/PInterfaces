using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace PInterfaces
{
	public class UIPaddedLabel : UILabel
	{
		public UIEdgeInsets EdgeInsets { get; set; }

		public UIPaddedLabel(RectangleF frame) : base(frame){
			EdgeInsets = new UIEdgeInsets (0, 10, 0, 0);	//This is the default padding
		}

		public override void DrawText (RectangleF rect){
			base.DrawText(Utils.InsetRect(rect, EdgeInsets));
		}
	}
}

