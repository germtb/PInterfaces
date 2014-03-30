using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace PInterfaces
{
	public class UIPaddedLabel : UILabel
	{
		public UIEdgeInsets EdgeInsets { get; set; }

		public UIPaddedLabel(RectangleF frame) : base(frame){

		}

		public override void DrawText (RectangleF rect){
			base.DrawText(Utils.InsetRect(rect, EdgeInsets));
		}
	}
}

